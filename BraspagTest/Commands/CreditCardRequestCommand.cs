using BraspagTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BraspagTest.Commands
{
    public class CreditCardRequestCommand
    {
        public CreditCardRequestCommand(string merchantOrderId, Customer customer, Payment payment)
        {
            MerchantOrderId = merchantOrderId;
            Customer = customer;
            Payment = payment;
        }

        public string MerchantOrderId { get; set; }

        public Customer Customer { get; set; }

        public Payment Payment { get; set; }
    }
}
