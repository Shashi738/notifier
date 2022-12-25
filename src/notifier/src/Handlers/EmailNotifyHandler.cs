namespace notifier
{
    public class EmailNotifyHandler : INotifyHandler<EmailNotifyRequest, Guid>
    {
        public async Task<Guid> Handle(EmailNotifyRequest input)
        {            
            var task = Task.Run(() => Guid.NewGuid());            
            return await task;
        }
    }
}
