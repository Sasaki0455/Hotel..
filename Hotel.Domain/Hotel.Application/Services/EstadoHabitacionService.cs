using Hotel.Application.Contracts;
using Hotel.Application.Core;
using Hotel.Application.Dtos.EstadoHabitacion;
using Hotel.Domain.Entities;
using Hotel.Infrastructure.Interfaces;
using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Application.Services
{
    public class EstadoHabitacionService : IEstadoHabitacionService
    {
        private readonly IEstadoHabitacion estadoHabitacionRepository;
        private readonly ILogger<EstadoHabitacionService> logger;

        public EstadoHabitacionService(IEstadoHabitacion estadoHabitacionRepository,ILogger<EstadoHabitacionService> logger)  {
            this.estadoHabitacionRepository = estadoHabitacionRepository;
            this.logger = logger;
        }

        public ServiceResult GetAll()
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult Remove(EstadoHabitacionDtoRemove dtoRemove)
        {
            ServiceResult result = new ServiceResult();

            try

            {
                EstadoHabitacion EstadoHabitacion = new EstadoHabitacion()
                {
                    IdEstadoHabitacion = dtoRemove.IdEstadoHabitacion,
                    Eliminado = dtoRemove.Eliminado,
                    IdUsuarioElimino = dtoRemove.IdUsuarioElimino

                };
                this.estadoHabitacionRepository.Remove(EstadoHabitacion);

                result.Message = "El EstadoHabitacion fue removida";
            }

            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Error Removido del EstadoHabitacion";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult Save(EstadoHabitacionDtoAdd dtoAdd)
        {
            {
                ServiceResult result = new ServiceResult();

                try

                {
                    EstadoHabitacion EstadoHabitacion = new EstadoHabitacion()
                    {
                        Descripcion  = dtoAdd.Descripcion,
                        FechaCreacion = dtoAdd.ChanageDate,
                        IdUsuarioCreacion = dtoAdd.ChangeUser

                    };
                    this.estadoHabitacionRepository.Save(EstadoHabitacion);

                    result.Message = "El EstadoHabitacion fue guardado";
                }

                catch (Exception ex)
                {
                    result.Success = false;
                    result.Message = $"Error guardado del EstadoHabitacion";
                    this.logger.LogError($"{result.Message}", ex.ToString());
                }
                return result;
            }
        }

        public ServiceResult Update(EstadoHabitacionDtoUpdate dtoUpdate)
        {
            {
                ServiceResult result = new ServiceResult();

                try

                {
                    EstadoHabitacion EstadoHabitacion = new EstadoHabitacion()
                    {
                        IdEstadoHabitacion = dtoUpdate.IdEstadoHabitacion,
                        FechaMod = dtoUpdate.ChanageDate,
                        IdUsuarioMod = dtoUpdate.ChangeUser,
                        Descripcion = dtoUpdate.Descripcion
                        


                    };
                    this.estadoHabitacionRepository.Update(EstadoHabitacion);

                    result.Message = "El EstadoHabitacion fue Actualizado";
                }

                catch (Exception ex)
                {
                    result.Success = false;
                    result.Message = $"Error Actualizado del EstadoHabitacion";
                    this.logger.LogError($"{result.Message}", ex.ToString());
                }
                return result;
            }
        }
    }

        
    
}
