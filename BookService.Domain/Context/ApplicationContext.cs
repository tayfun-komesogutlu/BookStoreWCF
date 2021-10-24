using BookService.Contracts.Dto;
using BookService.Domain.Dto;
using System.Data.Entity;

namespace BookService.Domain.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("name=ConnectionString")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
    }
}
