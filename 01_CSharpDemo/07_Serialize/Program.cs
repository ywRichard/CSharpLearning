using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _07_Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Product> products = new List<Product>();
                products.Add(new Product(1, "Spiky Pung", 1000.0, "Good stuff."));
                products.Add(new Product(2, "Gloop Galloop Soup", 25.0, "Tasty."));
                products.Add(new Product(4, "Hat Sauce", 12.0, "One for the kids."));

                Console.WriteLine("Product to save:");
                foreach (var product in products)
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();

                #region serialize products
                IFormatter serializer = new BinaryFormatter();

                FileStream saveFile = new FileStream("products.bin", FileMode.Create, FileAccess.Write);
                serializer.Serialize(saveFile, products);
                saveFile.Close();
                #endregion

                #region deserialize products
                FileStream loadFile = new FileStream("Products.bin", FileMode.Open, FileAccess.Read);
                List<Product> savedProducts = serializer.Deserialize(loadFile) as List<Product>;
                loadFile.Close();
                #endregion

                Console.WriteLine("Products loaded:");
                foreach (var product in savedProducts)
                {
                    Console.WriteLine(product);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("A IOexception thrown");
                Console.WriteLine(e.Message);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("A serialization exception thrown");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }

}
