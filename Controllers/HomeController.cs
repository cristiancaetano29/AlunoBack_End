using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoEscola_API.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        /*public String Inicio() {
            return "Api Rodando!";
        }*/
        public ActionResult Inicio(){
            return new ContentResult{
                ContentType = "text/html",
                Content = "<h1>Api De Teste Funcionando!!!</h1>"
            };
        }
    }
}