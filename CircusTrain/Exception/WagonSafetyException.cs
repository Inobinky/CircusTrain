using System;
using System.Runtime.Serialization;

namespace CircusTrain
{
    [Serializable]
    public class WagonSafetyException : Exception
    {
        public WagonSafetyException() { }
        public WagonSafetyException(string message) : base(message) { }
        public WagonSafetyException(string message, Exception innerException) : base(message, innerException) { }
        protected WagonSafetyException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
