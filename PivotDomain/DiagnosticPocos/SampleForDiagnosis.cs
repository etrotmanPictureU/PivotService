using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace SAM.Domain.DataPocos
{
    public class SampleForDiagnosis : Sample
    {
        public string LabName { get; set; }
        public int RackNumber { get; set; }

        public int TrackingNo { get; set; }
        public string TrackingPrefix { get; set; }
        public new string TrackingNumber
        { 
            get
            { 
                return TrackingPrefix + TrackingNo.ToString(); 
            }
        }

        public int SeverityId { get; set; }
        public int SampleSeverityName { get; set; }

        public string UnitMakeName { get; set; }
        public string UnitModelName { get; set; }

        public string ComponentMakeName { get; set; }
        public string ComponentModelName { get; set; }
        public string ComponentTypeName { get; set; }
        public string ComponentCapacity { get; set; }
        public string ComponentLocation { get; set; }
        public string ComponentSerialNumber { get; set; }

        public decimal? Capacity { get; set; }
        public string CapacityUnitOfMeasure { get; set; }

        public string FluidType { get; set; }
        public string FluidMnf { get; set; }
        public string FluidGrade { get; set; }

        public string TestPackage { get; set; }
        public string UINNumber { get; set; }

        // sample operators
        public string OperatorDataEntry { get; set; }
        public DateTime OperatorDataEntryDate { get; set; }
        public string OperatorLogged { get; set; }
        public DateTime OperatorLoggedDate { get; set; }
        public string OperatorReleased { get; set; }
        public DateTime OperatorReleasedDate { get; set; }
        public string OperatorDiagnosed { get; set; }
        public DateTime OperatorDiagnosedDate { get; set; }

        public List<SampleHistory> History { get; set; }
        public List<SampleTestResult> TestResultHistory { get; set; }

    }
}

namespace SAM.Domain.ServicePocos
{
    public partial class ServiceSampleForDiagnosis : ServiceSample
    {
        [DataMember]
        public string TrackingNumber { get; set; }
        [DataMember]
        public string LabName { get; set; }
        [DataMember]
        public int RackNumber { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string UnitMakeName { get; set; }
        [DataMember]
        public string UnitModelName { get; set; }
        [DataMember]
        public decimal? Capacity { get; set; }
        [DataMember]
        public string CapacityUnitOfMeasure { get; set; }
        [DataMember]
        public string ComponentMakeName { get; set; }
        [DataMember]
        public string ComponentModelName { get; set; }
        [DataMember]
        public string ComponentTypeName { get; set; }
        [DataMember]
        public string ComponentLocation { get; set; }
        [DataMember]
        public string ComponentSerialNumber { get; set; }
        [DataMember]
        public string FluidType { get; set; }
        [DataMember]
        public string FluidMnf { get; set; }
        [DataMember]
        public string FluidGrade { get; set; }
        [DataMember]
        public string TestPackage { get; set; }
        [DataMember]
        public string OperatorDataEntry { get; set; }
        [DataMember]
        public DateTime OperatorDataEntryDate { get; set; }
        [DataMember]
        public string OperatorLogged { get; set; }
        [DataMember]
        public DateTime OperatorLoggedDate { get; set; }
        [DataMember]
        public string OperatorReleased { get; set; }
        [DataMember]
        public DateTime OperatorReleasedDate { get; set; }
        [DataMember]
        public string OperatorDiagnosed { get; set; }
        [DataMember]
        public DateTime OperatorDiagnosedDate { get; set; }
        [DataMember]
        public string UINNumber { get; set; }
        [DataMember]
        public int SeverityId { get; set; }
        [DataMember]
        public List<ServiceTestResultForDiagnosis> SampleTestResult { get; set; }
        [DataMember]
        public List<ServiceSampleHistory> History { get; set; }
        [DataMember]
        public List<ServiceTestResultForDiagnosis> TestResultHistory { get; set; }
    }
}