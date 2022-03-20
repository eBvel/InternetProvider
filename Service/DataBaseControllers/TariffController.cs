using Model;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Service.DataBaseControllers
{
    public class TariffController : IEntityController<Tariff>
    {
        public async Task<Context> Add(Tariff entity, Context context)
        {
            await context.Tariffs.LoadAsync();
            context.Tariffs.Add(entity);

            return context;
        }

        public Context Edit(Tariff entity, Context context)
        {
            context.Entry(entity).State = EntityState.Modified;
            return context;
        }

        public async Task<List<Tariff>> GetListAsync(Context context)
        {
            await context.Tariffs.LoadAsync();
            var list = await context.Tariffs.ToListAsync();
            return list;
        }

        public async Task<Context> Remove(string id, Context context)
        {
            await context.Tariffs.LoadAsync();
            await context.Clients.LoadAsync();

            var tariff = await context.Tariffs.FindAsync(Convert.ToInt32(id));

            var clients = context.Clients.Local.Where(c => c.Tariff == tariff).ToList();
            var defTariff = await context.Tariffs.FirstOrDefaultAsync();
            clients.ForEach(c => c.SetTariff(defTariff));

            context.Tariffs.Remove(tariff);

            return context;
        }

        public async Task<Tariff> GetTariffByName(string name, Context context)
        {
            await context.Tariffs.LoadAsync();
            return await context.Tariffs.FirstOrDefaultAsync(t => t.Name.Equals(name));
        }

        public async Task<Tariff> GetEntityById(int id, Context context)
        {
            await context.Tariffs.LoadAsync();
            return await context.Tariffs.FindAsync(id);
        }

        public async Task<Tariff> GetEntityByName(string name, Context context)
        {
            await context.Tariffs.LoadAsync();
            return await context.Tariffs.FirstOrDefaultAsync(t => t.Name.Equals(name));
        }

        public List<Tariff> GetList(Context context)
        {
            throw new NotImplementedException();
        }
    }
}
