using Hotel.Application.Dtos.EstadoHabitacion;
using System;

namespace Hotel.Application.Dtos.Habitacion
{
    public class HabitacionDtoRemove : DtoBase
    {
        public int IdHabitacion { get; set; }
        
        public int? IdUsuarioElimino { get; set; }
        public bool Eliminado { get; set; }

        
    }
}
