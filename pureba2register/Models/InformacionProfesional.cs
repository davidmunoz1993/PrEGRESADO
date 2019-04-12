using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class InformacionProfesional
    {
        [Key]
        public int InformacionProfesionalID { get; set; }

        [Display(Name = "Estudia actualmente?")]
        public Boolean estudiaActualmente { get; set; }

        [Display(Name = "Fecha de terminación")]
        [Required(ErrorMessage = " El campo no puede ir vacío")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fechaTerminacionProfesional { get; set; }

        [Display(Name = "Duración del estudio")]
        [Required(ErrorMessage = " El campo no puede ir vacío")]
        public String duracionProfesional { get; set; }


        [Display(Name = "Usuario")]
        public int InformacionPersonalID { get; set; }
        public virtual InformacionPersonal InformacionPersonal { get; set; }

        [Display(Name = "Tipo de estudio")]
        public int TipoEstudioID { get; set; }
        public virtual TipoEstudio TipoEstudio { get; set; }

        [Display(Name = "Nombre carrera profesional")]
        public int CarreraProfesionalID { get; set; }
        public virtual CarreraProfesional CarreraProfesional { get; set; }



    }
}