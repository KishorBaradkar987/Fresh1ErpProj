using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseOperations
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void ExecuteCommand(string spname, object[] parameters);
        List<TEntity> ExecuteQuery(string spname, object[] parameters);
    }
}
