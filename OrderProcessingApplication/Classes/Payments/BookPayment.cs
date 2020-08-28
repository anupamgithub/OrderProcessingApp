using OrderProcessingApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApplication.Classes
{
    public class BookPayment :IProduct
    {
       

        private PaymentTypeEnum paymentType;

        public PaymentTypeEnum PaymentType
        {
            get { return paymentType; }
            set { paymentType = PaymentTypeEnum.Book; }
        }

        public ISlip GenerateSlip()
        {
            //do some logic 
            return new RoyaltySlip(); 
        }
        public IPayment GenerateCommision()
        {
         return new ComissionPayment();
        
        }



    }
}
