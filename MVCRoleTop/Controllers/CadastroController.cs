using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCRoleTop.Models;
using MVCRoleTop.Repositories;
using MVCRoleTop.ViewModel;

namespace MVCRoleTop.Controllers
{
    public class CadastroController : AbstractController
    {
        private ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {


            switch(ObterUsuarioNomeSession())
            {
                case "":
                    ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
                    return View(clienteviewmodel);
                default:
                    return RedirectToAction("index","Home");
            }


            
        }
        public IActionResult Login()
        {

            switch(ObterUsuarioNomeSession())
            {
                case "":
                    ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
                    return View(clienteviewmodel);
                default:
                    return RedirectToAction("index","Home");
            }

        }

        [HttpPost]
        public IActionResult Logar(IFormCollection form)
        {
            Cliente cliente = clienteRepository.ObterPor(form["Usuario"]);

            HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Usuario);
            return RedirectToAction("index","Cliente");
        }

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form)
        {
            try
            {

                if( form["Senha"] == form["RepetirSenha"] )
                {

                    Cliente cliente = new Cliente(form["Nome"],
                        form["Usuario"],
                        form["Senha"],
                        form["email"],
                        DateTime.Parse(form["Data_Nascimento"])
                    );
                    clienteRepository.Inserir(cliente);
                    HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Usuario);
                    return RedirectToAction("index","Cliente");
                }

            }catch(Exception e)
            {
                return View("Fracasso");
            }




            return View("Fracasso");

        }

    }
}
