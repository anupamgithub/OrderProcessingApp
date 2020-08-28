using OrderProcessingApplication.Interfaces;

namespace OrderProcessingApplication.Classes
{
    public class RoyaltySlip : ISlip
    {
        private PackingSlipTypeEnum packingSlipType;

        public PackingSlipTypeEnum PackingSlipType
        {
            get { return packingSlipType; }
            set { packingSlipType = PackingSlipTypeEnum.RoyaltyDepartment; }
        }

    }
}