using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class PublicacionEgresado
    {
        [Key]
        public int PublicacionEgresadoID { get; set; }

        [Display(Name = "Fecha de inicio")]
        [Required(ErrorMessage = " El campo no puede ir vacío")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaInicioPublicacionEgresado { get; set; }

        [Display(Name = "Fecha final")]
        [Required(ErrorMessage = " El campo no puede ir vacío")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaFinalPublicacionEgresado { get; set; }


        [Display(Name = "Asunto de la publicación")]
        [Required(ErrorMessage = " El campo no puede ir vacío")]
        public String AsuntoPublicacionEgresado { get; set; }

        [Display(Name = "Informacion de la publicación")]
        [Required(ErrorMessage = " El campo no puede ir vacío")]
        public String InformacionPublicacionEgresado { get; set; }

        [Display(Name = "Usuario")]
        public int InformacionPersonalID { get; set; }
        public virtual InformacionPersonal InformacionPersonal { get; set; }



    }
}