using Microsoft.EntityFrameworkCore;
using System;

namespace TestDbContext
{
    public class TestDIDbContext : DbContext
    {
        public TestDIDbContext(DbContextOptions<TestDIDbContext> options) : base (options)
        {

        }
    }
}
