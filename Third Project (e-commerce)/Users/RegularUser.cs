using Third_Project__e_commerce_.Discounts;

namespace Third_Project__e_commerce_.Users
{
    class RegularUser : User
    {
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }

}
