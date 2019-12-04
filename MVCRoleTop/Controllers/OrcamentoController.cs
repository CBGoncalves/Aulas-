using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCRoleTop.Models;
using MVCRoleTop.Repositories;

namespace MVCRoleTop.Controllers
{
    public class OrcamentoController : Controller
    {
        OrcamentoRepository orcamentoRepository = new OrcamentoRepository();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrar (IFormCollection form) 
        {
            ViewData["Action"] = "Orcamento";
            try {
                Orcamento orcamento = new Orcamento (
                    form["nome"],
                    form["email"],
                    form["telefone"],
                    DateTime.Parse (form["data_evento"]),
                    form["tipo_evento"],
                    double.Parse(form["numero_pessoas"]),
                    form["como_conheceu"],
                    form["observacoes"]);
                    
                    orcamentoRepository.Inserir(orcamento);
                    
                return View ("Sucesso");
            } 
            catch (Exception e) 
            {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro");
            }
        }
    }
}