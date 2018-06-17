using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IssatisLab.Yima.Mvc.Seed.Models
{
    public class Funcionario
    {
        [Key]
        public int FuncionarioId { get; set; }
        [Display(Name ="Nome www")]
        [Required(ErrorMessage = "Campo {0} Obrigatório !")]
        public string nome { get; set; }

        public string sobrenome { get; set; }
        
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:c2}")]
        public string salario { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:p2}")]
        public string comissao { get; set; }
        
        public DateTime nascimento { get; set; }

        public DateTime cadastro { get; set; }  

        public string email { get; set; }

        public int TipoDocumentoId { get; set; }

        public virtual TipoDocumento TipoDocumento { get; set; }
    }
}