using Hotel.Domain.Entities;
using Hotel.Domain.Repository;
using Hotel.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Hotel.Infrastructure.Interfaces
{
    public interface IHabitacion: IBaseRepository<Habitacion>
    {
      List<HabitacionEstadoHabitacionModel> GetHabitacionByEstadoHabitacionId(int estadohabitacionId);
        
        List<HabitacionEstadoHabitacionModel> GetHabitacionEstadoHabitacionModel();





        List<Habitacion> GetHabitacionByPisoId(int pisoId);
      List<Habitacion> GetHabitacionByCategoriaId(int categoriaId);


    }

}
