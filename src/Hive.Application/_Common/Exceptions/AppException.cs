namespace Hive.Application.Common.Exceptions
{
    public abstract class AppException : Exception
    {
        public AppException()
           : base()
        {
        }

        public AppException(string message)
            : base(message)
        {
        }

        public AppException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
