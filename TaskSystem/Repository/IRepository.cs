using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskSystem.Repository
{
    public interface IRepository<T>
    {
        IQueryable<T> All(Func<T, bool> func = null);
        T Find(int id);
        void InsertOrUpdate(T t);
        void Delete(int id);
        void Save();
    }
}
