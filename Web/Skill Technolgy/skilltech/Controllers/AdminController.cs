using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using skilltech.Data;
using skilltech.Models;
using Microsoft.EntityFrameworkCore;


namespace skilltech.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminController (ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Index(AdminModel model)
        {
            if (ModelState.IsValid)
            {
                _context.AdminModels.Add(model);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Admin cadastrado com sucesso!";
                return View("../Admin/Index");
            }
            return View(model);
        }

        //list ADm

        public IActionResult AdmCadastrados()
        {
            var adms  = _context.AdminModels.ToList();
            return View(adms);
        }



        //Admin Root
        /* int Senha;
         string Email;
         public IActionResult LoginAdmin()
         {
             if(Senha==1234 && Email=="sime@admim.com")
             {
                 return RedirectToAction("Admin/Index");
             }
             return View();
         }
        */

        //loging admm
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string email, string senha)
        {
            if (ModelState.IsValid)
            {
                var admin = await _context.AdminModels
                    .FirstOrDefaultAsync(a => a.Email == email && a.Senha == senha);

                if (admin != null)
                {
                    // Autenticação bem-sucedida, redirecionar para a página de administração
                    // Você pode usar um mecanismo de autenticação, como cookies, aqui
                    return RedirectToAction("Index", "Home");
                }

                // Caso contrário, mostrar uma mensagem de erro
                ModelState.AddModelError(string.Empty, "Login inválido.");
            }

            return View();
        }
    }
}
