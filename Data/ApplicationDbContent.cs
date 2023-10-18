namespace AmazonBook.Data;
using Microsoft.EntityFrameworkCore;
using AmazonBooks.Models;
public class ApplicationDbContext:DbContext
{

public ApplicationDbContext(DbContextOptions<Application>options):base(options){

}
public DbSet<BooksEntity>Books{get;}
}