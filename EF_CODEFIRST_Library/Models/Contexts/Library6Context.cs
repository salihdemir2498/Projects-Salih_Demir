using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EF_CODEFIRST.Models;

namespace EF_CODEFIRST.Models
{
    public class Library6Context : DbContext
    {
        public Library6Context(DbContextOptions<Library6Context> options) : base(options)
        {

        }

        public DbSet<Category> Categories {get; set;}
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) //optionsBuilder configüre edilmemiş ise yani veri tabanı ayarları yapılmamış ise
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:LibraryConn");
            }
        }

    }
}