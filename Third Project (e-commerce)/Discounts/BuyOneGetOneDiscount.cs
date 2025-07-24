namespace Third_Project__e_commerce_.Discounts
{
    class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount()
        {
            Name = "BuyOneGetOneDiscount";
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity > 1) return (price / 2) * (quantity / 2);
            return 0;
        }
    }
}
