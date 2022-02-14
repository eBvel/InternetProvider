namespace Model.Entites
{
    public class UnknownTariff : Tariff
    {
        public UnknownTariff() : base("По умолчанию", default(decimal), default(double), default(double)) { }//Id = 1; }
    }
}
