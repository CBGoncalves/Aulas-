using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTopOficial.Models;
using RoleTopOficial.Repositories;
using RoleTopOficial.ViewModel;

namespace RoleTopOficial.Controllers
{
    public class AdministradorController : AbstractController
    {
        EventoRepository eventorepository = new EventoRepository();
        
        public IActionResult Dashboard()
        {
            switch(ObterUsuarioNomeSession())
            {
                case "Administrador":
                    ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
                    clienteviewmodel.Eventos = eventorepository.ObterTodosEventosPendentes();
                    return View(clienteviewmodel);
                default:
                    return RedirectToAction("index","Home");
            }

        }
        
        [HttpPost]
        public IActionResult Aprovar(IFormCollection form)
        {
            eventorepository.Aprovar( form["ID"] );
            return RedirectToAction("dashboard","Administrador");
        }

        [HttpPost]
        public IActionResult Cancelar(IFormCollection form)
        {
            eventorepository.Cancelar( form["ID"] );
            return RedirectToAction("dashboard","Administrador");
        }


    }
}
