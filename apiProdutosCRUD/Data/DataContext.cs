using apiProdutosCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace apiProdutosCRUD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}

        public DbSet<Produto> produtos{get;set;}
        

    }
}