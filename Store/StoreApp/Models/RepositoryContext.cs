using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    //VERİTABANI GİBİ GMRECEĞİZ BU SINIFI
    public class RepositoryContext: DbContext
    {
          public DbSet<Product> Products{get;set;}
    }
    public void RepositoryContext(DbContextOptions<RepositoryContext> options)
    :base(options)
    {

    }
}