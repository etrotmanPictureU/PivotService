using Core.Data.DbContext;
using PivotData.DataModel;
using PivotDomain.DataPocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivotData.Repository
{
    public class IoCRepository<CONTEXT> : RepositoryBase<CONTEXT, Event>, IIoCRepository<CONTEXT> where CONTEXT : PivotEntities
    {
        IDatabaseFactory<CONTEXT> databaseFactory  = null;
        public IoCRepository(IDatabaseFactory<CONTEXT> databaseFactory)
            : base(databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }
        public void NOOP() { }
    }
}
