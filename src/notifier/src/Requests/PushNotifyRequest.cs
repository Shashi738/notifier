namespace notifier
{
    public class PushNotifyRequest : INotifyRequest<Guid>
    {
        public string Title { get; set; }

        public string Body { get; set; }

        public string DeviceId { get; set; }

        public bool IsAndroidDevice { get; set; }

        public PushNotificationOptions PushNotificationOptions { get; set; }
    }

    public class PushNotificationOptions
    {
        public string SenderId { get; set; }

        public string SenderKey { get; set; }
    }
}
