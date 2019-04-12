using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class ReferenciasPersonales
    {
        [Key]
        public int ReferenciasPersonalesID { get; set; }
       

        [Display(Name = "Nombres")]
        [Required(ErrorMessage = " Este campo no puede ir vacío")]
        public String NombresReferencia { get; set; }

        [Display(Name = "Primer apeliido")]
        [Required(ErrorMessage = " Este campo no puede ir vacío")]
        public String PrimerApellidoReferencia { get; set; }

        [Display(Name = " Segundo apellido")]
        [Required(ErrorMessage = " Este campo no puede ir vacío")]
        public String SegundoApellidoReferencia { get; set; }

        [Display(Name = "Cargo que ocupa")]
        [Required(ErrorMessage = " Este campo no puede ir vacío")]
        public String CargoReferencia { get; set; }

        [Display(Name = "Teléfono fijo ")]
        [Required(ErrorMessage = " El campo no puede ir vacío")]
        [DataType(DataType.PhoneNumber)]
        public string TelefonoFijoReferencia { get; set; }

        [Display(Name = "Extención")]
        public String ExtTelefonoReferencia { get; set; }


        [Display(Name = "Teléfono móvil ")]
        [Required(ErrorMessage = " El campo no puede ir vacío")]
        [DataType(DataType.PhoneNumber)]
        public string TelefonoMovilReferencia{ get; set; }

          [Display(Name = "Usuario")]
        public int InformacionPersonalID { get; set; }
        public virtual InformacionPersonal InformacionPersonal { get; set; }

        [Display(Name = "Tipo de parentesco")]
        public int ParentescoReferenciaID { get; set; }
        public virtual ParentescoReferencia ParentescoReferencia { get; set; }

        [Display(Name = "Tipo de referencia ")]
        public int TipoReferenciaID { get; set; }
        public virtual TipoReferencia TipoReferencia { get; set; }






    }
}