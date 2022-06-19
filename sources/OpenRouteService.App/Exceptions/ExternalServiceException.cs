using System;
using System.Runtime.Serialization;

namespace OpenRouteService.App.Exceptions
{
    public class ExternalServiceException : AppException
    {
        public ExternalServiceException()
        {
        }

        public ExternalServiceException(string message) : base(message)
        {
        }

        public ExternalServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExternalServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}