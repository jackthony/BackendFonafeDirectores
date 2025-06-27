namespace Api.Settings
{
    public class BunnyStorageOptions
    {
        public string StorageZone { get; set; } = string.Empty;
        public string ApiKey { get; set; } = string.Empty;
        public string BaseUrl { get; set; } = "https://storage.bunnycdn.com";
    }
}
