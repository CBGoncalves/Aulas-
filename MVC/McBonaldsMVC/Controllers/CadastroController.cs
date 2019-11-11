using McBonalds_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
namespace McBonalds_MVC.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"] = "Cadastro";
            try{
            Cliente cliente = new Cliente(form["nome"], form["endereco"], form["telefone"], form["senha"], form["email"], DateTime.Parse(form["data-nascimento"]));
            System.Console.WriteLine(form["nome"]);
            return View("Sucesso");
            }catch(Exception e){
                return View ("Erro"); 
            }
        }
    }
}