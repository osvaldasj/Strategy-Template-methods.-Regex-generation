namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            client.Info();

            client.AdditionalInfo();
            client.Info();
        }
    }
}
