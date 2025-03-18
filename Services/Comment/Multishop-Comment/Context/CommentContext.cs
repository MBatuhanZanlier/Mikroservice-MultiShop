using Microsoft.EntityFrameworkCore;
using Multishop_Comment.Entities;

namespace Multishop_Comment.Context
{
    public class CommentContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1442;initial Catalog=MultiShopCommentDb;User=sa;Password=123456789Aa*");
        }

        public DbSet<UserComment> UserComments { get; set; }
    }
  
}
