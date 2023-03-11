using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseOperations
{
    public interface ITable<TEntity, TKey> where TEntity : class
    {
        void create(TEntity entity);
        void update(TEntity entity);
        void delete(int id);
        List<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
