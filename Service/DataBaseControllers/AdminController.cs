using Model;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Service.DataBaseControllers
{
    public class AdminController : IEntityController<Admin>
    {
        public async Task<Context> Add(Admin entity, Context context)
        {
            context.Admins.Add(entity);
            return context;
        }

        public async Task<Context> Edit(Admin entity, Context context)
        {
            context.Entry(entity).State = EntityState.Modified;
            return context;
        }

        public Task<Admin> GetEntityById(int id, Context context)
        {
            throw new NotImplementedException();
        }

        public async Task<Admin> GetEntityByName(string name, Context context)
        {
            await context.Admins.LoadAsync();
            return await context.Admins.FindAsync(name);
        }

        public List<Admin> GetList(Context context)
        {
            context.Admins.Load();
            return context.Admins.ToList();
        }

        public async Task<List<Admin>> GetListAsync(Context context)
        {
            await context.Admins.LoadAsync();
            return await context.Admins.ToListAsync();
        }

        public async Task<Context> Remove(string id, Context context)
        {
            await context.Admins.LoadAsync();
            var admin = await context.Admins.FindAsync(id);
            context.Admins.Remove(admin);
            return context;
        }
    }
}
