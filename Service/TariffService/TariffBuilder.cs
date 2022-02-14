using Model.Entites;

namespace Service.TariffService
{
    public class TariffBuilder
    {
        private Tariff _tariff;

        public TariffBuilder(string name, decimal monthlyPrice, double monthlyTraffic, double speedLimit) 
            => _tariff = new Tariff(name, monthlyPrice, monthlyTraffic, speedLimit);

        public Tariff Build() => _tariff;
    }
}
