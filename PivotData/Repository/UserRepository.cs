using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;

using Core.Types;
using PivotData.DataModel;
using PivotDomain.DataPocos;
using Core.Data.DbContext;

namespace PivotData.Repository
{
    public class UserRepository<CONTEXT> : RepositoryBase<CONTEXT,PivotDomain.DataPocos.User>, IUserRepository<CONTEXT> where CONTEXT : PivotEntities
    {
        IDatabaseFactory<CONTEXT> databaseFactory = null;
        public UserRepository(IDatabaseFactory<CONTEXT> databaseFactory)
            : base(databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        public int Create(PivotDomain.DataPocos.User user)
        {
            RepositoryHelper.SetAuditInfoInsert<PivotDomain.DataPocos.User>(user);
            this.DataContext.User.Add(user);
            this.DataContext.SaveChanges();
            return 1;
        }

        public PivotDomain.DataPocos.User Login(string userName, string password)
        {

            var query = (from user in this.DataContext.User
                         where user.Password == password  && user.Name.ToLower() == userName
                         select user);

            return query.FirstOrDefault();
        }
        public PivotDomain.DataPocos.User GetUser(string userName)
        {

            var query = (from user in this.DataContext.User
                         where user.Name.ToLower() == userName
                         select user);

            return query.FirstOrDefault();
        }
    }
}
