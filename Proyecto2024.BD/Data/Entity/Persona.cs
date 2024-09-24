using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data.Entity
{

    [Index(nameof(IdRegistro), nameof(NumDoc), Name = "Persona_UQ", IsUnique = true)]
    [Index(nameof(Apellido), nameof(Nombre), Name = "Persona_Apellido_Nombre", IsUnique = false)]
    public class Persona : EntityBase
    {
        [Required(ErrorMessage = "El numero de documento es obligatorio.")]
        [MaxLength(12, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string NumDoc { get; set; }

        [Required(ErrorMessage = "El nombre de la persona es obligatorio.")]
        [MaxLength(150, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido de la persona es obligatorio.")]
        [MaxLength(150,ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La direccion de la persona es obligatorio.")]
        [MaxLength(150, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El telefono de la persona es obligatorio.")]
        [MaxLength(11, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "El correo de la persona es obligatorio.")]
        [MaxLength(150, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "La fecha_nac de la persona es obligatorio.")]
        [MaxLength(10, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public int Fecha_nac { get; set; }

        [Required(ErrorMessage = "El genero de la persona es obligatorio.")]
        [MaxLength(15, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Genero { get; set; }

       
        public int Fecha_registro { get; set; }

        [Required(ErrorMessage ="El registro de la persona es obligatorio.")]
        public int IdRegistro { get; set; }
        public Registro Registro { get; set; }

        public List<Cita> Citas { get; set; }
    }
}
