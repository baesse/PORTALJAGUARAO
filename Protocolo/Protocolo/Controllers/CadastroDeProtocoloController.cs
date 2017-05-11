using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Protocolo.Controllers
{
    public class CadastroDeProtocoloController : Controller
    {
        // GET: CadastroDeProtocolo
        public ActionResult Cadastrar()
        {
            return View();
        }

        public void InseriProtocolo(FormCollection protocolo)
        {


            String protocolobusca = protocolo["protocolo"];
            string pt = "";
            string ano = "";
            bool barra = true;

            for (int i = 0; i < protocolobusca.Length; i++)
            {
                if (protocolobusca[i] != '/' && barra)
                {
                    pt = pt + protocolobusca[i];

                }
                else
                {
                    ano = ano + protocolobusca[i];
                    barra = false;

                }
            }


            Models.Protocolo PROTOCOLO = new Models.Protocolo() {

                protocolo = Convert.ToInt32(pt),
                ano =ano.Replace("/",""),
            };

            Models.Protocolo.InserirProtocolo(PROTOCOLO);
            

        }
    }
}