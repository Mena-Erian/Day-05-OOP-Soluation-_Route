namespace Third_Project__e_commerce_.Discount
{
    class PercentageDiscount : Discount
    {
        private decimal discountByPercentage;
        public PercentageDiscount(decimal discountByPercentage)
        {
            Name = "PercentageDiscount";
            this.discountByPercentage = discountByPercentage;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (discountByPercentage / 100);
        }
    }
}
