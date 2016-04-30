using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Bananasync.Core.Models;

namespace Bananasync.Core.Repositorys
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        T FindById(int id);
        IEnumerable<T> List();
        IEnumerable<T> List(Func<T, bool> predicate);

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
