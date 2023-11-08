namespace Hotel.Api.Models.Modules.EstadoHabitacion
{
    public class GetEstadoHabitacionModel
    {
        public int EstadoHabitacionId { get; set; }
        public string? Descripcion { get; set; }
        public bool Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
