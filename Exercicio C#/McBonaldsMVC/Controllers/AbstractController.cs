using Microsoft.AspNetCore.Http;                /*22/11 criado */
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class AbstractController : Controller
    {
        protected const string SESSION_CLIENTE_EMAIL = "email_cliente";
        protected const string SESSION_CLIENTE_NOME = "nome_cliente";

        protected const string SESSION_CLIENTE_TIPO = "cliente_tipo";

        protected string ObterUsuarioSession()
        {
            var usuario = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            if(!string.IsNullOrEmpty(usuario))
            {
                return usuario;
            }
            else
            {
                return "";
            }

        }

        protected string ObterUsuarioNomeSession()
        {
            var nomeusuario = HttpContext.Session.GetString(SESSION_CLIENTE_NOME);
            if(!string.IsNullOrEmpty(nomeusuario))
            {
                return nomeusuario;
            }
            else
            {
                return "";
            }

        }


        protected string ObterUsuarioTipoSession()
        {
            var tipousuario = HttpContext.Session.GetString(SESSION_CLIENTE_TIPO);
            if(!string.IsNullOrEmpty(tipousuario))
            {
                return tipousuario;
            }
            else
            {
                return "";
            }

        }

    }
}