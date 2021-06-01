using DIDemoinAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemoinAPI.Data
{
    public class MiniDbContext : DbContext
    {
        //db ile iletişim kuracak sınıfınız budur.
        //1. Products tablosunu oluştur.


        public MiniDbContext(DbContextOptions<MiniDbContext> options) : base(options)
        {
            //EF ister MSSQL ile ister Oracle isterse başka bir RDBMS ile çalışabilir!
        }
        public DbSet<Product> Products { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Description).IsRequired();
            modelBuilder.Entity<Product>().Property(p => p.Description).HasMaxLength(150);
            modelBuilder.Entity<Product>().Property(p => p.Price).IsRequired();


        }

    }
}
