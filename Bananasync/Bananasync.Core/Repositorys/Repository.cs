using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Bananasync.Core.Models;
using System.Data.SQLite;
using Dapper;

namespace Bananasync.Core.Repositorys
{
    public class Repository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly SQLiteConnection _connection;
        public T FindById(int id)
        {
            return _connection.Query<T>()
        }

        public IEnumerable<T> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
