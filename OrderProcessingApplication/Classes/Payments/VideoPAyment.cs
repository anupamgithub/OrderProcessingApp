using OrderProcessingApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApplication.Classes.Payments
{
    public class VideoPAyment:IPayment
    {
        public int VideoText { get; set; }

        private PaymentTypeEnum paymentType;

        public PaymentTypeEnum PaymentType
        {
            get { return paymentType; }
            set { paymentType = PaymentTypeEnum.Video; }
        }

        public ISlip GenerateSlip(string videoText)
        {
            //do some logic 
            return new VideoSlip(videoText); ;
        }
    }
}
