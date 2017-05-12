using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Protocolo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }


        public void Logar(FormCollection usuario)
        {
            string user = usuario["usuario"];

            string senha = usuario["senha"];

            string result=Models.Usuario.Logar(user, senha);

            if(result!= "Usario não encotrado") {

                ViewBag.usuario = "Valido";

                
                // Response.Redirect(@"~\CadastroDeProtocolo/Cadastrar");
                 Response.Redirect(@"~\CadastroDeProtocolo\Cadastrar");


            }
            else
            {
               
            }
          

        }


       
    }
}