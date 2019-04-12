using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class TipoDocumento
    {
        [Key]
        public int TipoDocumentoID { get; set; }

        [Display(Name = "Tipo de documento")]
        [Required(ErrorMessage = " Este campo no puede ir vacío")]
        public string NombreTipoDocumento { get; set; }

        public virtual ICollection<InformacionPersonal> InformacionPersonals { get; set; }

    }
}