
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PivotService.Responses;
using PivotBusiness;
using PivotDomain.DataPocos;
using AutoMapper;
using PivotDomain.ServicePocos;

namespace PivotService
{
    public partial class PivotService : IPivotService
    {
        public EventResponse GetEventById(int id)
        {
            Event obj = eventBusiness.GetEventById(id);
            ServiceEvent sp = null;
            sp = Mapper.Map(obj, sp);
            return new EventResponse() { Result = sp };
        }

        public EventResponse GetEvents()
        {
           List<Event> obj = eventBusiness.GetEvents();
            List < ServiceEvent> sp = null;
            sp = Mapper.Map(obj, sp);
            return new EventResponse() { Results = sp };
        }
    }
}
