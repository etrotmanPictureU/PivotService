using Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivotDomain
{
    public class UserCriteria : ICoreDataFilter
    {
        public SearchSortCriteria<string> UserName { get; set; }
        public SearchSortCriteria<string> EmailAddress { get; set; }
        public SearchSortCriteria<string> FirstName { get; set; }
        public SearchSortCriteria<string> LastName { get; set; }
        public SearchSortCriteria<string> CultureName { get; set; }
        public PageCriteria PageCriteria { get; set; }
    }
}
