using System;
using System.Runtime.Serialization;

namespace CircusTrain
{
    [Serializable]
    public class WagonCapacityException : Exception
    {
        public WagonCapacityException() { }
        public WagonCapacityException(string message) : base(message) { }
        public WagonCapacityException(string message, Exception innerException) : base(message, innerException) { }
        protected WagonCapacityException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
