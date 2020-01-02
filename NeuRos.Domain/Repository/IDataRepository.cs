using System;
using System.Collections.Generic;
using System.Text;

namespace NeuRos.Domain.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(DateTime Date);
        TEntity Get(DateTime id);
        TEntity Get(string id, int number);
        void Add(TEntity entity);
        void Add(List<TEntity> entities);
        void Update(int id, TEntity entity);
        void UpdateAttendance(DateTime date,int Id);
        void Delete(TEntity entity);
    }
}
