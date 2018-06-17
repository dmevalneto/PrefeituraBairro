﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IssatisLab.Yima.Mvc.Seed.Models
{
    public class FornecedorProduto
    {
        [Key]
        public int FornecedorProdutoId { get; set; }
        public int FornecedorId { get; set; }
        public int ID { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Produto Produto { get; set; }
    }
}