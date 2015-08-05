
using System;
using System.Collections.Generic;
using Core.Utilities;
using PivotDomain.DataPocos;
using PivotData.Repository;
using PivotData.DataModel;
using System.Linq;

namespace PivotBusiness
{
    public class EventBusiness : IEventBusiness
    {
        IEventRepository<PivotEntities> eventRepository  = null;
        public EventBusiness(IEventRepository<PivotEntities> eventRepository)
        {
            this.eventRepository = eventRepository;
        }

        public Event GetEventById(int id)
        {
            return eventRepository.GetBEventById(id);
        }

        public List<Event> GetEvents()
        {
            return eventRepository.GetEvents().ToList();
        }
    }
}
