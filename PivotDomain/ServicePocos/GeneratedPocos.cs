//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;


namespace PivotDomain.ServicePocos
{
    [DataContract(IsReference = true)]
    public partial class ServiceEvent
    {
    
    	[Required]
        [DataMember]
        public int Id { get; set; }
    
    	[Required]
    	[StringLength(100)]
        [DataMember]
        public string Name { get; set; }
    
    	[Required]
        [DataMember]
        public bool Deleted { get; set; }
    
    	[Required]
        [DataMember]
        public System.DateTime DateCreated { get; set; }
    
        [DataMember]
        public Nullable<System.DateTime> DateModified { get; set; }
    }
    
}
namespace PivotDomain.ServicePocos
{
    [DataContract(IsReference = true)]
    public partial class ServiceUser
    {
    
    	[Required]
        [DataMember]
        public int Id { get; set; }
    
    	[Required]
    	[StringLength(50)]
        [DataMember]
        public string Name { get; set; }
    
    	[Required]
    	[StringLength(50)]
        [DataMember]
        public string Password { get; set; }
    
    	[Required]
        [DataMember]
        public bool Deleted { get; set; }
    
    	[Required]
        [DataMember]
        public System.DateTime DateCreated { get; set; }
    
        [DataMember]
        public Nullable<System.DateTime> DateModified { get; set; }
    }
    
}