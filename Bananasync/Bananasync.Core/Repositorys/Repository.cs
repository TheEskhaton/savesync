using System;
using System.Collections.Generic;
using System.Linq;
using Bananasync.Core.Models;
using System.Data.SQLite;
using System.Reflection;
using Dapper;
using Bananasync.Core.Misc;

namespace Bananasync.Core.Repositorys
{
    public class Repository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly SQLiteConnection _connection;
        private readonly string _tablename;

        public Repository()
        {
            try
            {
                var table = typeof(T).GetCustomAttributes().ToList().FirstOrDefault(x => x.GetType() == typeof(Table)) as Table;

                if (table !=null)
                    _tablename = table.Tablename;
            }
            catch (NullReferenceException)
            {
                throw new CustomAttributeFormatException("");
            }
        }

        public T FindById(int id)
        {
            return _connection.Query<T>($"SELECT * FROM {_tablename}").First();
        }

        public IEnumerable<T> List()
        {
            return _connection.Query<T>($"SELECT * FROM {_tablename}");
        }

        public IEnumerable<T> List(Func<T, bool> predicate)
        {
            return List().Where(predicate);
        }

        public void Add(T entity)
        {
            _connection.I
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
