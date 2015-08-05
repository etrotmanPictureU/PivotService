using Core.Types;
using Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivotData
{
    public class RepositoryHelper
    {
        public static void SetAuditInfoUpdate<T>(T entity)
        {
            Core.Types.User user = PrincipalExtractor.GetUserContext();
            if (user == null)
            {
                user = new User();
                user.Id = 0;
            }
            ReflectionHelper rh = new ReflectionHelper();
            rh.SetValueToProperty(entity, user.Id, "ModifiedBy");
            rh.SetValueToProperty(entity, DateTime.Now, "DateModified");
        }

        public static void SetAuditInfoInsert<T>(T entity)
        {
            Core.Types.User user = PrincipalExtractor.GetUserContext();
            if (user == null)
            {
                user = new User();
                user.Id = 0;
            }
            ReflectionHelper rh = new ReflectionHelper();
            rh.SetValueToProperty(entity, user.Id, "CreatedBy");
            rh.SetValueToProperty(entity, DateTime.Now, "DateCreated");
        }
    }
}
