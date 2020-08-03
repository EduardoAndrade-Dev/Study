using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEntityFramework.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El Nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Teléfono es obligatorio")]
        [Display(Name ="Teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El Celular es obligatorio")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "El Email es obligatorio")]
        public string Email { get; set; }
    }
}
