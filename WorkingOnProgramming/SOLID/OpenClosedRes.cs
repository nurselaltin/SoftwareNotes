using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingOnProgramming.SOLID
{
    //Tanım : Kodun değiştirilmeden geliştirilmeye açık olmasıdır
    //Uymayan Kısım
    public class PaymentProcessor
    {
        public void ProcessPayment(string paymentType)
        {
            if(paymentType == "CreditCard")
            {
                Console.WriteLine("Processing credit card payment...");
            }
            else if(paymentType == "PayPal")
            {
                Console.WriteLine("Processing Paypal payment...");
            }
        }
    }

    //Uyan Kısım
    public interface IPaymentProcessor
    {
        void ProcessPayment();
    }
    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment...");
        }
    }

    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing Paypal payment...");
        }
    }

    //--------------------------------------------------
    public class MainClass
    {
        public void Print()
        {
            var processor1 = new PaymentProcessor();
            processor1.ProcessPayment("CreditCard");
            processor1.ProcessPayment("PayPal");

            IPaymentProcessor processor2 = new CreditCardProcessor();
            processor2.ProcessPayment();

            IPaymentProcessor processor3 = new PayPalProcessor();
            processor3.ProcessPayment();
        }
    }
}
