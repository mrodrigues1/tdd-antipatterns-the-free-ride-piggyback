namespace TddAntipatterns.TheFreeRidePiggyBack
{
    public class DiscountCalculator
    {
        public decimal CalculateDiscount1(int age)
        {
            if (age > 60)
                return 0.2M;

            return 0;
        }

        public decimal CalculateDiscount(int age, bool firtPurchase)
        {
            if (firtPurchase)
                return 0.1M;
            else if (age > 60)
                return 0.2M;

            return 0;
        }
    }
}