using PivotDomain.DataPocos;
using System;
using System.Collections.Generic;
namespace PivotBusiness
{
    public interface IEventBusiness
    {
        List<Event> GetEvents();
        Event GetEventById(int id);
    }
}
