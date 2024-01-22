namespace ParaBankFramework.Support
{
    internal class BaseAddress
    {
        static BaseAddress()
        {
            Url = @"http://parabank.parasoft.com/parabank/";
        }

        public static string Url { get; private set; }
    }
}