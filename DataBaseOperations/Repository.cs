using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseOperations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        ERP_ProjectDBEntities db;
        public Repository(ERP_ProjectDBEntities db)
        {
            this.db = db;
        }

        public void ExecuteCommand(string spname, object[] parameters)
        {
            db.Database.ExecuteSqlCommand(spname, parameters);
        }

        public List<TEntity> ExecuteQuery(string spname, object[] parameters)
        {
            return db.Database.SqlQuery<TEntity>(spname, parameters).ToList();
        }
    }
}
