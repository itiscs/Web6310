using Microsoft.EntityFrameworkCore;

namespace FirstMVCApp.Models
{
    public class MyBase: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public MyBase(DbContextOptions<MyBase> options)
                  : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

    }
}
