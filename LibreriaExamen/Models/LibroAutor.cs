using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExamen.Models
{
    public class LibroAutor
    {
        public string libroTitle { get; set; } = null;

        public string NameAutor { get; set; } = null;

        public int LibroCapítulos { get; set; }

        public int LibroPáginas { get; set; }

        public decimal LibroPrecio { get; set; }

    }
}
