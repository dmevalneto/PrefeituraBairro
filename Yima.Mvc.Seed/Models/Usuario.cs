using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IssatisLab.Yima.Mvc.Seed.Models
{
    public class Usuario
    {
        [Key]
        public int usuarioId { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string cargo { get; set; }

        public int perfilId { get; set; }

        public virtual Perfil Perfil { get; set; }
    }
}