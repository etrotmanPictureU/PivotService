
using Core.Data.DbContext;
using Core.Data.DbContext.Orm;

using Core.IoC;
using System.Data.Entity;

namespace PivotService.WCF
{
    public class PivotContextRegistration<TContext> : IContextRegistration<TContext> where TContext : DbContext
    {
        public void RegisterContext()
        {
            UnityIoCFactory.Instance.RegisterType(typeof(IUnitOfWork<TContext>), typeof(UnitOfWork<TContext>));
            UnityIoCFactory.Instance.RegisterType(typeof(IDatabaseFactory<TContext>), typeof(DatabaseFactory<TContext>));
        }
    }
}