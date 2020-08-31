using PromotionEngineProject.BusinessLogic;
using PromotionEngineProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngineProject
{
    public class QueryEngine
    {
        private Products product = new Products();
        public string GetPrice()
        {

            Dictionary<string, int> inquiry = new Dictionary<string, int>();

            try
            {
                foreach (var elem in Console.ReadLine().Split())
                {
                    if (elem.Where(Char.IsDigit).ToArray().Length == 0)
                        inquiry.Add(new String(elem.Where(Char.IsLetter).ToArray()), 1);
                    else
                        inquiry.Add(new String(elem.Where(Char.IsLetter).ToArray()), Convert.ToInt32(new String(elem.Where(Char.IsDigit).ToArray())));
                }
                int total = 0;
                foreach (var elem in inquiry)
                {
                    var price = product.GetPrice((ProductMap)Enum.Parse(typeof(ProductMap), elem.Key, true), elem.Value);
                    Console.WriteLine("Quoted price for product " + elem.Key + " : " + price);
                    total += price;
                }
                Console.WriteLine("Total Price for your Product List is " + total);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Input. Please try again..");
            }

            return "Final Price : " + inquiry.Discounted();
        }
    }
}
