using System;
using System.Collections.Generic;

namespace LibreriaExamen.Models;

public partial class Autore
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Libro>? Libros { get; set; } = new List<Libro>();
}
