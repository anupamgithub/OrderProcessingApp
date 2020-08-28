
using OrderProcessingApplication.Classes.Email;
using OrderProcessingApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApplication.Classes
{
    public class MembershipPayment : IPayment
    {

        public enum MembershipTypeEnum
        {
            Upgrade,
            Activate
           
        }
        private PaymentTypeEnum paymentType;

        public MembershipTypeEnum MembershipType;

        public PaymentTypeEnum PaymentType
        {
            get { return paymentType; }
            set { paymentType = PaymentTypeEnum.Membership; }
        }

        public MembershipPayment(MembershipTypeEnum membershipType)
        {
            MembershipType = membershipType;
           


        }
        public bool ProcessMemberShip(Customer customer)
        {
            if (customer.MembershipType == MembershipTypeEnum.Activate)
            {
                ActivateMembership();

            }
            else
            {

                UpgradeMembership();
            }
            EmailModule.SendEmail(customer);
            
            //do some process
            return true;
        
        }

        private bool UpgradeMembership()
        {

            //do some process
            return true;
        }

        private bool ActivateMembership()
        {

            //do some process
            return true;
        }

    }
}
