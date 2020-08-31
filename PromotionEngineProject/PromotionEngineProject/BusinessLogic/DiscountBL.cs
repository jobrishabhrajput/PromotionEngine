
using PromotionEngineProject.Models;
using System.Collections.Generic;

namespace PromotionEngineProject.BusinessLogic
{
    static class DiscountBL
    {
        public static int Discounted(this Dictionary<string, int> inquiry)
        {
            int discountedTotal = 0;
            if (inquiry.TryGetValue("A", out int quantA))
            {
                discountedTotal = quantA / 3 * ProductPrice.A3 + (quantA % 3) * ProductPrice.A;
            }

            if (inquiry.TryGetValue("B", out int quantB))
            {
                discountedTotal += quantB / 2 * ProductPrice.B2 + (quantA % 2) * ProductPrice.B;
            }

            if (inquiry.TryGetValue("C", out int quantC) && inquiry.TryGetValue("D", out int quantD))
            {
                if (quantC <= quantD)
                {
                    quantD = quantD - quantC;
                    discountedTotal += quantC * ProductPrice.CD;
                    discountedTotal += quantD * ProductPrice.D;
                }
                else
                {
                    quantC = quantC - quantD;
                    discountedTotal += quantD * ProductPrice.CD;
                    discountedTotal += quantC * ProductPrice.C;
                }
            }

            return discountedTotal;
        }
    }




}
