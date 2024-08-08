using Microsoft.AspNetCore.Mvc;
using MVC_Proyecto.Models;

namespace MVC_Proyecto.Controllers
{
    public class AhorcadoController : Controller
    {
        Ahorcado model = new Ahorcado();
        static List<string> palabras = new List<string>
        {
            "Elefante",
            "Mariposa",
            "Bibliotecario",
            "Helicóptero",
            "Alpinismo",
            "Crocodilo",
            "Astronauta"
        };

        public bool HaFallado;
        public int Fallos = 5;

        [HttpGet]

        public IActionResult Index()
        {
            model.PalabraSecreta = GetPalabraRandom();

            foreach (var key in model.PalabraSecreta)
            {
                model.Palabra += "_ ";
            }

            return View(model);
        }

        private string GetPalabraRandom()
        {
            Random rnd = new Random();

            return palabras[rnd.Next(0, palabras.Count)];
        }

        [HttpPost]

        public string ProbarLetra(char palabra)
        {
            int i = 0;
            foreach(char key in model.PalabraSecreta)
            {
                if(key == palabra) 
                {
                    model.Palabra[i] = palabra;
                }
                i++;
            }

            return model.Palabra; 

        }
    }
}
