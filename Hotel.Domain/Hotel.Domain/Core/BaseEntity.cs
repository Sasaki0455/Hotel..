using System;


namespace Hotel.Domain.Core
{
    public abstract class BaseEntity
    {
        public bool Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }


        public DateTime? FechaRegistro { get; set; }

        public int? IdUsuarioCreacion { get; set; }

        public DateTime? FechaMod { get; set; }

        public int? IdUsuarioMod { get; set; }

        public int? IdUsuarioElimino { get; set; }

        public DateTime? FechaElimino { get; set; }

        public bool Eliminado { get; set; }   
    }
}
