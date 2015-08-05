using PivotDomain.ServicePocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PivotService.Responses
{
    public class EventResponse
    {
        [DataMember]
        public List<ServiceEvent> Results { get; set; }

        [DataMember]
        public ServiceEvent Result { get; set; }

        [DataMember]
        public int TotalRecords { get; set; }
    }
}
