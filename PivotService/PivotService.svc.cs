
using AutoMapper;
using PivotBusiness;
using PivotDomain.DataPocos;
using PivotDomain.ServicePocos;
using System;

namespace PivotService
{
    public partial class PivotService : IPivotService
    {
     
        protected readonly IUserBusiness userBusiness;
        protected readonly IEventBusiness eventBusiness;
        public PivotService(
            IUserBusiness userBusiness,
            IEventBusiness eventBusiness)
        {
            this.userBusiness = userBusiness;
            this.eventBusiness = eventBusiness;
            SetAutoMapperMappings();
        }


        #region Private methods
        private static void SetAutoMapperMappings()
        {
            Mapper.CreateMap<ServiceEvent, Event>();
            Mapper.CreateMap<Event, ServiceEvent>();

            Mapper.CreateMap<ServiceUser, User>();
            Mapper.CreateMap<User, ServiceUser>();
        }
        #endregion
    }
}
