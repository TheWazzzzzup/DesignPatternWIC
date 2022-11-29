namespace DesignPatternWIC
{
    internal sealed class Account
    {
        private static Account _instance;
        private static Object _lock;

        private Account() { }

        public static Account Instance()
        {
            lock (_lock)
            {
                if (_instance == null) { return _instance = new Account(); }
                else return _instance;
            }
        }

        public static void AccountAcsses()
        {
            Console.WriteLine("acsses some account");
        }

        public static void ChangePassword()
        {
            Console.WriteLine("change password");
        }

        public static void TwoStepsAut()
        {
            Console.WriteLine("activeate two steps authenticator");
        }
    }
}
