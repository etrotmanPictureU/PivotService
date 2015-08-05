using PivotDomain.DataPocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivotData.Repository
{
    public interface IUserRepository <PivotEntities>
    {
        User Login(string userName, string password);
        int Create(User user);
        PivotDomain.DataPocos.User GetUser(string userName);

    }
}
