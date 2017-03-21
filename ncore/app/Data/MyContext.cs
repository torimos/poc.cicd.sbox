using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ncore.Data
{
    public class MyContext: DbContext
    {
        public MyContext() : base()
        {
        }

        public DbSet<MyModel> MyModels { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder
                .UseSqlServer(@"Server=(LocalDb)\ncore;Database=MyDB;Trusted_Connection=True;");
    }
}
