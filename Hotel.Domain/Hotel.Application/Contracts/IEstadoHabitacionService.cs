using Hotel.Application.Core;
using Hotel.Application.Dtos.EstadoHabitacion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Application.Contracts
{
    public interface IEstadoHabitacionService : IBaseServices<EstadoHabitacionDtoAdd, EstadoHabitacionDtoUpdate, EstadoHabitacionDtoRemove>
    {
       
    }
}
