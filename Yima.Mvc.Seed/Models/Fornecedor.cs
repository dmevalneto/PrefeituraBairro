using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IssatisLab.Yima.Mvc.Seed.Models
{
    public class Fornecedor
    {
        [Key]
        public int FornecedorId { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string endereco { get; set; }
        public string email { get; set; }

        public virtual ICollection<FornecedorProduto> FornecedorProduto { get; set; }
    }
}