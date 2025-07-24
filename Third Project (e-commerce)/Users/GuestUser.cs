using Third_Project__e_commerce_.Discounts;

namespace Third_Project__e_commerce_.Users
{
    class GuestUser : User
    {
        public override Discount GetDiscount()
        {
            return new FloatDiscount(0);
        }
    }
}
