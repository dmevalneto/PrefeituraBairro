using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IssatisLab.Yima.Mvc.Seed.Models
{
    public class Ocorrencia
    {
        public int ocorrenciaId { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public float cep { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }
    }
}