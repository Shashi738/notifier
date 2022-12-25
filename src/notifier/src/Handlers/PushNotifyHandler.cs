namespace notifier
{
    public class PushNotifyHandler : INotifyHandler<PushNotifyRequest, Guid>
    {
        public async Task<Guid> Handle(PushNotifyRequest input)
        {
            var task = Task.Run(() => Guid.NewGuid());            
            return await task;
        }
    }
}
