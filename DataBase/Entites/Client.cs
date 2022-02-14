using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entites
{
    public class Client : User
    {
        [Required]
        public Address Address { get; private set; }
        public string GetFullAddress => $"{Address.City}, {Address.Street}, {Address.House} - {Address.Flat}";

        [Required]
        public int TariffId { get; private set; }
        [Required]
        [ForeignKey(nameof(TariffId))]
        public Tariff Tariff { get; private set; }

        [Required]
        public decimal Balance { get; private set; } = 0;
        public double CurrentTraffic { get; private set; } = 0;

        public List<ReportMonth> ReportMonths { get; private set; }

        public DateTime TariffActivationDate { get; private set; }
        public DateTime? LastPaymentDate { get; private set; }

        public bool AutoAdditionTraffic { get; private set; } = false;

        public Client() { }

        public Client(string firstName, string secondName, string middleName, string phone = "")
            : base(firstName, secondName, middleName, phone)
            => this.ReportMonths = new List<ReportMonth>();

        public override string ToString() => FullName;

        public bool SetTariff(Tariff tariff)
        {
            if (Balance >= tariff.MonthlyPrice)
            {
                Tariff = tariff;
                TariffId = tariff.Id;
                TariffActivationDate = DateTime.Today.Date;
                LastPaymentDate = null;

                return true;
            }
            return false;
        }

        public void SetAddress(string city, string street, string house, int flat) => Address = new Address(city, street, house, flat);

        public bool PayForMonth()
        {
            if (Balance < Tariff.MonthlyPrice) throw new ArgumentException("На счете не достаточно средств.", nameof(Balance));
            if (LastPaymentDate?.Month == DateTime.Today.Month) return false;

            Balance -= Tariff.MonthlyPrice;
            LastPaymentDate = DateTime.Today.Date;
            UpdateTraffic();
            return true;
        }

        public bool AdditionPay()
        {
            if (!AutoAdditionTraffic) return false;
            if (Balance < Tariff.MonthlyPrice / 3) throw new ArgumentException("На счете не достаточно средств.", nameof(Balance));

            Balance -= Tariff.MonthlyPrice / 3;
            AddTraffic();
            return true;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0) throw new ArgumentException("Внесенная сумма не может быть отрицательной.", nameof(amount));
            Balance += amount;
        }

        public void TrafficChange(double traffic)
        {
            if (traffic <= 0) throw new ArgumentException("Трафик не может быть отрицательным.", nameof(traffic));
            CurrentTraffic -= (traffic / 1024);   //Переводим в Гб.
        }

        public void TurnOnAdditionPay(bool value) => AutoAdditionTraffic = value;

        private void UpdateTraffic() => CurrentTraffic = Tariff.MonthlyTraffic;

        public void AddTraffic() => CurrentTraffic = Tariff.MonthlyTraffic / 4;
    }
}
