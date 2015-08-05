using Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PivotBusiness
{
    public class ErrorList
    {
        public static ErrorInfo ErrorSendingEmail { get { return new ErrorInfo() { Code = 1000, Message = "Error Sending Email", Key = "ErrorSendingEmail" }; } }
        public static ErrorInfo ErrorUpdateUser { get { return new ErrorInfo() { Code = 1002, Message = "Error Updating User", Key = "ErrorUpdatingEmail" }; } }
        public static ErrorInfo InvalidUser { get { return new ErrorInfo() { Code = 1003, Message = "Invalid User", Key = "InvalidUser" }; } }
        public static ErrorInfo UserAlreadyExists { get { return new ErrorInfo() { Code = 1005, Message = "User Already Exists", Key = "UserAlreadyExists" }; } }
        public static ErrorInfo DuplicateEntryExists { get { return new ErrorInfo() { Code = 1006, Message = "Duplicate Entry exists", Key = "DuplicateEntryExists" }; } }
        public static ErrorInfo SimiliarNamesExists { get { return new ErrorInfo() { Code = 1007, Message = "Duplicate Entry exists", Key = "DuplicateEntryExists" }; } }
        public static ErrorInfo NotificationAlreadySent { get { return new ErrorInfo() { Code = 1008, Message = "Notification already sent", Key = "NotificationAlreadySent" }; } }
        public static ErrorInfo InvalidRange { get { return new ErrorInfo() { Code = 1024, Message = "Invalid Range", Key = "InvaliddRange" }; } }
    }
}
