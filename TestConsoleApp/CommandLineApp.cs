using TestDbContext;

namespace TestConsoleApp
{
    public class CommandLineApp
    {
        private readonly TestDIDbContext context;
        public CommandLineApp(TestDIDbContext _context)
        {
            context = _context;
        }

        public int Run()
        {
            return 0;
        }
    }
}
