using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data.Entity
{

    [Index(nameof(Codigo), Name = "Registro_UQ", IsUnique= true)]
    public class Registro : EntityBase
    {
        public object Nombre { get; set; }

        [Required(ErrorMessage = "El codigo de registro es obligatorio.")]
        [MaxLength(150, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Codigo { get; set; }

        
        [MaxLength(150, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Fecha { get; set; }

        [Required(ErrorMessage = "El estado del registro es obligatorio.")]
        [MaxLength(150, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Estado { get; set; }

        
 //       public List<Persona> Personas { get; set; } 
    }
}
