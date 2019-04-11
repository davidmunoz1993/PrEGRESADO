using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pureba2register.Models
{
    public class prueba
    {

        [Key]
        public int pruebaID { get; set; }
        public string campoPruena { get; set; }
    }
}