using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkCore.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
    }
}
