using System;
using System.Collections.Generic;
using System.Text;
using static OrderProcessingApplication.Classes.MembershipPayment;

namespace OrderProcessingApplication.Classes.Email
{
   public class Customer
    {

        public int FirstName { get; set; }
        public int MiddleName { get; set; }
        public int LastName { get; set; }
        public int Email { get; set; }

        public string VideoText { get; set; }

        public MembershipTypeEnum MembershipType { get; set; }


    }
}
