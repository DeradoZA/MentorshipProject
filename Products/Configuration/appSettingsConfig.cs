namespace Products.Configuration
{
    public class AppSettingsConfig
    {
        public string dbConnectionString { get; set; }
        public LoggingConfig Logging { get; set; }
        public string AllowedHosts { get; set; } = "*";
    }
}
