using OrderProcessingApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApplication.Classes
{
    public class ComissionPayment :IPayment
    {

        private PaymentTypeEnum paymentType;

        public PaymentTypeEnum PaymentType
        {
            get { return paymentType; }
            set { paymentType = PaymentTypeEnum.Comission; }
        }
    }
}
