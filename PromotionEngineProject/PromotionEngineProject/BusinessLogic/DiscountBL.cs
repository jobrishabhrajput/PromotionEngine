
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
                discountedTotal = quantA / 3 * PromotionA.A3 + (quantA % 3) * PromotionA.A;
            }

            if (inquiry.TryGetValue("B", out int quantB))
            {
                discountedTotal += ((quantB / 2) * PromotionB.B2) + ((quantB % 2) * PromotionB.B);
            }

            if (inquiry.TryGetValue("C", out int quantC) && inquiry.TryGetValue("D", out int quantD))
            {
                if (quantC <= quantD)
                {
                    quantD = quantD - quantC;
                    discountedTotal += quantC * PromotionCD.CD;
                    discountedTotal += quantD * PromotionCD.D;
                }
                else
                {
                    quantC = quantC - quantD;
                    discountedTotal += quantD * PromotionCD.CD;
                    discountedTotal += quantC * PromotionCD.C;
                }
            }
            else
            {
                inquiry.TryGetValue("D", out int quantityD);
                discountedTotal += quantC * PromotionCD.C;
                discountedTotal += quantityD * PromotionCD.D;
            }

            return discountedTotal;
        }
    }




}
