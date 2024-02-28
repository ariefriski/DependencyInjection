using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionTask
{
    public class Program
    {

        private readonly ILogger _logger;

        public Program(ILogger logger)
        {
            _logger = logger;
        }
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                 .AddSingleton<ILogger, ConsoleLogger>() // Registrasi ILogger dan implementasinya di sini
                 .BuildServiceProvider();

            // Ambil instance logger dari service provider
            var logger = serviceProvider.GetService<ILogger>();

            // Pastikan logger tidak null sebelum membuat instance Program
            if (logger != null)
            {
                // Buat instance program
                var program = new Program(logger);

                // Jalankan program
                program.Run();
            }
            else
            {
                Console.WriteLine("Failed to resolve ILogger from the service provider.");
            }

            Console.ReadLine();
        }

        public void Run()
        {
            _logger.Log("Hello, World!");
        }
    }
}
