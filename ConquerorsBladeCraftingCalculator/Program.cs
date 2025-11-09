using ConquerorsBladeCraftingCalculator.BaseClasses;
using ConquerorsBladeCraftingCalculator.Enums;
using ConquerorsBladeCraftingCalculator.Interfaces;

namespace ConquerorsBladeCraftingCalculator
{
    public class Program(IMarketService market, ITradeColonyService tradeColony)
    {
        private readonly IMarketService _market = market;
        private readonly ITradeColonyService _tradeColony = tradeColony;

        public Advice CalculateCheapestAdvice(UnitKit unitKit)
        {
            var marketPrice = _market.GetPrice(unitKit);
            var tradingpostPrice = _tradeColony.GetPrice(unitKit); //TODO add calculations
            var craftingCostMaterials = CalculateWithBuyingMaterials(unitKit);
            var craftingCostResources = CalculateWithBuyingResourcesAndRefiningMaterials(unitKit);

            if (marketPrice < craftingCostMaterials && marketPrice < craftingCostResources)
            {
                Console.WriteLine($"Marketprice: {marketPrice} is lower than all crafting it, even if you refine your own materials. Buy the kit.");
                return Advice.BuyKit;
            }

            if (craftingCostMaterials < craftingCostResources)
            {
                Console.WriteLine($"Material cost: {craftingCostMaterials} is cheaper than resource cost: {craftingCostResources}. Buy the materials.");
                return Advice.BuyMaterials;
            }

            Console.WriteLine($"Resource cost: {craftingCostResources} is cheaper than materials cost: {craftingCostMaterials} or kit cost: {marketPrice}. Buy the resources then refine the materials.");
            return Advice.BuyResources;
        }

        public int CalculateCheapestPrice(UnitKit unitKit)
        {
            var craftingCost = unitKit.CraftingCost;
            //calculate cost of buying materials or buying resources and crafting the material
            foreach (var materialQuantity in unitKit.RequiredMaterials) //TODO DRY
            {
                //for each quantity of material, see if its cheaper to buy or craft
                //for (int i = 0; i < materialQuantity.Quantity; i++)
                //{
                //    var materialCost = _market.GetPriceResultIncrement(materialQuantity.Material, i);
                //    var materialCraftingCost = materialQuantity.Material.CraftingCost;
                var materialCost = _market.GetPrice(materialQuantity.Material, materialQuantity.Quantity);
                var materialRefiningCost = materialQuantity.Material.RefiningCost * materialQuantity.Quantity;

                foreach (var resourceQuantity in materialQuantity.Material.RequiredResources) //TODO DRY
                {
                    var resourceCost = _market.GetPrice(resourceQuantity.Resource, resourceQuantity.Quantity);
                    //TODO compare resourceCost for IExotics from openworld trade posts _tradepost.GetPrice(resourceQuantity.Resource);
                    materialRefiningCost += resourceCost.Value;
                }

                if (materialCost.Value < materialRefiningCost)
                {
                    craftingCost += materialCost.Value;
                    Console.WriteLine($"Buying {materialQuantity.Quantity} {materialQuantity.Material} for {materialCost} silver is cheaper than to buy resources and refining it yourself for {materialRefiningCost} silver");
                }

                craftingCost += materialRefiningCost;
                Console.WriteLine($"Refining {materialQuantity.Quantity} {materialQuantity.Material} for resource sum {materialRefiningCost} silver is cheaper than buying it at {materialCost} silver.");
                //}
            }

            var cheapestPrice = _market.GetPrice(unitKit).Value;
            var tradeColonyPrice = _tradeColony.GetPrice(unitKit).Value;
            if (tradeColonyPrice < cheapestPrice)
            {
                Console.WriteLine($"Buying {unitKit.GetType().Name} at trade colony for {tradeColonyPrice} silver. Is cheaper than to buy it for {cheapestPrice} silver at market");
                cheapestPrice = tradeColonyPrice;                
            }
            if (craftingCost < cheapestPrice)
            {                
                Console.WriteLine($"Crafting {unitKit.GetType().Name} for {craftingCost} silver. Is cheaper than to buy it for {cheapestPrice} silver");
                cheapestPrice = craftingCost;
            }

            return cheapestPrice;
        }

        private int CalculateWithBuyingResourcesAndRefiningMaterials(UnitKit unitKit)
        {
            var craftingCost = unitKit.CraftingCost;
            foreach (var materialQuantity in unitKit.RequiredMaterials)
            {
                var materialRefiningCost = materialQuantity.Material.RefiningCost * materialQuantity.Quantity;
                craftingCost += materialRefiningCost;
                Console.WriteLine($"{materialRefiningCost} silver to refine {materialQuantity.Quantity} {materialQuantity.Material}");
                foreach (var resourceQuantity in materialQuantity.Material.RequiredResources)
                {
                    var resourceCost = _market.GetPrice(resourceQuantity.Resource, resourceQuantity.Quantity);
                    craftingCost += resourceCost.Value;
                    Console.WriteLine($"{resourceQuantity.Quantity} {resourceQuantity.Resource} for {resourceCost} silver");
                }
            }

            Console.WriteLine($"{craftingCost} silver to refine materials then craft it yourself");
            return craftingCost;
        }

        private int CalculateWithBuyingMaterials(UnitKit unitKit)
        {
            var craftingCost = unitKit.CraftingCost;
            foreach (var materialQuantity in unitKit.RequiredMaterials)
            {
                var materialCost = _market.GetPrice(materialQuantity.Material, materialQuantity.Quantity);
                craftingCost += materialCost.Value;
                Console.WriteLine($"{materialQuantity.Quantity} {materialQuantity.Material} for {materialCost} silver");
            }

            Console.WriteLine($"{craftingCost} silver to craft it yourself");
            return craftingCost;
        }

        public static void Main()
        {   //TaxFraction = 0,1;
            //TODO make method CalculateProfit(ITradable) => ITradable.SalePrice * (1-TaxFraction) * ITradable.Quantity  
            //Unit sale price can't be higher than max value or lower than min value.

            //Can also add buying cost, deducts that from profit and returns profit figure and percentage based on investment.resource cost if provided and material costs if provided, crafting costs for every step in process.
        }
    }
}