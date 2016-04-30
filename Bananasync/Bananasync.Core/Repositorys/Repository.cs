using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Bananasync.Core.Models;
using System.Data.SQLite;
using System.Reflection;
using Dapper;
using DapperExtensions;

namespace Bananasync.Core.Repositorys
{
    public class Repository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly SQLiteConnection _connection;

        public Repository()
        {
        }

        public T FindById(int id)
        {
            return _connection.Get<T>(id);
        }

        public IEnumerable<T> List()
        {
            return _connection.GetList<T>();
        }

        public IEnumerable<T> List(Func<T, bool> predicate)
        {
            return _connection.GetList<T>(predicate);
        }

        public bool Add(T entity)
        {
            return _connection.Insert(entity);
        }

        public bool Delete(T entity)
        {
            return _connection.Delete(entity);
        }

        public bool Update(T entity)
        {
            // Casting because of naming conflicts between SQLite and DapperExtensions
            return (_connection as IDbConnection).Update(entity);
        }

        public int GetCount(Func<T, bool> predicate)
        {
            return _connection.Count<T>(predicate);
        }
    }
}
