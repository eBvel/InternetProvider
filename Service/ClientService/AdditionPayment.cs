namespace Service.ClientService
{
    public class AdditionPayment : IPayment
    {
        public AdditionPayment(){}

        public void Pay()
        {
            if (ActiveClient.Instance.AdditionPay()) ;
                //TODO:
        }
    }
}
