namespace notifier
{
    public static class NotificationHandlerFactory
    {
        public static dynamic Create<Tout>(INotifyRequest<Tout> notifyRequest)
        {
            if (notifyRequest.GetType().Equals(typeof(EmailNotifyRequest)))
            {
                return CreateHandler<EmailNotifyRequest, Tout>(notifyRequest);
            }

            if (notifyRequest.GetType().Equals(typeof(PushNotifyRequest)))
            {
                return CreateHandler<PushNotifyRequest, Tout>(notifyRequest);
            }

            throw new NotifyException($"Notification Hanlder of type {notifyRequest.GetType()} not supported");
        }

        private static INotifyHandler<Tin, Tout> CreateHandler<Tin, Tout>(INotifyRequest<Tout> notifyRequest)
        {
            if (notifyRequest.GetType().Equals(typeof(EmailNotifyRequest)))
            {
                return (INotifyHandler<Tin, Tout>)new EmailNotifyHandler();
            }

            if (notifyRequest.GetType().Equals(typeof(PushNotifyRequest)))
            {
                return (INotifyHandler<Tin, Tout>)new PushNotifyHandler();
            }

            throw new NotifyException($"Notification Hanlder of type {notifyRequest.GetType()} not supported");
        }

        public static dynamic GetRequest<Tout>(INotifyRequest<Tout> notifyRequest)
        {
            if (notifyRequest.GetType().Equals(typeof(EmailNotifyRequest)))
            {
                return (EmailNotifyRequest)notifyRequest;
            }
            
            if (notifyRequest.GetType().Equals(typeof(PushNotifyRequest)))
            {
                return (PushNotifyRequest)notifyRequest;
            }

            throw new NotifyException($"Notification Request of type {notifyRequest.GetType()} not supported");
        }
    }
}
