using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data.Entity
{
    public class Cita : EntityBase
    {
        [Required(ErrorMessage = "La persona es obligatorio.")]
        public int IdPersona { get; set; }
        public Persona Persona { get; set; }

        
         public List<Persona> Personas { get; set; }
    }
}
