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
    public class ClienteController : AbstractController
    {
        EventoRepository eventorepository = new EventoRepository();
        
        public IActionResult Index()
        {

            switch(ObterUsuarioNomeSession())
            {
                case "Admin":
                    return RedirectToAction("Dashboard","Administrador");
                case "":
                    return RedirectToAction("index","Home");
                default:
                    ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
                    clienteviewmodel.Eventos = eventorepository.ObterEventosCliente(ObterUsuarioNomeSession());
                    return View(clienteviewmodel);
            }

        }
        public IActionResult CriarEvento()
        {
            switch(ObterUsuarioNomeSession())
            {
                case "Admin":
                    return RedirectToAction("Dashboard","Administrador");
                case "":
                    return RedirectToAction("index","Home");
                default:
                    ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
                    return View(clienteviewmodel);
            }


        }
        public IActionResult Logoff()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            return RedirectToAction("index","Home");
        }
        [HttpPost]
        public IActionResult CriarEvento(IFormCollection form)
        {
            try
            {
                Evento evento = new Evento(
                    form["NomeDoEvento"],
                    DateTime.Parse(form["DataDoEvento"]),
                    form["Pacote"],
                    int.Parse(form["QuantidadeDePessoas"])
                );
                evento.DonoDoEvento = ObterUsuarioNomeSession();
                eventorepository.Inserir(evento);
                
                return RedirectToAction("index","Cliente");
                

            }catch(Exception e)
            {
                return View("Fracasso");
            }
        }
    }
}
