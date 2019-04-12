using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class ParentescoReferencia
    {
        [Key]
        public int ParentescoReferenciaID { get; set; }

        [Display(Name = "Tipo de parentesco ")]
        [Required(ErrorMessage = " El campo no puede ir vacío")]
        public String NombreTipoParentesco { get; set; }

        public virtual ICollection<ReferenciasPersonales> ReferenciasPersonales { get; set; }

    }
}