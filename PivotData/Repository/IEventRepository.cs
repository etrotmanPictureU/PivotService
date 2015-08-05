using PivotDomain.DataPocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivotData.Repository
{
    public interface IEventRepository <PivotEntities>
    {
        Event GetBEventById(int id);
        IQueryable<Event> GetEvents();
    }
}
