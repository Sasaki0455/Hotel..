using Hotel.Domain.Entities;
using Hotel.Infrastructure.Context;
using Hotel.Infrastructure.Core;
using Hotel.Infrastructure.Interfaces;
using Hotel.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Hotel.Infrastructure.Repositories
{
    public class HabitacionRepository :BaseRepository <Habitacion>,IHabitacion
    {
        private readonly Hotelcontex context;

        public HabitacionRepository(Hotelcontex context) : base (context) 
        {
            this.context = context;
        }

        public List<Habitacion> GetHabitacionByCategoriaId(int categoriaId)
        {
            throw new NotImplementedException();
        }

        public List<Habitacion> GetHabitacionByEstadoHabitacionId(int estadohabitacionId)
        {
            throw new NotImplementedException();
        }

        public List<Habitacion> GetHabitacionByPisoId(int pisoId)
        {
            throw new NotImplementedException();
        }

        public List<HabitacionEstadoHabitacionModel> GetHabitacionEstadoHabitacionModel()
        {
            var Habitaciones = (from co in this.GetEntities()
                                join Etho in this.context.EstadoHabitacion on co.IdEstadoHabitacion equals Etho.IdEstadoHabitacion
                                where !co.Eliminado
                                select new HabitacionEstadoHabitacionModel()
                                {

                                    IdHabitacion = co.IdHabitacion,
                                    Numero = co.Numero,
                                    Detalle = co.Detalle,
                                    Precio = co.Precio,
                                    IdEstadoHabitacion = co.IdEstadoHabitacion,
                                    EstadoHabitacion = Etho.Descripcion,
                                    IdPiso = co.IdPiso,
                                    IdCategoria = co.IdCategoria,
                                    FechaCreacion = co.FechaCreacion



                                }).ToList();
            return Habitaciones;
        }

        

        public override void Save(Habitacion entity)
        {
            context.Habitacion.Add(entity);
            context.SaveChanges();
        }
        public override void Update(Habitacion entity)
        {
            var HabitacionToUpdate = base.GetEntity(entity.IdHabitacion);
            HabitacionToUpdate.Estado = entity.Estado;
            HabitacionToUpdate.Detalle = entity.Detalle;
            HabitacionToUpdate.Numero= entity.Numero;
            HabitacionToUpdate.Precio= entity.Precio;
            HabitacionToUpdate.FechaMod= entity.FechaMod;
            HabitacionToUpdate.IdUsuarioMod = entity.IdUsuarioMod;

            context.Habitacion.Update(HabitacionToUpdate);
            context.SaveChanges();

        }
        public override void Remove(Habitacion entity)
        {
            Habitacion Habitacion  = this.GetEntity(entity.IdHabitacion);

            Habitacion.IdHabitacion = entity.IdHabitacion;
            Habitacion.Eliminado = entity.Eliminado;
            Habitacion.FechaElimino = entity.FechaElimino;
            Habitacion.IdUsuarioElimino = entity.IdUsuarioElimino;

            this.context.Habitacion.Update(Habitacion);
            this.context.SaveChanges();
            

                    
        }

        List<HabitacionEstadoHabitacionModel> IHabitacion.GetHabitacionByEstadoHabitacionId(int estadohabitacionId)
        {
            throw new NotImplementedException();
        }
    }
}
