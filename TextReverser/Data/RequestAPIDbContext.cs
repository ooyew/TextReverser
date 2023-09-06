using Microsoft.EntityFrameworkCore;
using TextReverser.Models;

namespace TextReverser.Data
{
    public class RequestAPIDbContext : DbContext
    {
        public RequestAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Request> Requests { get; set; }
    }
}
