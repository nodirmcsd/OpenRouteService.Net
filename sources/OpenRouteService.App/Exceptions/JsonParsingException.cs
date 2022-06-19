using System;
using System.Net;
using System.Runtime.Serialization;

namespace OpenRouteService.App.Exceptions
{
    public class JsonParsingException : AppException
    {
        public JsonParsingException()
        {
        }

        public JsonParsingException(string message) : base(message)
        {
        }

        public JsonParsingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected JsonParsingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public string? BodyText { get; set; }

        public HttpStatusCode HttpStatus { get; set; }
    }
}