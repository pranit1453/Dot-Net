using System.Reflection;
using System.Text.Json;


namespace Attribute_Reflection_Serialization_Deserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bvsdll = @"D:\250845920054\MS Dot Net\MS Dot Net\CustomAttribute\bin\Debug\net8.0\CustomAttribute.dll";
            string filepath = @"D:\250845920054\MS Dot Net\MS Dot Net\Attribute_Reflection_Serialization_Deserialization\Data File\data.json";
            string textpath = @"D:\250845920054\MS Dot Net\MS Dot Net\Attribute_Reflection_Serialization_Deserialization\Data File\text.txt";
            Assembly assBVS = Assembly.LoadFrom(bvsdll);

            if(assBVS != null)
            {
                Console.WriteLine("DLL files Loaded Successfully.....");

                Type[] types = assBVS.GetTypes();
                var attributeDataList = new List<object>(); // Store all attribute info

                foreach (Type type in types)
                {
                    Console.WriteLine($"Type : {type.FullName}");

                    Object[] attributes = type.GetCustomAttributes(false); //false → does not include inherited attributes

                    foreach (Object attribute in attributes)
                    {

                        Console.WriteLine($"Attributes : {attribute.GetType().Name}");

                        //if(attribute is CustomAttribute.BonaventureSystemAttribute bvsAttribute)
                        // Safe checking, ensures you only operate on the correct attribute.
                        //{
                        //    Console.WriteLine($"Company : {bvsAttribute.CompanyName}");
                        //    Console.WriteLine($"Developer Name : {bvsAttribute.DeveloperName}");
                        //}

                        if (attribute.GetType().Name == "BonaventureSystemAttribute")
                        {
                            PropertyInfo? companyProp = attribute.GetType().GetProperty("CompanyName");
                            //if(companyProp != null)
                            //{
                            //    Console.WriteLine($"Company Name : {companyProp.GetValue(attribute)}");
                            //}
                            string company = companyProp?.GetValue(attribute)?.ToString() ?? "";
                            PropertyInfo? developerProp = attribute.GetType().GetProperty("DeveloperName");
                            //if(developerProp != null)
                            //{
                            //    Console.WriteLine($"Developer Name : {developerProp.GetValue(attribute)}");
                            //}
                            string developer = developerProp?.GetValue(attribute)?.ToString() ?? "";

                            attributeDataList.Add(new
                            {
                                Type = type.FullName,
                                Attribute = attribute.GetType().Name,
                                CompanyName = company,
                                DeveloperName = developer
                            });
                        }
                    }
                }

                // serialize all attribute to json

                using (FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write))
                {
                    JsonSerializer.Serialize(fs, attributeDataList);
                }
                // Serialize all attribute data to JSON
                // File.WriteAllText(filepath, JsonSerializer.Serialize(attributeDataList));

                
                Console.WriteLine("Serialization done successfully!");

                string jsonData = File.ReadAllText(filepath);
                attributeDataList = JsonSerializer.Deserialize<List<object>>(jsonData) ?? new List<object>();
                foreach(Object attr in attributeDataList)
                {
                    Console.WriteLine($"{attr}");
                }
                Console.WriteLine("Deserialization done successfully!");
            }
        }
    }
}
