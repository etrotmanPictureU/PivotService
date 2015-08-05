using PivotService;
using PivotService.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PivotService
{
    public partial interface IPivotService
    {


        [FaultContract(typeof(ServiceOperationFault))]
        [OperationContract]
        EventResponse GetEvents();

        [FaultContract(typeof(ServiceOperationFault))]
        [OperationContract]
        EventResponse GetEventById(int id);


    }
}
