using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using McBonaldsMVC.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers {
    public class PedidoController : AbstractController /*Para Criar um pedido no MVC */ {
        // private const string SESSION_EMAIL_CLIENTE = "cliente_email";
        // PedidoViewModel pedidoViewModel = new PedidoViewModel();
        ClienteRepository clienteRepository = new ClienteRepository ();
        PedidoRepository pedidoRepository = new PedidoRepository ();
        HamburguerRepository hamburguerRepository = new HamburguerRepository (); /*Preco dos hamburguer */
        ShakeRepository shakeRepository = new ShakeRepository (); /*Preco dos shake */

        public IActionResult Index () {
            PedidoViewModel pvm = new PedidoViewModel ();
            pvm.Hamburgueres = hamburguerRepository.ObterTodos (); /*devolver lista */
            pvm.Shakes = shakeRepository.ObterTodos ();

            var emailCliente = ObterUsuarioSession();
            if (!string.IsNullOrEmpty (emailCliente)) {
                pvm.Cliente = clienteRepository.ObterPor (emailCliente);

            }

            var nomeUsuario = ObterUsuarioNomeSession ();
            if (!string.IsNullOrEmpty (nomeUsuario)) {
                pvm.NomeCliente = nomeUsuario;
            }
            
            pvm.NomeView = "Pedido";
            pvm.UsuarioEmail = ObterUsuarioSession();
            pvm.UsuarioNome = ObterUsuarioNomeSession();

            // clienteRepository.ObterPor();

            return View (pvm);
        }

        public IActionResult Registrar (IFormCollection form) {
            ViewData["Action"] = "Pedido";

            Pedido pedido = new Pedido ();

            // Shake shake = new Shake();
            // shake.Nome = form["shake"];
            // shake.Preco = 0.0;

            // pedido.Shake = shake;

            var nomeHamburguer = form["hamburguer"]; /*Para pegar o preço do produto */
            Hamburguer hamburguer = new Hamburguer (
                nomeHamburguer,
                hamburguerRepository.ObterPrecode (nomeHamburguer));

            pedido.Hamburguer = hamburguer;
            // hamburguer.Nome = form["hamburguer"];
            // hamburguer.Preco = 0.0;

            var nomeShake = form["shake"]; /*Para pegar o preço do produto */
            Shake shake = new Shake (
                nomeShake,
                shakeRepository.ObterPrecode (nomeShake));

            pedido.Shake = shake;

            Cliente cliente = new Cliente () {

                Nome = form["nome"],
                Endereco = form["endereco"],
                Telefone = form["telefone"],
                Email = form["email"],
            };

            pedido.Cliente = cliente;

            pedido.DateDoPedido = DateTime.Now;

            pedido.PrecoTotal = hamburguer.Preco + shake.Preco;

            if (pedidoRepository.Inserir (pedido)) {
                return View ("Sucesso", new RespostaViewModels("Sucesso") {
                    NomeView = "Cadastro",
                    UsuarioNome = ObterUsuarioNomeSession(),
                    UsuarioEmail = ObterUsuarioSession()
                });

            } else {
                return View ("Sucesso", new RespostaViewModels("Erro") {
                    NomeView = "Cadastro",
                    UsuarioNome = ObterUsuarioNomeSession(),
                    UsuarioEmail = ObterUsuarioSession()
                });
        }
    }

        public IActionResult Aprovar (ulong id)
        {
            var pedido = pedidoRepository.ObterPor(id);

            pedido.Status = (uint) StatusPedido.APROVADO;

            if(pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModels("Não foi possivel reprovado este pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }
         public IActionResult Reprovar (ulong id)
        {
            var pedido = pedidoRepository.ObterPor(id);

            pedido.Status = (uint) StatusPedido.REPROVADO;

            if(pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModels("Não foi possivel reprovado este pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }
}
}