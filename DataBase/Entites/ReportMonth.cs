using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entites
{
    public class ReportMonth
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        public string ClientLogin { get; private set; }
        [Required] [ForeignKey(nameof(ClientLogin))]
        public virtual Client Client { get; private set; }

        [Required]
        public string TariffName { get; private set; }

        [Required]
        public DateTime StartDate { get; private set; }
        [Required]
        public double UsedTraffic { get; private set; }

        public ReportMonth(){}

        public ReportMonth(Client client, string tariffName ,DateTime dateState)
        {
            Client = client;
            TariffName = tariffName;
            StartDate = dateState.Date;
            UsedTraffic = default(double);
        }

        public void TrafficDataUpdate(double traffic)
        {
            if (traffic < 0) throw new ArgumentException("Значение трафика не может быть отрицательным." ,nameof(traffic));
            UsedTraffic += traffic;
        }

        public void SetClient(Client client)
        {
            Client = client;
        }
    }
}
