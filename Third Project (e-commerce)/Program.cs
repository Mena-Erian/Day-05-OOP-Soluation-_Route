using Assignment;
using Third_Project__e_commerce_.Discounts;
using Third_Project__e_commerce_.Product_Dtails;
using Third_Project__e_commerce_.Users;

namespace Third_Project__e_commerce_
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("-------------Hello Welcome in Ecommerce Platform :-)\n\n");
            Console.WriteLine("Users Types: \n1. Regular\n2. Premium\n3. Guest");
            User user;
            Discount discount;
            int number;
            do
            {
                number = Helper.GetIntFromUser("Please Enter the Number Of your Type:");
            }
            while (number < 1 || number > 3);
            UserTypes userTypes = (UserTypes)number;
            switch (userTypes)
            {
                case UserTypes.Regular:
                    user = new RegularUser();
                    break;
                case UserTypes.Premium:
                    user = new PremiumUser();
                    break;
                case UserTypes.Guest:
                    user = new GuestUser();
                    break;
                default:
                    user = new GuestUser();
                    break;
            }

            user.Name = Helper.GetStringFromUser("Name");

            Product product = new Product();
            product.Price = Helper.GetDecimalFromUser("Please Enter price:");
            product.Quantity = Helper.GetIntFromUser("Please Enter quantity:");
            decimal total = product.Price * product.Quantity;
            Console.WriteLine($"Total Before Discount : {total}");
            discount = user.GetDiscount();
            decimal discountAmount = discount.CalculateDiscount(product.Price, product.Quantity);
            Console.WriteLine($"Discount : {discountAmount}");
            Console.WriteLine($"Total After Discount = {total} -  {discountAmount} = {total - discountAmount}");
        }
    }
}
