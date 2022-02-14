using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Entites
{
    public class Tariff
    {
        [Key]
        public int Id { get; set; }

        [Required] [MaxLength(30)]
        public string Name { get; private set; }
        [Required]
        public decimal MonthlyPrice { get; private set; }
        [Required]
        public double MonthlyTraffic { get; private set; }
        [Required]
        public double SpeedLimit { get; private set; }

        public string Price => $"{MonthlyPrice} руб.";
        public string Speed => $"{SpeedLimit} Мбит/с";
        public string Traffic => $"{MonthlyTraffic} Гб";

        public override string ToString()
        {
            return Name;
        }

        public Tariff() { }

        public Tariff(string name, decimal monthlyPrice, double monthlyTraffic, double speedLimit)
        {
            Name = name;
            SetPrice(monthlyPrice);
            SetMonthlyTraffic(monthlyTraffic);
            SetSpeedLimit(speedLimit);
        }

        public void SetPrice(decimal monthlyPrice)
        {
            if (monthlyPrice < 0) throw new ArgumentException("Стоимость тарифа должна быть больше нуля.", nameof(monthlyPrice));
            MonthlyPrice = monthlyPrice;
        }

        public void SetMonthlyTraffic(double monthlyTraffic)
        {
            if (monthlyTraffic < 0 || monthlyTraffic > 1000) throw new ArgumentException("Трафик тарифа должен быть больше нуля и меньше тысячи.", nameof(monthlyTraffic));
            MonthlyTraffic = monthlyTraffic;
        }

        public void SetSpeedLimit(double speedLimit)
        {
            if (speedLimit < 0 || speedLimit > 500) throw new ArgumentException("Скорость тарифа должна быть больше нуля.", nameof(speedLimit));
            SpeedLimit = speedLimit;
        }
    }
}
