using System;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCRoleTop.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet]
        public IActionResult Login_Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login_Cadastro(IFormCollection form)
        {
            ViewData["Action"] = "Login_Cadastro";
            try
            {
                System.Console.WriteLine("==================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("==================");

                return View("Sucesso");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }
        }
    }
}