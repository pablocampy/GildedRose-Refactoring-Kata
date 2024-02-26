namespace GildedRoseKata.Extensions
{
    public static class ItemExtension
    {
        public static void EnsureNoNegativeQuality(this Item item)
        {
            if (item != null)
            {
                if (item.Quality < 0)
                {
                    item.Quality = 0;
                }
            }
        }
    }
}
