using Model.Entites;
using Service.DataBaseControllers;
using System;

namespace Service.ClientService
{

    public class MonthlyPayment : IPayment
    {
        public MonthlyPayment() {}

        public void Pay()
        {
            //TODO: Report month add to DB HOW???
            if (ActiveClient.Instance.PayForMonth())
                new DataBase().Add(
                    new ReportMonth(ActiveClient.Instance, ActiveClient.Instance.Tariff.Name, DateTime.Today.Date), 
                    new ReportMonthController());
        }
    }
}
