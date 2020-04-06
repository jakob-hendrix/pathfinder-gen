namespace PathfinderIM.Data
{
    public static class DataInitializer
    {
        public static void InitializeData(PathfinderItemContext context)
        {
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            SeedData.Initialize(context);
        }
    }
}
