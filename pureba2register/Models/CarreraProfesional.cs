﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class CarreraProfesional
    {
        [Key]
        public int CarreraProfesionalID { get; set; }

        [Display(Name = "Nombre carrera profesional")]
        [Required(ErrorMessage = " El campo no puede ir vacío")]
        public String NombreCarrera { get; set; }

        [Display(Name = "Descripción de la carrera")]
        [Required(ErrorMessage = " El campo no puede ir vacío")]
        public String DescripcionCarrera { get; set; }

        public virtual ICollection<InformacionProfesional> InformacionProfesionals { get; set; }

    }
}