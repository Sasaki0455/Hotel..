namespace Hotel.Api.Core
{
    public abstract class HabitacionBaseModel : ModelBase
    {
        public string? Numero { get; set; }
        public string? Detalle { get; set; }
        public decimal Precio { get; set; }
        public bool Estado { get; set; }
        public int IdPiso { get; set; }
        public int IdCategoria { get; set; }
    }
}
