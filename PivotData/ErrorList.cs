using Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivotData
{
    public class ErrorList
    {
        public static ErrorInfo UniqueKeyViolation { get { return new ErrorInfo() { Code = 10000, Message = "Unique Key Violation", Key = "UniqueKeyViolation" }; } }
        public static ErrorInfo AlternateKeysFound { get { return new ErrorInfo() { Code = 10001, Message = "Alternate Keys Found", Key = "AlternateKeysFound" }; } }
        public static ErrorInfo NoPricingFoundForProduct { get { return new ErrorInfo() { Code = 10002, Message = "No Pricing Found For Product", Key = "NoPricingFoundForProduct" }; } }
        public static ErrorInfo UniqueKeyNameViolation { get { return new ErrorInfo() { Code = 10003, Message = "UniqueKeyNameViolation", Key = "UniqueKeyNameViolation" }; } }
        public static ErrorInfo UniqueKeyNameWarning { get { return new ErrorInfo() { Code = 10004, Message = "UniqueKeyNameWarning", Key = "UniqueKeyNameWarning" }; } }
   
    }
}
