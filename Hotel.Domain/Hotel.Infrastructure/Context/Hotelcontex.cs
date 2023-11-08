

using Hotel.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Hotel.Infrastructure.Context
{
    public class Hotelcontex : DbContext
    {
        public Hotelcontex(DbContextOptions<Hotelcontex> options) : base(options) { }

        public DbSet <EstadoHabitacion> EstadoHabitacion { get;set; }

        public DbSet<Habitacion> Habitacion { get; set; }
        public object EstadoHabitaciones { get; internal set; }

      
    }
}
