using OrderProcessingApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessingApplication.Classes
{
    public class ShippingSlip : ISlip
    {
        private PackingSlipTypeEnum packingSlipType;

        public PackingSlipTypeEnum PackingSlipType
        {
            get { return packingSlipType; }
            set { packingSlipType = PackingSlipTypeEnum.Shipping; }
        }

    }
}
