using Hotel.Domain.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hotel.Domain.Entities
{
    public  class EstadoHabitacion: BaseEntity
    {
        [Key]
        public int IdEstadoHabitacion { get; set; }
      public string? Descripcion { get; set; }

    }
}
