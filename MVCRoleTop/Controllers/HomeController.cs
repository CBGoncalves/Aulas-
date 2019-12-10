using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoleTopOficial.Models;
using RoleTopOficial.ViewModel;

namespace RoleTopOficial.Controllers
{
    public class HomeController : AbstractController
    {
        public IActionResult Index()
        {
            ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
            return View(clienteviewmodel);
        }

    }
}
