using BraspagTest.Commands;
using BraspagTest.Services;
using System;

namespace BraspagTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BRASPAG TEST");

            var customer = MockFactory.GetCustomer();
            var payment = MockFactory.GetPayment();

            var command = new CreditCardRequestCommand("2017051002", customer, payment);

            var service = new BraspagService();


            Console.WriteLine("BRASPAG TEST");

            try
            {
                Console.WriteLine("RequestPaymentCreditCard.......");

                var result = service.RequestPaymentCreditCard(command).GetAwaiter().GetResult();

                Console.WriteLine("JSON RESULT: \n");

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            Console.ReadKey();
        }
    }
}
