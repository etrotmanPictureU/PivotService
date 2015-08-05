using PivotDomain.DataPocos;
using System;
using System.Collections.Generic;
namespace PivotBusiness
{
    public interface IUserBusiness
    {
        int Login(string userName, string password);
        int ChangePassword(int UserKey, string newPassword);
        int CreateUser(User user);
    }
}
