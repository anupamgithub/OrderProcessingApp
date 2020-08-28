using OrderProcessingApplication.Classes.Email;
using OrderProcessingApplication.Classes.Payments;
using OrderProcessingApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApplication.Classes
{
    public class ProcessOrder
    {
       
        public  ProcessOrder(IPayment payment,Customer customer )
        {
            if (payment.GetType().ToString() == "OrderProcessingApplication.Classes.BookPayment")
            {
                ISlip slip = ((BookPayment)payment).GenerateSlip();
                IPayment commission = ((BookPayment)payment).GenerateCommision();

            }
            if (payment.GetType().ToString() == "OrderProcessingApplication.Classes.MembershipPayment")
            {
                bool isSuccess = ((MembershipPayment)payment).ProcessMemberShip(customer);

            }
            if (payment.GetType().ToString() == "OrderProcessingApplication.Classes.MembershipPayment")
            {
                bool isSuccess = ((MembershipPayment)payment).ProcessMemberShip(customer);

            }
            if (payment.GetType().ToString() == "OrderProcessingApplication.Classes.Video")
            {
                ISlip videoSlip = ((VideoPAyment)payment).GenerateSlip(customer.VideoText);

            }



        }
       

    }
}
