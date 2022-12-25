namespace notifier
{
    public class EmailNotifyRequest : INotifyRequest<Guid>
    {
        public string FromEmail { get; set; }

        public string ToEmail { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public EmailNotificationOptions EmailNotificationOptionss { get; set; }
    }

    public class EmailNotificationOptions
    {
        public string SmtpUserName { get; set; }

        public string SmtpPassword { get; set; }

        public int Port { get; set; }
    }
}
