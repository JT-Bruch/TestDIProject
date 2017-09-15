using Microsoft.Extensions.DependencyInjection;
using TestDbContext;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // create service collection
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            
                  // create service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();
            
                  // entry to run app
            serviceProvider.GetService<CommandLineApp>().Run();
        }

     private static void ConfigureServices(IServiceCollection serviceCollection)
     {
       
 
       // add services
       serviceCollection.AddDbContext<TestDIDbContext>();
 
       // add app
       serviceCollection.AddTransient<CommandLineApp>();
     }
}
}
