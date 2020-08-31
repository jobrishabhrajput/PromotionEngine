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
                    price = ProductPrice.A;
                    break;
                case (ProductMap.B):
                    price = ProductPrice.B;
                    break;
                case (ProductMap.C):
                    price = ProductPrice.C;
                    break;
                case (ProductMap.D):
                    price = ProductPrice.D;
                    break;
                default:
                    break;
            }

            return quantity * price;
        }
    }

    
}
