using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PivotDomain
{
     [DataContract(IsReference = true)]
    public class GridSelection
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public bool IsChecked { get; set; }
        [DataMember]
        public string Value { get; set; }
    }
}
