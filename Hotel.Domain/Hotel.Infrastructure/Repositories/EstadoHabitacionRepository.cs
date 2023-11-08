

using Hotel.Domain.Entities;
using Hotel.Infrastructure.Context;
using Hotel.Infrastructure.Core;
using Hotel.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Hotel.Infrastructure.Repositories
{
    public class EstadoHabitacionRepository : BaseRepository <EstadoHabitacion>, IEstadoHabitacion
    {
        private readonly Hotelcontex context;

        public EstadoHabitacionRepository(Hotelcontex context) : base(context)
        {
            this.context = context;
        }

        public override void Save(EstadoHabitacion entity)
        {
            context.EstadoHabitacion.Add(entity);
            context.SaveChanges();
        }
        public override void Update(EstadoHabitacion entity)
        {
            var EstadoHabitacionToUpdate = base.GetEntity(entity.IdEstadoHabitacion);
            EstadoHabitacionToUpdate .Descripcion = entity.Descripcion;
            EstadoHabitacionToUpdate.Estado = entity.Estado;
            EstadoHabitacionToUpdate.FechaMod = entity.FechaMod;
            EstadoHabitacionToUpdate.IdUsuarioMod = entity.IdUsuarioMod;

            context.EstadoHabitacion. Update(EstadoHabitacionToUpdate);
            context.SaveChanges();
        }


        public override void Remove(EstadoHabitacion entity)
        {
          
        {
            EstadoHabitacion EstadoHabitacion = this.GetEntity(entity.IdEstadoHabitacion);

            EstadoHabitacion.IdEstadoHabitacion = entity.IdEstadoHabitacion;
            EstadoHabitacion.Eliminado = entity.Eliminado;
            EstadoHabitacion.FechaElimino = entity.FechaElimino;
            EstadoHabitacion.IdUsuarioElimino = entity.IdUsuarioElimino;

            this.context.EstadoHabitacion.Update(EstadoHabitacion);
            this.context.SaveChanges();
        }

    }

    }


}
