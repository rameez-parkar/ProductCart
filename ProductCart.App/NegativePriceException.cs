using System;
using System.Runtime.Serialization;

namespace ProductCart.App
{
    [Serializable]
    internal class NegativePriceException : Exception
    {
        public NegativePriceException()
        {
        }

        public NegativePriceException(string message) : base(message)
        {
        }

        public NegativePriceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativePriceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}