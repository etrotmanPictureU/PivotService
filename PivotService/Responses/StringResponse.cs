using System.Runtime.Serialization;
using Core.Services;

namespace PivotService.Responses
{
    public class StringResponse : ServiceOperationResponse
    {
        [DataMember]
        public string Result { get; set; }
    }
}