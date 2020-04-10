using System.IO;
using Newtonsoft.Json;

namespace PathfinderIM.Data
{
    public static class SeedData
    {
        public static void Initialize(PathfinderItemContext context)
        {
            var path = 
                Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory,"BaseData");

            var dataFiles = System.IO.Directory.GetFiles(path, "*_base.json");
            foreach (var file in dataFiles)
            {
                LoadData(context, file);
            }
        }

        private static void LoadData(PathfinderItemContext context, string file)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string json = reader.ReadToEnd();
                dynamic items = JsonConvert.DeserializeObject(json);

                
            }

            context.SaveChanges();
        }
    }
}
