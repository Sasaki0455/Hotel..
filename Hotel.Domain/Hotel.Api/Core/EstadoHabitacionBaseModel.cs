namespace Hotel.Api.Core
{
    public abstract class  EstadoHabitacionBaseModel : ModelBase
    {
        public string? Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
