using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCRoleTop.Models;
using MVCRoleTop.ViewModel;

namespace MVCRoleTop.Controllers
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
