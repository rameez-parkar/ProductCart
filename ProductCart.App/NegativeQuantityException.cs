using System;
using System.Runtime.Serialization;

namespace ProductCart.App
{
    [Serializable]
    internal class NegativeQuantityException : Exception
    {
        public NegativeQuantityException()
        {
        }

        public NegativeQuantityException(string message) : base(message)
        {
        }

        public NegativeQuantityException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeQuantityException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}