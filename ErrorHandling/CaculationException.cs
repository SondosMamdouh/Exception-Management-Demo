using System;

namespace ErrorHandling
{
    //tha main class of my custom exception ,that will be inhertied from other classes
   public class CaculationException :Exception
    {
        private static readonly string DEFAULTMessage = "An error occurred during caculation. ,please make sure that the operation is supported and that the values are within the range ";

        public CaculationException():base(DEFAULTMessage)
        {

        }

        public CaculationException(string message):base(message)
        {

        }

        public CaculationException(Exception innerException):base(DEFAULTMessage,innerException)
        {

        }

        public CaculationException(string message, Exception innerException): base(message, innerException)
        {
        }
    }
}
