using System;
using System.Runtime.Serialization;

namespace Capgemini.EMS.Exceptions
{
    public class EmsExceptions : ApplicationException
    {
        public EmsExceptions()
        {
        }

        public EmsExceptions(string message) : base(message)
        {
        }

        public EmsExceptions(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmsExceptions(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
