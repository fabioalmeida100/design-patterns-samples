namespace Singleton.Utils
{
    public class ConfigurationSingletonHelper
    {
        private static ConfigurationSingletonHelper _instance;
        private static readonly object _lock = new object();
        private ConfigurationSingletonHelper()
        {
        }
        public static ConfigurationSingletonHelper GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock) // Lock for thread safe
                {
                    if (_instance == null)
                        _instance = new ConfigurationSingletonHelper();
                }
            }
            return _instance;
        }
        public string GetConnectionString()
        {
            return "Data Source=.;Initial Catalog=Test;Integrated Security=True";
        }

        public string GetOtherConfiguration(string key)
        {
            return $"Sample of get other configuration: {key}";
        }
    }
}
