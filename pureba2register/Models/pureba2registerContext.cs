﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class pureba2registerContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public pureba2registerContext() : base("name=pureba2registerContext")
        {
        }

        public System.Data.Entity.DbSet<pureba2register.Models.prueba> pruebas { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.InformacionPersonal> InformacionPersonals { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.ReferenciasPersonales> ReferenciasPersonales { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.ParentescoReferencia> ParentescoReferencias { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.TipoReferencia> TipoReferencias { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.TipoDocumento> TipoDocumentoes { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.InformacionProfesional> InformacionProfesionals { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.CarreraProfesional> CarreraProfesionals { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.TipoEstudio> TipoEstudios { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.PublicacionEgresado> PublicacionEgresadoes { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.InformacionLaboral> InformacionLaborals { get; set; }

        public System.Data.Entity.DbSet<pureba2register.Models.RangoSalarial> RangoSalarials { get; set; }
    }
}
