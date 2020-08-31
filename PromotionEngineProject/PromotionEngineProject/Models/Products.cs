using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineProject.Models
{
    class Products
    {
        public int GetPrice(ProductMap product, int quantity)
        {
            int price = 0;
            switch (product)
            {
                case (ProductMap.A):
                    price = PromotionA.A;
                    break;
                case (ProductMap.B):
                    price = PromotionB.B;
                    break;
                case (ProductMap.C):
                    price = PromotionCD.C;
                    break;
                case (ProductMap.D):
                    price = PromotionCD.D;
                    break;
                default:
                    break;
            }

            return quantity * price;
        }
    }

    
}
