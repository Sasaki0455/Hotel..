using Hotel.Api.Models.Modules.EstadoHabitacion;
using Hotel.Api.Models.Modules.Habitacion;
using Hotel.Domain.Entities;
using Hotel.Infrastructure.Interfaces;
using Hotel.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hotel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HabitacionController : ControllerBase
    {
        private readonly IHabitacion HabitacionRepository;
        public HabitacionController(IHabitacion habitacionRepository)
        {
           this.HabitacionRepository = habitacionRepository;
        }

        
        [HttpGet ("GetHabitaciones")]
        public IActionResult Get()
        {
            var Habitacion = this.HabitacionRepository.GetEntities().Select(st => new GetHabitacionModel()
            {
                HabitacionId = st.IdHabitacion,
                Estado = st.Estado,
                FechaCreacion = st.FechaCreacion,
                Numero = st.Numero,
                Precio = st.Precio,
                IdEstadoHabitacion = st.IdEstadoHabitacion,     
                IdPiso = st.IdPiso,
                IdCategoria = st.IdCategoria

    });

            return Ok(Habitacion);


        }

        
        [HttpGet("GetHabitacion")]
        public IActionResult Get(int id)
        {
            var Habitacion = this.HabitacionRepository.GetEntity(id);

            GetHabitacionModel HabitacionModel = new GetHabitacionModel()
            {
                HabitacionId = Habitacion.IdHabitacion,
                Estado =  Habitacion.Estado,
                FechaCreacion = Habitacion.FechaCreacion,
                Numero = Habitacion.Numero,
                Precio = Habitacion.Precio,
                IdEstadoHabitacion = Habitacion.IdEstadoHabitacion,
                IdPiso = Habitacion.IdPiso,
                IdCategoria = Habitacion.IdCategoria


            };

            return Ok(Habitacion);
        }

        
        [HttpPost ("SaveHabitacion")]
        public IActionResult Post([FromBody] HabitacionAppModel habitacionApp)
        {
            this.HabitacionRepository.Save(new Habitacion()
            {
                FechaCreacion = habitacionApp.ChanageDate,
                IdUsuarioCreacion =habitacionApp.ChangeUser,
                Numero = habitacionApp.Numero,
                Detalle = habitacionApp.Detalle,
                Precio = habitacionApp.Precio,
                Estado = habitacionApp.Estado,
                IdPiso = habitacionApp.IdPiso,
                IdCategoria = habitacionApp.IdCategoria


            });

            return Ok();
        }

        
        [HttpPut("UpdateHabitacion")]
        public IActionResult Put(int id, [FromBody] HabitacionUpdateModel habitacionUpdate)
        {
            this.HabitacionRepository.Save(new Habitacion()
            {
                FechaMod = habitacionUpdate.ChanageDate,
                IdUsuarioMod = habitacionUpdate.ChangeUser,
                Numero = habitacionUpdate.Numero,
                Detalle = habitacionUpdate.Detalle,
                Precio = habitacionUpdate.Precio,
                Estado = habitacionUpdate.Estado,
                IdHabitacion = habitacionUpdate.Id,
                IdPiso = habitacionUpdate.IdPiso,
                IdCategoria = habitacionUpdate.IdCategoria


            });

            return Ok();

        }

        
        
    }
}
