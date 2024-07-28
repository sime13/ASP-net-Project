using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using skilltech.Models;


namespace skilltech.Controllers
{
    public class AdmRootController : Controller
    {
        public IActionResult RootLog(string Email, string Senha)
        {
            if(Email == "sime@adm.com" && Senha == "sime1234")
            {
                return View("../Admin/Index");
            }
            ViewBag.Message = "Email ou senha incorretos.";
            return View();
        }
    }
}
