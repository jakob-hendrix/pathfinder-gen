using System.IO;

namespace PathfinderIM.Data
{
    public static class SeedData
    {
        public static void Initialize(PathfinderItemContext context)
        {
            //TODO - load from local json files
            var path = 
                Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory,"SeedData");

            var dataFiles = System.IO.Directory.GetFiles(path, "*.json");

            foreach (var file in dataFiles)
            {
                // read this file
                LoadData(context, file);
            }
        }

        private static void LoadData(PathfinderItemContext context, string file)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                // TODO: unpack this json object into the search book and wondrous items
            }
        }
    }
}

// context.WondrousItems.Add(item);
// context.SaveChanges();
