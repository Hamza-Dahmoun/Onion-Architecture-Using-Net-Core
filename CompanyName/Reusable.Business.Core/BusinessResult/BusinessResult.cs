using System;
using System.Collections.Generic;
using System.Text;

namespace Reusable.Business.Core.BusinessResult
{
    /// <summary>
    /// This class represents the result of a busines operation execution.
    /// The Succeeded property value indicate the succes or not of the busines operation.
    /// The Messages property contains the list of messages returned in case of success, warning or error.
    /// </summary>
    
    public class BusinessResult
    {
        public BusinessResult()
        {
            Messages = new HashSet<MessageResult>();//!!!
        }

        public ICollection<MessageResult> Messages { get; }
        public bool Succeeded { get; set; }
        public static BusinessResult Success 
        {
            //this is a stic member to be assigned to a businessResult after doing an operation successfully
            get
            {
                var result = new BusinessResult { Succeeded = true };
                result.Messages.Add(new MessageResult { Message = "Operation done successfully", MessageType = MessageType.Success });
                return result;
            }
        }
    }
}
