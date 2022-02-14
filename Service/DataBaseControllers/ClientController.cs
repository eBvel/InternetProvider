using Model;
using System;
using Model.Entites;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Linq;

namespace Service.DataBaseControllers
{
    public class ClientController : IEntityController<Client>
    {
        public async Task<Context> Add(Client entity, Context context)
        {
            await context.Tariffs.LoadAsync();

            await ConnectTariff(entity, context);
            context.Clients.Add(entity);

            return context;
        }

        public async Task<Context> Edit(Client entity, Context context)
        {
            context.Entry(entity).State = EntityState.Modified;
            return context;
        }

        public async Task<Context> Remove(string id, Context context)
        {
            await context.Clients.LoadAsync();
            await context.Tariffs.LoadAsync();

            var client = await context.Clients.FindAsync(id);
            context.Clients.Remove(client);

            return context;
        }

        public async Task<List<Client>> GetListAsync(Context context)
        {
            await context.Clients.LoadAsync();
            await context.Tariffs.LoadAsync();

            return await context.Clients.ToListAsync();
        }

        public Task<Client> GetEntityById(int id, Context context)
        {
            throw new NotImplementedException(nameof(GetEntityById));
        }

        public async Task<Client> GetEntityByName(string name, Context context)
        {
            await context.Clients.LoadAsync();
            await context.Tariffs.LoadAsync();
            return await context.Clients.FindAsync(name);
        }

        public bool IsClient(User user) => user is Client;

        public async Task<Context> ConnectTariff(Client client, Context context, int tariffId = 1)
        {
            var tariff = await context.Tariffs.FindAsync(tariffId);
            client.SetTariff(tariff);

            return context;
        }

        public List<Client> GetList(Context context)
        {
            context.Clients.LoadAsync();
            context.Tariffs.LoadAsync();

            return context.Clients.ToList();
        }
    }
}
