using LibreriaExamen.Context;
using LibreriaExamen.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExamen.Operaciones
{
    public class AutorDAO
    {
        public LibreriaExamenContext contexto = new LibreriaExamenContext();


        public bool CrearAutor(string nombre)
        {
            try
            {
                // Verificar si el autor ya existe
                var autorExistente = contexto.Autores.Where(a => a.Name == nombre).FirstOrDefault();

                if (autorExistente == null)
                {
                    Autore nuevoAutor = new Autore();
                    nuevoAutor.Name = nombre;

                    contexto.Autores.Add(nuevoAutor);
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

        public List<Autore> ObtenerTodosLosAutores()
        {
            List<Autore> autores = contexto.Autores.ToList<Autore>();
            return autores;
        }
    }
}
