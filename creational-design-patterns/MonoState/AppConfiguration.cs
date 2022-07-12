namespace MonoState
{
    public class AppConfig
    {
        private static String key;

        public String getData()
        {
            return AppConfig.key;
        }

        public void setKey(string value)
        {
            AppConfig.key = value;
        }

        public AppConfig()
        {
            
        }
    }
}
