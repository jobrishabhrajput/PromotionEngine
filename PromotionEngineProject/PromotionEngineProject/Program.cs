using System;
using PromotionEngineProject;

namespace PromotionEngineProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Products in a space separated array.");
            Console.WriteLine("e.g. 2A 3C D is 2 quantity of A, 3 quantity of C and one D.");

            QueryEngine engine = new QueryEngine();
            Console.WriteLine( engine.GetPrice());

            Console.ReadLine();

        }
    }
}
