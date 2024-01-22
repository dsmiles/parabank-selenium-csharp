namespace ParaBankFramework.Generators
{
    public static class PasswordGenerator
    {
        private static bool _toggle = true;

        public static string Generate()
        {
            var password = "";
            password = _toggle ? "Password" : "New Password";

            _toggle = !_toggle;
            LastGeneratedPassword = password;
            return password;
        }

        public static string LastGeneratedPassword { get; set; }
    }
}