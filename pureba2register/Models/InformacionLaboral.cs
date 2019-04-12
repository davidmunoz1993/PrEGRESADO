using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class InformacionLaboral
    {
        [Key]
        public int InformacionLaboralID { get; set; }

        [Display(Name = "Trabaja actualmente?")]
        public Boolean TrabajaActualmente { get; set; }

        [Display(Name = "Jefe inmediato - Nombres")]
        [Required(ErrorMessage = " El campo no puede ir vacío")]
        public String NombresJefeLaboral { get; set; }

        [Display(Name = "Jefe inmediato- Apellido")]
        [Required(ErrorMessage = " El campo no puede ir vacío")]
        public String ApellidoJefeLaboral { get; set; }

        [Display(Name = "Jefe inmediato- Teléfono  ")]
        [Required(ErrorMessage = " El campo no puede ir vacío")]
        [DataType(DataType.PhoneNumber)]
        public string TelefonoJefeLaboral { get; set; }

        [Display(Name = "Nombre de la empresa")]
        [Required(ErrorMessage = " El campo no puede ir vacío")]
        public String NombreEmpresaLaboral { get; set; }

        [Display(Name = "Dirección de la empresa")]
        public String DireccionEmpresaLaboral { get; set; }

        [Display(Name = "Cargo que ocupa en la empresa")]
        [Required(ErrorMessage = " El campo no puede ir vacío")]
        public String CargoOcupacionLaboral { get; set; }

        [Display(Name = "Fecha de ingreso")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fechaIngresoLaboral { get; set; }

        [Display(Name = "Usuario")]
        public int InformacionPersonalID { get; set; }
        public virtual InformacionPersonal InformacionPersonal { get; set; }

        [Display(Name = "Rango salarial")]
        public int RangoSalarialID { get; set; }
        public virtual RangoSalarial RangoSalarial { get; set; }


    }
}