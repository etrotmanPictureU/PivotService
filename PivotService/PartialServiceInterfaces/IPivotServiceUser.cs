using PivotDomain.ServicePocos;
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
        IntegerResponse Login(string userName, string password);

        [FaultContract(typeof(ServiceOperationFault))]
        [OperationContract]
        IntegerResponse CreateUser(ServiceUser user);
    }
}
