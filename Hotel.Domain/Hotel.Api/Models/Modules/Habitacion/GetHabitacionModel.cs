namespace Hotel.Api.Models.Modules.Habitacion
{
    public class GetHabitacionModel
    {
        public int HabitacionId { get; set; }
        public bool Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string? Numero { get; set; }
        public decimal Precio { get; set; }
        public int IdEstadoHabitacion { get; set;}
        public int IdPiso { get; set; }
        public int IdCategoria { get; set; }
    }
}
