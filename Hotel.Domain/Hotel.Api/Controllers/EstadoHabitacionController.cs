using Hotel.Api.Models.Modules.EstadoHabitacion;
using Hotel.Domain.Entities;
using Hotel.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hotel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoHabitacionController : ControllerBase
    {
        private readonly IEstadoHabitacion EstadoHabitacionRepository;

        public EstadoHabitacionController(IEstadoHabitacion EstadoHabitacionRepository)
        {
            this.EstadoHabitacionRepository = EstadoHabitacionRepository;
        }
       
        [HttpGet("GetEstadoHabitacion")] 
        public IActionResult Get()
        {
            var EstadoHabitacion = this.EstadoHabitacionRepository.GetEntities().Select(st=>new GetEstadoHabitacionModel() { 
                                                                                                 EstadoHabitacionId = st.IdEstadoHabitacion,
                                                                                                 Descripcion = st.Descripcion,
                                                                                                 Estado = st.Estado,
                                                                                                 FechaCreacion = st.FechaCreacion

            
            
          
                                                                                                               });
            
            return Ok(EstadoHabitacion);
        }

        
        [HttpGet("GetEstadoHabitaciones")]
        public IActionResult Get(int id)
        {
            var EstadoHabitacion = this.EstadoHabitacionRepository.GetEntity(id);

            GetEstadoHabitacionModel EstadoHabitacionModel = new GetEstadoHabitacionModel()
            {
                EstadoHabitacionId= EstadoHabitacion.IdEstadoHabitacion,
                Descripcion = EstadoHabitacion.Descripcion,
                Estado= EstadoHabitacion.Estado,
                FechaCreacion = EstadoHabitacion.FechaCreacion
                

            };

            return Ok (EstadoHabitacion);
        }

        
        [HttpPost ("SaveEstadoHabitacion")]
        public IActionResult  Post([FromBody] EstadoHabitacionAppModel estadoHabitacionApp)
        {
            this.EstadoHabitacionRepository.Save(new EstadoHabitacion ()
            {
                FechaCreacion = estadoHabitacionApp.ChanageDate,
                IdUsuarioCreacion = estadoHabitacionApp.ChangeUser,
                Descripcion = estadoHabitacionApp.Descripcion,
                Estado = estadoHabitacionApp.Estado


            });

            return Ok();
        }

        
        [HttpPut("UpdateEstadoHabitacion")]
        public IActionResult Put(int id, [FromBody] EstadoHabitacionUpdateModel estadoHabitacionUpdate)
        {
            this.EstadoHabitacionRepository.Update(new EstadoHabitacion()
            {
                FechaMod = estadoHabitacionUpdate.ChanageDate,
                IdUsuarioMod = estadoHabitacionUpdate.ChangeUser,
                Descripcion = estadoHabitacionUpdate.Descripcion,
                Estado = estadoHabitacionUpdate.Estado,
                IdEstadoHabitacion = estadoHabitacionUpdate.Id

            });

            return Ok();
        }

        
    }
}
