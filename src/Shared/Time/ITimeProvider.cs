namespace Shared.Time
{
    public interface ITimeProvider
    {
        public DateTime NowPeru { get; }
        public DateTime UtcNow { get; }
    }
}
