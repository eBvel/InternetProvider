using Model.Entites;
using Service.DataBaseControllers;
using System;
using System.Linq;
using System.Threading;

namespace Service.ClientService
{
    public class ClientSession : ISession
    {
        public event Action<IPayment> PaidHandler;

        private Thread _workImitationThread;
        private double _usedTraffic;

        public ClientSession(User client)
        {
            new ActiveClient((Client)client);
            _usedTraffic = default(double);
        }

        public void Start()
        {
            if (ActiveClient.Instance.LastPaymentDate <= DateTime.Today.AddMonths(-1) || ActiveClient.Instance.LastPaymentDate is null)
                PaidHandler?.Invoke(new MonthlyPayment());

            _workImitationThread = new Thread(new ThreadStart(WorkImitation));
            _workImitationThread.Start();
        }

        public void Stop()
        {
            _workImitationThread.Abort();

            var rm = new DataBase().GetList(new ReportMonthController()).Where(r => r.Client.Login == ActiveClient.Instance.Login).LastOrDefault();
            rm.TrafficDataUpdate(_usedTraffic);
            new DataBase().Edit(rm, new ReportMonthController());
            new DataBase().Edit(ActiveClient.Instance, new ClientController());

            _usedTraffic = 0;
        }

        private void WorkImitation()
        {
            var trafficForSecond = ActiveClient.Instance.Tariff.SpeedLimit / 16; //Траты трафика за секунду со средней скоростью.

            while (true)
            {
                if (ActiveClient.Instance.CurrentTraffic >= trafficForSecond && trafficForSecond != 0)
                {
                    ActiveClient.Instance.TrafficChange(trafficForSecond);
                    _usedTraffic += trafficForSecond;
                    Thread.Sleep(1000);
                }
                else
                {
                    PaidHandler?.Invoke(new AdditionPayment());
                }
            }
        }
    }
}
