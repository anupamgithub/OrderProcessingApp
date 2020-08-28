namespace OrderProcessingApplication.Interfaces
{
    public interface ISlip
    {
        PackingSlipTypeEnum PackingSlipType { set; }

    }

    public enum PackingSlipTypeEnum
    {
        Shipping,
        RoyaltyDepartment,
        Video,      

    }



}