namespace Shared.ClientV1
{
    public abstract class BaseRequest
    {
        public Guid Ticket { get; set; } = Guid.NewGuid();
        public string ClientName { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string ServerName { get; set; } = string.Empty;
        public int Resultado { get; set; } = int.MaxValue;
    }
}
