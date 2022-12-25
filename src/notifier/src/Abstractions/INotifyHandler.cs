namespace notifier
{
    public interface INotifyHandler<Tin, Tout>
    {
        Task<Tout> Handle(Tin input);
    }
}
