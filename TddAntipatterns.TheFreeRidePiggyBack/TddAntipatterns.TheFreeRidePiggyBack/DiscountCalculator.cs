namespace TddAntipatterns.TheFreeRidePiggyBack
{
    public class DiscountCalculator
    {
        public decimal CalculateDiscount(bool firstPurchase, int age)
        {
            if (firstPurchase)
                return 0.1M;
            else if (age > 60)
                return 0.2M;

            return 0;
        }
    }
}