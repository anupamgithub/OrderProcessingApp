namespace OrderProcessingApplication.Interfaces
{
    public interface IPayment
    {
        PaymentTypeEnum PaymentType { set; }
     
    }

    public enum PaymentTypeEnum
    {
        Membership,
        Book,
        PhysicalProduct,
        Video,
        Comission

    }

}