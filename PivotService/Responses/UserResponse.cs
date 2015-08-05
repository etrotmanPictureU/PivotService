using PivotDomain.ServicePocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PivotService.Responses
{
    public class UserResponse
    {
        [DataMember]
        public List<ServiceUser> Results { get; set; }

        [DataMember]
        public ServiceUser Result { get; set; }

        [DataMember]
        public int TotalRecords { get; set; }
    }
}
