using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;

using Core.Types;
using PivotData.DataModel;
using PivotDomain.DataPocos;
using Core.Data.DbContext;

namespace PivotData.Repository
{
    public class EventRepository<CONTEXT> : RepositoryBase<CONTEXT,Event>, IEventRepository<CONTEXT> where CONTEXT : PivotEntities
    {
        IDatabaseFactory<CONTEXT> databaseFactory = null;
        public EventRepository(IDatabaseFactory<CONTEXT> databaseFactory)
            : base(databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }


        public Event  GetBEventById(int id)
        {

            var query = (from eventObj in this.DataContext.Event
                         where eventObj.Id == id
                         select eventObj);

            return query.FirstOrDefault();
        }

        public IQueryable<Event> GetEvents()
        {
            return (from eventObj in this.DataContext.Event
                     
                         select eventObj);
        }
    }
}
