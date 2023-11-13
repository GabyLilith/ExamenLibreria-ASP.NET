using LibreriaExamen.Models;
using LibreriaExamen.Operaciones;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIWEB.Controllers
{
    [Route("api")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private LibroDAO libroDAO = new LibroDAO();

        [HttpPost("libro")]
        public bool agregarlibro(Libro libro)
        {
            return libroDAO.InsertarLibro(libro.Title, libro.Chapters, libro.Pages, libro.Price, libro.AutorId);
        }

        [HttpGet("todoslibros")] 
        public List<Libro> GetLibroList()
        {
            return libroDAO.seleccionarTodos();
        }

        [HttpGet("idlibro")]
        public Libro GetLibro(int id)
        {
            return libroDAO.seleccionar(id);
        }

        [HttpGet("autorlibro")]
        public List<LibroAutor> LibroAutorList()
        {
            return libroDAO.libroAutors();
        }

    }
}
