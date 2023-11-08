using Hotel.Application.Contracts;
using Hotel.Application.Core;
using Hotel.Application.Dtos.Habitacion;
using Hotel.Domain.Entities;
using Hotel.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Hotel.Application.Services
{
    public class HabitacionService : IHabitacionService
    {
        private readonly IHabitacion habitacionRepository;
        
        private readonly ILogger<HabitacionService> logger;

        public HabitacionService(IHabitacion habitacionRepository,ILogger<HabitacionService> logger) {
            this.habitacionRepository = habitacionRepository;
           
            this.logger = logger;
        }

        public ServiceResult GetAll()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = habitacionRepository.GetHabitacionEstadoHabitacionModel();
            }
            catch (Exception ex) {

                result.Success = false;
                result.Message = $"Error obteniendo las habitaciones";
                this.logger.LogError($"{result.Message }", ex.ToString());
            }
            return result;
        }

        public ServiceResult GetById(int Id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = habitacionRepository.GetHabitacionEstadoHabitacionModel();
            }

            catch (Exception ex) {
                result.Success = false;
                result.Message = $"Error obteniendo la habitacion";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult Remove(HabitacionDtoRemove dtoRemove)
        {
            ServiceResult result = new ServiceResult();

            try
               
            {
                Habitacion Habitacion = new Habitacion()
                {
                  IdHabitacion = dtoRemove.IdHabitacion,
                  Eliminado = dtoRemove.Eliminado,
                  IdUsuarioElimino = dtoRemove.IdUsuarioElimino 

                };
                 this.habitacionRepository.Remove(Habitacion);

                result.Message = "La Habitacion fue removida";
            }

            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error Removido la Habitacion";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }


        public ServiceResult Save(HabitacionDtoAdd dtoAdd)
        {
            ServiceResult result = new ServiceResult();

            try

            {
                Habitacion Habitacion = new Habitacion()
                {
                FechaCreacion = dtoAdd.ChanageDate,
                Numero = dtoAdd.Numero, 
                 Precio = dtoAdd.Precio,
               IdEstadoHabitacion = dtoAdd.IdEstadoHabitacion,
                IdPiso = dtoAdd.IdPiso,
               IdCategoria = dtoAdd.IdCategoria,
                IdUsuarioCreacion = dtoAdd.ChangeUser


    };
                this.habitacionRepository.Save(Habitacion);
                result.Message = "La Habitacion fue guardada correctamente";

            }

            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error guardando la Habitacion";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;

        }

        public ServiceResult Update(HabitacionDtoUpdate dtoUpdate)
        {
            {
                ServiceResult result = new ServiceResult();

                try

                {
                    Habitacion Habitacion = new Habitacion()
                    {
                        FechaMod = dtoUpdate.ChanageDate,
                        Numero = dtoUpdate.Numero,
                        Precio = dtoUpdate.Precio,
                        IdEstadoHabitacion = dtoUpdate.IdEstadoHabitacion,
                        IdPiso = dtoUpdate.IdPiso,
                        IdCategoria = dtoUpdate.IdCategoria,
                        IdUsuarioMod = dtoUpdate.ChangeUser


                    };
                    this.habitacionRepository.Update(Habitacion);
                    result.Message = "La Habitacion fue Actualizada correctamente";

                }

                catch (Exception ex)
                {
                    result.Success = false;
                    result.Message = $"Error Actualizando la habitacion";
                    this.logger.LogError($"{result.Message}", ex.ToString());
                }
                return result;

            }
        }
    }
}
