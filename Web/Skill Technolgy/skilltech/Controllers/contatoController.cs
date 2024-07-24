using Microsoft.AspNetCore.Mvc;
using skilltech.Data;
using skilltech.Models;


namespace skilltech.Controllers
{
    public class contatoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public contatoController (ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(contatoModel model) 
        {
            if (ModelState.IsValid)
            {
                _context.contatoModels.Add(model);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Mensagem enviada com sucesso!";
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult Success()
        {
            return View();
        }


        public IActionResult ExibirContatos()
        {
            var contatos = _context.contatoModels.ToList();
            return View(contatos);
        }

    }
}
