using OrderProcessingApplication.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApplication.Interfaces
{
    interface IProduct : IPayment
    {
        public ISlip GenerateSlip();
        public IPayment GenerateCommision();
    }
}
