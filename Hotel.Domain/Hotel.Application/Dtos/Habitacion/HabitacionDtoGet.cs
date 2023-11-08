using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Application.Dtos.Habitacion
{
    public class HabitacionDtoGet
    {
        public int IdHabitacion { get; set; }
        public string? Numero { get; set; }
        public string? Detalle { get; set; }
        public decimal Precio { get; set; }

        public int IdEstadoHabitacion { get; set; }

        public string? EstadoHabitacion { get; set; }
        public int IdPiso { get; set; }
        public string? Piso { get; set; }
        public int IdCategoria { get; set; }
        public string? Categoria { get;set;}

        public DateTime? FechaCreacion { get; set; }
    }
}
