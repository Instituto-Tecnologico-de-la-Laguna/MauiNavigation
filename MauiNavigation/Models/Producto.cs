using System;
using System.Collections.Generic;
using System.Text;

namespace MauiNavigation.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }= string.Empty;
        public string Categoria { get; set; }=string.Empty;
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }=string.Empty;

        public string PrecioFormateado => $"${Precio:N2}";
    }
}
