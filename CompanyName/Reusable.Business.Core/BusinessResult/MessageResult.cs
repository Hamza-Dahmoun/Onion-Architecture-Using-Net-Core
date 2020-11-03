﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Reusable.Business.Core.BusinessResult
{
    /// <summary>
    /// This class represent a message information that can be added to the list of messages returned by business operation.
    /// </summary>
    

    public class MessageResult
    {
        public string Message { get; set; }
        public MessageType MessageType { get; set; }
    }
}
