using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PivotService
{
    [DataContract]
    public class ServiceOperationFault
    {
        [DataMember]
        public String Reason { get; set; }

        [DataMember]
        public String Code { get; set; }

        [DataMember]
        public String Action { get; set; }

        [DataMember]
        public String Data { get; set; }
    }
}
