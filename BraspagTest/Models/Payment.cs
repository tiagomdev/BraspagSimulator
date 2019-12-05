using System;
using System.Collections.Generic;
using System.Text;

namespace BraspagTest.Models
{
    public class Payment
    {
        public string Provider { get; set; }

        public string Type { get; set; }

        public double Amount { get; set; }

        public string Currency { get; set; }

        public string Country { get; set; }

        public int Installments { get; set; }

        public string Interest { get; set; }

        public bool Capture { get; set; }

        public bool Authenticate { get; set; }

        public bool Recurrent { get; set; }

        public string SoftDescriptor { get; set; }

        public bool DoSplit { get; set; }

        public CreditCard CreditCard { get; set; }

        public Credentials Credentials { get; set; }

        public IList<ExtraData> ExtraDataCollection { get; set; }
    }
}
