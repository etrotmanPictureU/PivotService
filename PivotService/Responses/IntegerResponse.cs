using System.Runtime.Serialization;
using Core.Services;


namespace PivotService.Responses
{
    public class IntegerResponse : ServiceOperationResponse
    {
        [DataMember]
        public int Result { get; set; }

        [DataMember]
        public string Data { get; set; }
    }
}