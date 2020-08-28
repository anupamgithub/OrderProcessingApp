using OrderProcessingApplication.Classes;
using OrderProcessingApplication.Classes.Email;
using OrderProcessingApplication.Classes.Payments;
using System;

namespace OrderProcessingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.MembershipType = MembershipPayment.MembershipTypeEnum.Activate;
            customer.VideoText = "Learning to ski";

            MembershipPayment membershipPayment = new MembershipPayment(MembershipPayment.MembershipTypeEnum.Activate);
                     
            BookPayment bookPayment = new BookPayment();
            VideoPAyment videoPayment = new VideoPAyment();
            PhysicalProductPaymentcs physicalProductPaymentcs = new PhysicalProductPaymentcs();
          

            //Below code to test with varios payment types
            ProcessOrder order = new ProcessOrder(bookPayment,customer);


        }
    }
}
