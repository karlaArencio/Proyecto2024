using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2024.BD.Data.Entity
{


    [Index(nameof(Codigo), Name = "Usuario_UQ", IsUnique = true)]
    public class Usuario : EntityBase
    {
        [Required(ErrorMessage = "El codigo de usuario es obligatorio.")]
        [MaxLength(150, ErrorMessage = "Maximo numero de caracteres {1}.")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es obligatori.")]
        [MaxLength(150, ErrorMessage = "Maximo numero de caracteres {1}.")]

        public string Nombre { get; set; }
    }
}
