namespace PathfinderIM.Data
{
    public static class DataInitializer
    {
        public static void InitializeData(PathfinderItemContext context, bool wipeCurrentData)
        {
            if (wipeCurrentData)
            {
                context.Database.EnsureDeleted();
            }
            context.Database.EnsureCreated();
            SeedData.Initialize(context);
        }
    }
}
