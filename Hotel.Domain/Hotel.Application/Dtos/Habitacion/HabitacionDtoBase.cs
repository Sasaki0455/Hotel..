using Hotel.Application.Dtos.EstadoHabitacion;
using System;


namespace Hotel.Application.Dtos.Habitacion
{
    public class HabitacionDtoBase : DtoBase
    {
        public string? Numero { get; set; }
        public string? Detalle { get; set; }
        public decimal Precio { get; set; }

        public int IdEstadoHabitacion { get; set; }
        public int IdPiso { get; set; }
        public int IdCategoria { get; set; }
    }
}
