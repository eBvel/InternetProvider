using Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.DataBaseControllers
{
    public interface IEntityController<T>
    {
        Task<Context> Add(T entity, Context context);
        Task<Context> Edit(T entity, Context context);
        Task<Context> Remove(string id, Context context);
        Task<List<T>> GetListAsync(Context context);
        List<T> GetList(Context context);
        Task<T> GetEntityById(int id, Context context);
        Task<T> GetEntityByName(string name, Context context);
    }
}
