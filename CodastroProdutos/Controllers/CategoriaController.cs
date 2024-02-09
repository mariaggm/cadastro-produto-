using CodastroProdutos.Data;
using CodastroProdutos.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodastroProdutos.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly Context context;
        public CategoriaController() 
        {  
            context = new Context();
        
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()    
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Categoria categoria) 
        {
            context.Categorias.Add(categoria);
            context.SaveChanges();
            return View(categoria);
         
        }
        
    }
}
