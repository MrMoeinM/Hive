namespace Hive.Application.Common.Exceptions
{
    public class ValidationException : AppException
    {
        public ValidationException(string property, params string[] errors)
            : base()
        {
            Errors = new Dictionary<string, string[]>();
            Errors[property] = errors;
        }

        public IDictionary<string, string[]> Errors { get; }
    }
}