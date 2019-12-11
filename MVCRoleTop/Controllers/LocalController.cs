using Microsoft.AspNetCore.Mvc;
using MVCRoleTop.ViewModel;

namespace MVCRoleTop.Controllers
{
    public class LocalController : AbstractController
    {
        public IActionResult Index()
        {
            ClienteViewModel clienteviewmodel = new ClienteViewModel(ObterUsuarioNomeSession());
            return View(clienteviewmodel);
        }
    }
}