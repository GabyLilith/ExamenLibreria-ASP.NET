using LibreriaExamen.Context;
using LibreriaExamen.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExamen.Operaciones
{
    public class LibroDAO
    {
        public LibreriaExamenContext contexto = new LibreriaExamenContext();

   
        public List<Libro> seleccionarTodos()
        {
            var libros = contexto.Libros.ToList<Libro>();
            return libros;
        }

        public Libro seleccionar(int id)
        {
            var libro = contexto.Libros.Where(a => a.Id == id).FirstOrDefault();
            return libro;
        }

        public bool InsertarLibro(string title, int chapters, int pages, decimal price, int autorid)
        {
            try
            {
                var autorEncontrado = contexto.Autores.Where(a => a.Id == autorid).FirstOrDefault();

                if (autorEncontrado != null)
                {
                    Libro libro = new Libro();
                    libro.Title = title;
                    libro.Chapters = chapters;
                    libro.Pages = pages;
                    libro.Price = price;
                    libro.AutorId = autorEncontrado.Id;

                    contexto.Libros.Add(libro);
                    contexto.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<LibroAutor> libroAutors() {
            var query = from l in contexto.Libros
                        join a in contexto.Autores on l.AutorId equals a.Id
                        select new LibroAutor
                        {
                            libroTitle = l.Title,
                            NameAutor = a.Name,
                            LibroCapítulos = l.Chapters,
                            LibroPáginas = l.Pages,
                            LibroPrecio = l.Price
                        };
            return query.ToList();
        }
    }
}
