using Reusable.Business.Core.BusinessResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.AppName.Web.Extensions
{
    public static class BusinessResultExtensions
    {
        //this an extension class of BusinessResult class
        //it has a static member ToBootstrapAlerts() which is a method taking all messages of a businessResult instance
        //and returns them inside as 'div' elements

        public static string ToBootstrapAlerts(this BusinessResult businessResult)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var msg in businessResult.Messages)
            {
                sb.AppendFormat("<div class='alert alert-{0} alert-dismissible fade show' role='alert'>{1} <button type='button' class='close' data-dismiss='alert' aria-label='Close'><span aria-hidden='true'>&times;</span></button></div>", msg.MessageType==Reusable.Business.Core.MessageType.Error?"danger":msg.MessageType.ToString().ToLower(),msg.Message);
            }
            return sb.ToString();
        }
    }
}
