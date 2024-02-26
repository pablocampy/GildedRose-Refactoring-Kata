namespace GildedRoseKata.Strategies
{
    public class StrategyContext 
    {
        private const string AGED_BRIE_STRING_MATCHER = "aged brie";
        private const string BACKSTAGE_PASS_STRING_MATCHER = "backstage pass";
        private const string SULFURAS_STRING_MATCHER = "sulfuras";
        private const string CONJURED_STRING_MATCHER = "conjured";

        private readonly IItemUpdateStrategy _itemUpdateStrategy;

        public StrategyContext(string name)
        {
            if (name.Contains(AGED_BRIE_STRING_MATCHER))
            {
                _itemUpdateStrategy = new AgedBrieUpdateStrategy();
            }
            else if (name.Contains(BACKSTAGE_PASS_STRING_MATCHER))
            {
                _itemUpdateStrategy = new BackstagePassUpdateStrategy();
            }
            else if (name.Contains(SULFURAS_STRING_MATCHER))
            {
                _itemUpdateStrategy = new BackstagePassUpdateStrategy();
            }
            else if (name.Contains(CONJURED_STRING_MATCHER))
            {
                _itemUpdateStrategy = new ConjuredItemUpdateStrategy();
            }
        }

        public void ExecuteStrategy(Item item)
        {
            _itemUpdateStrategy.UpdateQuality(item);
        }
    }
}
