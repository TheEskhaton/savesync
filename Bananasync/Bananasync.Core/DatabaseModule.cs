using System.Data;
using System.Data.SQLite;
using Ninject.Modules;

namespace Bananasync.Core
{
    class DatabaseModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDbConnection>().To<SQLiteConnection>();
        }
    }
}
