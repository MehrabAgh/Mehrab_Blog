using Microsoft.EntityFrameworkCore;
using System;

namespace BlogUniversity.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
        }
    }
}
