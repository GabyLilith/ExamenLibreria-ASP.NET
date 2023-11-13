using LibreriaExamen.Models;
using LibreriaExamen.Operaciones;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWEB.Controllers
{
    [Route("api")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        private AutorDAO autorDAO = new AutorDAO();

        [HttpPost ("Autor")]
        public bool agregarAutor(Autore autor)
        {
            return autorDAO.CrearAutor(autor.Name);
        }

        [HttpGet("todosautores")]
        public List<Autore> ListaAutores()
        {
            return autorDAO.ObtenerTodosLosAutores();
        }

    }
}
