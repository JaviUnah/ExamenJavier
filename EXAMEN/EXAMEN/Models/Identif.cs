using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EXAMEN.Models
{
    public class Identif
    {
        [Key]
        public int IdentificacionId { get; set; }

        [Required(ErrorMessage = "El codigo es un campo obligatorio")]
        [Display(Name = "Codigo")]

        public string IdentificacionCodigo { get; set; }


        [Required(ErrorMessage = "El apellido es obligatorio")]
        [Display(Name = "Apellido")]
        public string IdentificacionApellido { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre")]
        public string IdentificacionNombre { get; set; }

        [Display(Name = "Apodo")]

        public string IdentificacionApodo { get; set; }

        [Display(Name = "Dirección")]

        public string IdentificacionDireccion { get; set; }

        [Display(Name = "Codigo Postal")]

        public int IdentificacionCPostal { get; set; }

        [Required(ErrorMessage = "El numero de Telefono es obligatorio")]
        [Display(Name = "Telelfono")]
        
        

        public int IdentificacionTelefono { get; set; }

        [Required(ErrorMessage = "El numero de Celular es obligatorio")]
        [Display(Name = "Celular")]

        public int IdentificacionCelular { get; set; }

        [Display(Name = "FAX")]

        public string IdentificacionFax { get; set; }

        [Required(ErrorMessage = "El Email es obligatorio")]
        [Display(Name = "Email")]
        public string IdentificacionEmail { get; set; }
        
        [Display(Name = "Observaciones")]

        public string IdentificacionObservacion { get; set; }

    }
}
