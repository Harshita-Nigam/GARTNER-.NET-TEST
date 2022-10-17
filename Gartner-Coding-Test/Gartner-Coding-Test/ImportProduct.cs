using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace ConsoleApp
{
    public class ImportProduct
    {

        public static void importProductData(string filePath)
        {
            string ex = Path.GetExtension(filePath);
            if (ex.ToLower() == ".json")
                importJSONData(filePath);
            else if(ex.ToLower() == ".yaml")
                importYAMLData(filePath);
        }

        private static void importJSONData(string filePath)
        {
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                dynamic stuff = JsonConvert.DeserializeObject(json);
                List<Product> items = JsonConvert.DeserializeObject<List<Product>>(stuff.products.ToString());
                foreach (Product b in items)
                {
                    Console.WriteLine("importing: Name: " + b.title + "; Categories: " + string.Join(", ", b.categories) + "; Twitter: " + b.twitter);

                }
            }
        }

        private static void importYAMLData(string filePath)
        {
            using (StreamReader r = new StreamReader(filePath))
            {
                string yamlContents = r.ReadToEnd();
                var deserializer = new DeserializerBuilder()
                                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                                    .Build();
                List<YamlProduct> items = deserializer.Deserialize<List<YamlProduct>>(yamlContents);
                foreach (YamlProduct b in items)
                {
                    Console.WriteLine("importing: Name: " + b.name + "; Categories: " + string.Join(", ", b.tags) + "; Twitter: @" + b.twitter);

                }
            }
        }
    }
}
