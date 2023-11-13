using System;
using System.Collections.Generic;

namespace LibreriaExamen.Models;

public partial class Libro
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Chapters { get; set; }

    public int Pages { get; set; }

    public decimal Price { get; set; }

    public int AutorId { get; set; }

    public virtual Autore? Autor { get; set; } = null!;
}
