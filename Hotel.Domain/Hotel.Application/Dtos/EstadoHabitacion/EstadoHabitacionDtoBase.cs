using System;


namespace Hotel.Application.Dtos.EstadoHabitacion
{
    public abstract class EstadoHabitacionDtoBase : DtoBase
    {
        public string? Descripcion { get; set; }
    }
}
