﻿namespace Enumerable.UI.Consola
{
    public class Productos
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{Nombre}\t{Precio:C2}";
        }

    }
}