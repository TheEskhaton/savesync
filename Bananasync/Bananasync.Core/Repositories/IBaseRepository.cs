using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Bananasync.Core.Models;

namespace Bananasync.Core.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        T FindById(int id);
        IEnumerable<T> List();
        IEnumerable<T> List(Func<T, bool> predicate);

        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        int GetCount(Func<T, bool> predicate);
    }
}
