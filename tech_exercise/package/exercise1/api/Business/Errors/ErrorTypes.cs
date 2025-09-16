namespace StargateAPI.Business.Errors
{
    // NOTE: This is in the data class because upon throw, we would log the exception in the Logs (LogEntry) table
    public class GeneralException : Exception
    {
        public GeneralException(string message) 
        {
            // this will be a custom catch-all exception
        }
    }

    public class PersonExistsException : BadHttpRequestException
    {
        public PersonExistsException(string message) : base(message)
        {
            // this is an example class of custom exceptions
        }
    }

    public class PersonDoesNotExistException : BadHttpRequestException
    {
        public PersonDoesNotExistException(string message) : base(message)
        {
            
        }
    }

    public class AstronautDetailMissingException : BadHttpRequestException
    {
        public AstronautDetailMissingException(string message) : base(message)
        {
            // log message, then throw
            throw new BadHttpRequestException(message);
        }
    }

    public class AstronautDutiesMissingException : BadHttpRequestException
    {
        public AstronautDutiesMissingException(string message) : base(message)
        {
            // log error message here, then throw
            throw new BadHttpRequestException(message);
        }
    }
}
