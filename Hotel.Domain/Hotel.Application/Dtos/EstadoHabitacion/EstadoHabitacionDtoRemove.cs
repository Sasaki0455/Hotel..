using System;


namespace Hotel.Application.Dtos.EstadoHabitacion
{
    public class EstadoHabitacionDtoRemove : DtoBase
    {
        public int IdEstadoHabitacion { get; set; }
        
        public int? IdUsuarioElimino { get; set; }

        public bool Eliminado { get; set; }



    }
}
