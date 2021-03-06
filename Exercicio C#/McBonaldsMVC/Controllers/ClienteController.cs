using System;
using McBonaldsMVC.Enums;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class ClienteController : AbstractController
    {
        // private const string SESSION_CLIENTE_EMAIL = "cliente_email";
        private ClienteRepository clienteRepository = new ClienteRepository();
        private PedidoRepository pedidoRepository = new PedidoRepository();
        [HttpGet]
        public IActionResult Login()       /*IActionResult  para mostrar a pag "return View();"*/
        {
            return View(new BaseViewModel()
            {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ViewData["Action"] = "Login";
            try
            {
                System.Console.WriteLine("=================");
                System.Console.WriteLine(form["email"]);
                System.Console.WriteLine(form["senha"]);
                System.Console.WriteLine("=================");

                var usuario = (form["email"]);                  /*P/ hacer login del usuario */
                var senha = (form["senha"]);

                var cliente = clienteRepository.ObterPor(usuario);

                if (cliente != null)                            /*Comecou daqui 21/11 */
                {
                    if(cliente.Senha.Equals(senha))
                    {
                        switch (cliente.TipoUsuario)
                            
                        {
                            case (uint) TipoUsuario.CLIENTE:
                            HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                            HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                            HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());
                            return RedirectToAction("Historico", "Cliente");

                            default:
                            HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                            HttpContext.Session.SetString(SESSION_CLIENTE_NOME, usuario);
                            HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());
                            return RedirectToAction("Dashboard", "Administrador");
                        }
                        
                    }
                    else
                    {
                        return View("Erro", new RespostaViewModels("Senha incorreta"));
                    }
                }
                else
                {
                    return View("Erro", new RespostaViewModels($"Usuario {usuario} não encontrado"));
                }

                
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);     /*p/  tirar o erro "e" */
                return View ("Erro", new RespostaViewModels()
                {
                    NomeView="Login",
                    UsuarioEmail=ObterUsuarioSession(),
                    UsuarioNome= ObterUsuarioNomeSession(),

                });
            }


        }

        public IActionResult Historico ()                                               /*Foi criado 21/11 hacer login */
        {
            var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var pedidosCliente = pedidoRepository.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
                Pedidos = pedidosCliente,
                NomeView = "Historico",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        public IActionResult Logoff()       /*27/11 */
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();             /*P/ encerrar a sessao */
            return RedirectToAction("Index", "Home");
        }
    }
}