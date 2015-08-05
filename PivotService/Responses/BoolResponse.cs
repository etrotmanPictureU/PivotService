using System.Runtime.Serialization;
using Core.Services;


namespace PivotService.Responses
{
    public class BoolResponse : ServiceOperationResponse
    {
        [DataMember]
        public bool Result { get; set; }
    }
}