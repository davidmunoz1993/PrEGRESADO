using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class InformacionPersonal
    {
        [Key]
        public int InformacionPersonalID { get; set; }

        [Display(Name = "Nombres")]
        [Required(ErrorMessage = " Este campo no puede ir vacío")]
        public string NombresEgresado { get; set; }

        [Display(Name = "Primer apellido")]
        [Required(ErrorMessage = " El campo no puede ir vacío")]
        public string PrimerApellidoEgresado { get; set; }

        [Display(Name = "Segundo apeliido")]
        [Required(ErrorMessage = " Este campo  no puede ir vacío")]
        public string SegundoApellidoEgresado { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        [Required(ErrorMessage = " El campo   no puede ir vacío")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimientoEgresado { get; set; }

        [Display(Name = "Número de documento")]
        [Required(ErrorMessage = " El campo  no puede ir vacío")]
        public String NumeroDocumentoEgresado { get; set; }

    [Display(Name = "Fecha de expedición del documento")]
    [Required(ErrorMessage = " El campo  no puede ir vacío")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM- dd}", ApplyFormatInEditMode = true)]
    public DateTime FechaExpedicionDocumento { get; set; }

    [Display(Name = "Sexo")]
    [Required(ErrorMessage = " El campo  no puede ir vacío")]
    public string SexoEgresado { get; set; }

    [Display(Name = "Correo electrónico")]
    [Required(ErrorMessage = " El campo  no puede ir vacío")]
    [DataType(DataType.EmailAddress)]
    public string correoEgresado { get; set; }

    [Display(Name = "Dirección de residencia")]
    [Required(ErrorMessage = " El campo no puede ir vacío")]
    public string DireccionResidenciaEgresado { get; set; }

    [Display(Name = "Teléfono móvil ")]
    [Required(ErrorMessage = " El campo no puede ir vacío")]
    [DataType(DataType.PhoneNumber)]
    public string TelefonoMovilEgresado { get; set; }

    [Display(Name = "Teléfono fijo ")]
    [Required(ErrorMessage = " El campo no puede ir vacío")]
    [DataType(DataType.PhoneNumber)]
    public string TelefonoFijoEgresado { get; set; }

    [Display(Name = "Extención teléfono ")]
    public string ExtencionTelefonoEgresado { get; set; }

    [Display(Name = "Número acta de grado")]
    [Required(ErrorMessage = " El campo no puede ir vacío")]
    public String NumeroActaGrado { get; set; }

    [Display(Name = "Foto")]
    [DataType(DataType.Upload)]
    public String FotoEgresado { get; set; }

        [Display(Name = "Tipo de documento")]
        public int TipoDocumentoID { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }

        public virtual ICollection<ReferenciasPersonales>ReferenciasPersonales { get; set; }
        public virtual ICollection<InformacionProfesional> InformacionProfesionals { get; set; }
        public virtual ICollection<InformacionLaboral> InformacionLaborals { get; set; }
        public virtual ICollection<PublicacionEgresado> PublicacionEgresados{ get; set; }
    }
}
