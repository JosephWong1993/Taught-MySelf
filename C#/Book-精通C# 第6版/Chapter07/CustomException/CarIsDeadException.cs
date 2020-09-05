using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomException
{
    [Serializable]
    class CarIsDeadException : ApplicationException
    {
        public string CauseOfError { get; set; }
        public DateTime ErrorTimeStamp { get; set; }

        public CarIsDeadException() { }
        public CarIsDeadException(string message)
            : base(message) { }
        public CarIsDeadException(string message, System.Exception inner)
            : base(message, inner) { }
        public CarIsDeadException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

        public CarIsDeadException(string message, string cause, DateTime time)
            : base(message)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
    }
}
