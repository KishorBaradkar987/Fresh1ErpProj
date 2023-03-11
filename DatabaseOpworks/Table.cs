using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DatabaseOpworks
{
    public class Table<TEntity> : ITable<TEntity> where TEntity : class
    {
        ERP_ProjectDBEntities db;
        public Table(ERP_ProjectDBEntities db)
        {
            this.db = db;
        }

        public void create(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
            db.SaveChanges();
        }

        public void delete(int id)
        {
            TEntity Entity = db.Set<TEntity>().Find(id);
            db.Set<TEntity>().Remove(Entity);
            db.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            TEntity Entity = db.Set<TEntity>().Find(id);
            return Entity;
        }

        public void update(TEntity entity)
        {
            db.Entry<TEntity>(entity).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
