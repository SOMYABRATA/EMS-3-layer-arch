using System;
using System.Runtime.Serialization;

namespace Capgemini.EMS.PL
{
    [Serializable]
    internal class EMSException : Exception
    {
        public EMSException()
        {
        }

        public EMSException(string message) : base(message)
        {
        }

        public EMSException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EMSException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}