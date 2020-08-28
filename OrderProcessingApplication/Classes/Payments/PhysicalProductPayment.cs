using OrderProcessingApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApplication.Classes
{
    public class PhysicalProductPaymentcs : IProduct
    {
        private PaymentTypeEnum paymentType;

        public PaymentTypeEnum PaymentType
        {
            get { return paymentType; }
            set { paymentType = PaymentTypeEnum.PhysicalProduct; }
        }

        public ISlip GenerateSlip()
        {
            return new ShippingSlip();
        }
        public IPayment GenerateCommision()
        {
            return new ComissionPayment();

        }

    }
}
