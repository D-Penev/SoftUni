namespace EncapsulationExercises
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class StartUp
    {
        public static void Main()
        {
            var listOfPeople = new List<Person>();
            var listOfProducts = new List<Product>();

            string[] personData = Console.ReadLine().Split(new string[] { "=", ";" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] productData = Console.ReadLine().Split(new string[] { "=", ";" }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            decimal currentMoney = 0;
            string currentName = string.Empty;
            foreach (var item in personData)
            {
                if (!Decimal.TryParse(item,out currentMoney))
                {
                    currentName = item;
                }
                else
                {
                    try
                    {
                        var currentPerson = new Person(currentName, currentMoney);
                        listOfPeople.Add(currentPerson);
                    }
                    catch (ArgumentException maikati)
                    {

                        Console.WriteLine(maikati.Message);
                        return;
                    }
                }
                
            }

            string productName = string.Empty;
            decimal productCost = 0m;
            foreach (var item in productData)
            {
                if (!Decimal.TryParse(item,out productCost))
                {
                    productName = item;
                }
                else
                {
                    try
                    {
                        var product = new Product(productName, productCost);
                        listOfProducts.Add(product);
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                        return;
                    }
                }
            }

            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "END")
                {
                    break;
                }
                string[] tokens = commandLine.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = tokens[0];
                string product = tokens[1];

                var currentPerson = listOfPeople.FirstOrDefault(x => x.Name == name);

                var currentProduct = listOfProducts.FirstOrDefault(x => x.Name == product);

                currentPerson.BuyProduct(currentProduct);
               
            }

            foreach (var person in listOfPeople)
            {
                if (person.Products.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {String.Join(", ",person.Products)}");
                }
            }
            
        }
    }
}