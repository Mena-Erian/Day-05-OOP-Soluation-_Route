namespace Third_Project__e_commerce_.Discounts
{
    class FloatDiscount : Discount
    {
        private decimal fixedAmount;
        public FloatDiscount(decimal fixedAmount)
        {
            Name = "FloatDiscount";
            this.fixedAmount = fixedAmount;
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return fixedAmount * Math.Min(quantity, 1);
        }
    }

}
