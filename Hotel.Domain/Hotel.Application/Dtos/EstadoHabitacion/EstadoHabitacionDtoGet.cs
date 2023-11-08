using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Application.Dtos.EstadoHabitacion
{
    public class EstadoHabitacionDtoGet
    {
        public int IdEstadoHabitacion { get; set; }
        public string? Descripcion { get; set; }
    }
}
