﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using skilltech.Data;
using skilltech.Models;


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
    }
}
