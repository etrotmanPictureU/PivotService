
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PivotService.Responses;
using PivotBusiness;
using PivotDomain.DataPocos;
using AutoMapper;
using PivotDomain.ServicePocos;

namespace PivotService
{
    public partial class PivotService : IPivotService
    {
        public IntegerResponse CreateUser(ServiceUser user)
        {
            User dp = null;
            dp = Mapper.Map(user, dp);
            int id = userBusiness.CreateUser(dp);
            return new IntegerResponse() { Result = id };
        }

        public IntegerResponse Login(string userName, string password)
        {
           int id = userBusiness.Login(userName,password);
            return new IntegerResponse() { Result = id };
        }
    }
}
