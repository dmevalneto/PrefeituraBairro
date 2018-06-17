using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IssatisLab.Yima.Mvc.Seed.Models
{
    public class Perfil
    {
        [Key]
        public int perfilId { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string contato { get; set; }

        public virtual ICollection<Perfil> Perfis { get; set; }
    }
}