namespace GildedRoseKata.Extensions
{
    public static class ItemExtension
    {
        private const int MIN_QUALITY_VALUE = 0;
        private const int MAX_QUALITY_VALUE = 50;

        public static void EnsureValidValues(this Item item)
        {
            if (item != null)
            {
                if (item.Quality < 0)
                {
                    item.Quality = MIN_QUALITY_VALUE;
                }
                if (item.Quality > MAX_QUALITY_VALUE)
                {
                    item.Quality = MAX_QUALITY_VALUE;
                }
            }
        }
    }
}
