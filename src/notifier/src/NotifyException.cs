namespace notifier
{
    public class NotifyException : Exception
    {
        public NotifyException()
        {
        }

        public NotifyException(string message) : base(message)
        {
        }

        public NotifyException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
