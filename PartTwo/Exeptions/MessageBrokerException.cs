using System;
using System.Runtime.Serialization;

namespace PartTwo.Exeptions
{
	[Serializable]
    public class MessageBrokerException : Exception
    {
        public MessageBrokerException() { }
        public MessageBrokerException(string msg) : base(msg) { }
        public MessageBrokerException(string msg, Exception innerEx) : base(msg, innerEx) { }
        private MessageBrokerException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
