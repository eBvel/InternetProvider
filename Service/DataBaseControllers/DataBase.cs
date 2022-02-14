using Model;
using Model.Entites;
using Service.ClientService.Auth;
using Service.UI;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Service.DataBaseControllers
{
    public class DataBase
    {
        public async void Add<T>(T entity, IEntityController<T> operation)
        {
            using (var context = new Context())
            {
                await (await operation.Add(entity, context)).SaveChangesAsync();
            }
        }

        public async void Edit<T>(T entity, IEntityController<T> operation)
        {
            using (var context = new Context())
            {
                await (await operation.Edit(entity, context)).SaveChangesAsync();
            }
        }

        public async void Remove<T>(string id, IEntityController<T> operation)
        {
            using (var context = new Context())
            {
                await (await operation.Remove(id, context)).SaveChangesAsync();
            }
        }

        public List<T> GetList<T>(IEntityController<T> operation)
        {
            using (var context = new Context())
            {
                return operation.GetList(context);
            }
        }

        public async Task<List<T>> GetListAsync<T>(IEntityController<T> operation)
        {
            using (var context = new Context())
            {
                return await operation.GetListAsync(context);
            }
        }

        public async Task<T> GetEntityById<T>(int id, IEntityController<T> operation)
        {
            using (var context = new Context())
            {
                return await operation.GetEntityById(id, context);
            }
        }

        public async Task<T> GetEntityByName<T>(string name, IEntityController<T> operation)
        {
            using (var context = new Context())
            {
                return await operation.GetEntityByName(name, context);
            }
        }

        public async Task<User> Authorization(IAuthorizationUI ui)
        {
            using (var context = new Context())
            {
                await context.Clients.LoadAsync();
                await context.Tariffs.LoadAsync();

                var auth = new Authorization(context);
                return auth.Authorize(ui.Login, ui.Password);
            }
        }

        public async void ConnectTariff(string clientId, int tariffId)
        {
            using (var context = new Context())
            {
                await context.Clients.LoadAsync();
                await context.Tariffs.LoadAsync();
                var client = await context.Clients.FindAsync(clientId);
                await (await new ClientController().ConnectTariff(client, context, tariffId)).SaveChangesAsync();
            }
        }
    }
}
