using Model;
using Model.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Service.DataBaseControllers
{
    public class ReportMonthController : IEntityController<ReportMonth>
    {
        public async Task<Context> Add(ReportMonth entity, Context context)
        {
            context.Entry(entity.Client).State = EntityState.Modified;
            context.ReportMonths.Add(entity);
            return context;
        }

        public Context Edit(ReportMonth entity, Context context)
        {
            context.Entry(entity).State = EntityState.Modified;
            return context;
        }

        public async Task<ReportMonth> GetEntityById(int id, Context context)
        {
            await context.ReportMonths.LoadAsync();
            return await context.ReportMonths.FindAsync(id);
        }

        public Task<ReportMonth> GetEntityByName(string name, Context context)
        {
            throw new NotImplementedException();
        }

        public List<ReportMonth> GetList(Context context)
        {
            context.Clients.Load();
            context.Tariffs.Load();
            context.ReportMonths.Load();

            return context.ReportMonths.ToList();
        }

        public async Task<List<ReportMonth>> GetListAsync(Context context)
        {
            await context.Clients.LoadAsync();
            await context.Tariffs.LoadAsync();
            await context.ReportMonths.LoadAsync();

            return await context.ReportMonths.ToListAsync();
        }

        public async Task<Context> Remove(string id, Context context)
        {
            await context.ReportMonths.LoadAsync();
            var rm = await context.ReportMonths.FindAsync(id);
            context.ReportMonths.Remove(rm);
            return context;
        }
    }
}
