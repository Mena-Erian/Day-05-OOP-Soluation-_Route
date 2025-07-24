using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed
{
    internal class PaymentProcessor
    {
        public virtual void ProccessPayment(decimal Amount)
        {
            Console.WriteLine($"Amount = {Amount - 10}");
        }
    }
    sealed internal class PaymentProcessor02 : PaymentProcessor
    {
        public override void ProccessPayment(decimal Amount)
        {
            Console.WriteLine($"Amount = {Amount}");
        }
    }
    internal class MyPaymentProcessor 
    {
        public  void ProccessPayment(decimal Amount)
        {
            Console.WriteLine($"Amount = {Amount + 20}");
        }
    }
    // benifit of Sealed class => 
    //      it will give positive effecete to CLR that now CLR not Should Check for inhertens of this
    //      class or thay are ovrride or not , so its better pefomacne

}
