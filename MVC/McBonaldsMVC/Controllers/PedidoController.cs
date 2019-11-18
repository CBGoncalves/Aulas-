using System;
using McBonalds_MVC.Models;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class PedidoController : Controller
    {

        PedidoRepository pedidoRepository = new PedidoRepository();
        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        ShakeRepository shakeRepository = new ShakeRepository();
        
        public IActionResult Index()
        {
            var hamburgueres = hamburguerRepository.ObterTodos();

            PedidoViewModel pedido = new PedidoViewModel();

            pedido.Hamburgueres = hamburgueres;

            var shakes = shakeRepository.ObterTodos();

            pedido.Shakes = shakes;
            
            return View(pedido);
        }

        public IActionResult Registrar(IFormCollection form)
        {
            Pedido pedido = new Pedido();
            
            Shake shake = new Shake();
            shake.Nome = form["shake"];
            shake.Preco = shakeRepository.ObterPrecoDe(form["shake"]);

            pedido.Shake = shake;

            Hamburguer hamburguer = new Hamburguer (form["hamburguer"], hamburguerRepository.ObterPrecoDe(form["hamburguer"]));

            pedido.Hamburguer = hamburguer;

            Cliente cliente = new Cliente()
            {
                Nome = form["nome"],
                Endereco = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"]
            };

            pedido.Cliente = cliente;

            pedido.DataDoPedido = DateTime.Now;

            pedido.PrecoTotal = hamburguer.Preco + shake.Preco;

            pedidoRepository.Inserir(pedido);
            
            return View("Sucesso");
        }

    }
}