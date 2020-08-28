using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderProcessingApplication.Interfaces;
using OrderProcessingApplication.Classes;
using OrderProcessingApplication.Classes.Email;
using OrderProcessingApplication.Classes.Payments;

namespace UnitTestProject
{
    [TestClass]
    public class OrderProcessingTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Customer customer = new Customer();
            customer.MembershipType = MembershipPayment.MembershipTypeEnum.Activate;
            customer.VideoText = "Learning to ski";

            MembershipPayment membershipPayment = new MembershipPayment(MembershipPayment.MembershipTypeEnum.Activate);

            BookPayment bookPayment = new BookPayment();
            VideoPAyment videoPayment = new VideoPAyment();
            PhysicalProductPaymentcs physicalProductPaymentcs = new PhysicalProductPaymentcs();


            //Below code to test with varios payment types and assert
            ProcessOrder order = new ProcessOrder(bookPayment, customer);

        }
    }
}
