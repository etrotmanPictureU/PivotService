using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SAM.Domain.ServicePocos
{
    public class ServiceTestResultForDiagnosis
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string IsManuallyLoaded { get; set; }
        [DataMember]
        public int TestId { get; set; }
        [DataMember]
        public string TestName { get; set; }
        [DataMember]
        public string AlphaNumericValue { get; set; }
        [DataMember]
        public decimal NumericValue { get; set; }
        [DataMember]
        public int SampleId { get; set; }
        [DataMember]
        public int SeverityId { get; set; }
    }
}