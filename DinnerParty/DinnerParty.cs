using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public decimal CostOfBeveragesPerPerson =20.0M; //with alcohol
        public decimal CostOfDecorationsPerPerson = 7.5M; //Normal option
        public decimal OverallDiscount_healthyOption; //5% discount if Healthy
        int OneTimeDecorationFee = 30; //Normal decoration one time fee

        public void SetHealthyOption(bool Healthy)
        {
            if (Healthy)
            {
                CostOfBeveragesPerPerson = 5.0M;
                OverallDiscount_healthyOption = .95M; //5% discount
            }

            else
            {
                CostOfBeveragesPerPerson = 10.0M;
                OverallDiscount_healthyOption = 1; //0% discount
            }
        }

        public void CalculateCostOfDecorations(bool FancyDecorations)
        {
            if (FancyDecorations)
            {
                CostOfDecorationsPerPerson = 15;
                OneTimeDecorationFee = 50;
            }

            else
            {
                CostOfDecorationsPerPerson = 7.5M;
                OneTimeDecorationFee = 30;
            }
        }

        public decimal CalculateDinnerCost(decimal TotalPeople)
        {
            Decimal Total = CostOfBeveragesPerPerson * TotalPeople + CostOfFoodPerPerson * TotalPeople + CostOfDecorationsPerPerson * TotalPeople + (Decimal)OneTimeDecorationFee;
            decimal DiscountedTotal = Total*OverallDiscount_healthyOption;
            return DiscountedTotal;
        }

    }
}
