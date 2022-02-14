using Model.Entites;
using Service.DataBaseControllers;
using Service.UI;

namespace Service.TariffService
{
    public class TariffEditing
    {
        private ITariffUI _ui;
        public TariffEditing(ITariffUI ui) => _ui = ui;

        public void Add()
        {
            var db = new DataBase();
            db.Add
                (
                    new TariffBuilder(_ui.TariffName, _ui.Price, _ui.Traffic, _ui.Speed).Build(),
                    new TariffController()
                );
        }

        public void Edit(Tariff tariff)
        {
            var db = new DataBase();

            tariff.SetMonthlyTraffic(_ui.Traffic);
            tariff.SetPrice(_ui.Price);
            tariff.SetSpeedLimit(_ui.Speed);

            db.Edit(tariff, new TariffController());
        }
    }
}
