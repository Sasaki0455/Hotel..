using Hotel.Application.Core;
using Hotel.Application.Dtos.Habitacion;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Application.Contracts
{
    public interface IHabitacionService : IBaseServices<HabitacionDtoAdd, HabitacionDtoUpdate, HabitacionDtoRemove>
    {
        
    }
}
