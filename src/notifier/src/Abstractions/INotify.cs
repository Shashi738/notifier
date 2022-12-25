namespace notifier
{
    public interface INotify
    {
        Task<Tout> Send<Tout>(INotifyRequest<Tout> notifyRequest);
    }
}
