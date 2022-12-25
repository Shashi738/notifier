namespace notifier
{
    public class Notifier : INotify
    {
        public Notifier()
        {
           
        }

        public async Task<Tout> Send<Tout>(INotifyRequest<Tout> notifyRequest)
        {
            var notifyHandler = NotificationHandlerFactory.Create(notifyRequest);                
            if (notifyHandler == null)
            {
                throw new NotifyException($"Notification Hanlder of type {notifyRequest.GetType()} not supported");
            }

            var request = NotificationHandlerFactory.GetRequest(notifyRequest);
            var res = await notifyHandler.Handle(request);
            return (Tout)Convert.ChangeType(res, typeof(Tout));            
        }
    }
}
