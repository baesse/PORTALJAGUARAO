using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Protocolo.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult ConsultarProtocolo(FormCollection protocolo)
        {
            String protocolobusca = protocolo["protocolo"];
            string pt = "";
            string ano = "";
            bool barra = true;

            for(int i = 0; i < protocolobusca.Length; i++)
            {
                if (protocolobusca[i] != '/' && barra)
                {
                    pt = pt + protocolobusca[i];
                    
                }else
                {
                    ano = ano + protocolobusca[i];
                    barra = false;

                }
            }

            if (Models.Protocolo.BuscarProtocolo(pt, ano.Replace("/",""))){

                @ViewBag.messagem = "Protocolo concluido";
                return View("Index");

            }else
            {
                ViewBag.messagem = "Protocolo ainda não concluido";
                return View("Index");

            }          

        }
        public ActionResult Index()
        {
            
            return View();

        }

        public ActionResult ConsultarValores(FormCollection valor)
        {
            int quant =Convert.ToInt32( valor["quantidade"]);

            Decimal valorfinal = Convert.ToDecimal(quant * 32.10);
            ViewBag.valor = "VALOR Total: R$"+" "+valorfinal;

            return View("Index");

            

        }



    }
}