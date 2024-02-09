using CodastroProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace CodastroProdutos.Data
{
    public class Context : DbContext 
    {
        internal static object Categoria;

        public DbSet<Categoria> Categorias {  get; set; }
    }
}
