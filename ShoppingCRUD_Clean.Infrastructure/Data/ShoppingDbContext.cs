
using ShoppingCRUD_Clean.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ShoppingCRUD_Clean.Infrastructure.Data
{
    public class ShoppingDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ShoppingDbContext(DbContextOptions<ShoppingDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public DbSet<ShoppingList> ShoppingListItems { get; set; }
    }
}
