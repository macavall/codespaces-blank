using Microsoft.Extensions.Hosting;

namespace testFunc
{
    public class Program
    {
        public static void main()
        {
            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .Build();

            host.Run();
        }
    }
}
