using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IssatisLab.Yima.Mvc.Seed.Models
{
    public class OcorrenciaInterna
    {
        [Key]
        [Display(Name = "N°")]
        public int ocorrenciaInternaId { get; set; }
        [Display(Name = "Latitude")]
        public string latitude { get; set; }
        [Display(Name = "Longitude")]
        public string longitude { get; set; }
        [Display(Name = "Logradouro")]
        public string logradouro { get; set; }
        [Display(Name = "Numero")]
        public string numero { get; set; }
        [Display(Name = "Bairro")]
        public string bairro { get; set; }
        [Display(Name = "Cep")]
        public string cep { get; set; }
        [Display(Name = "Cidade")]
        public string cidade { get; set; }
        [Display(Name = "Estado")]
        public string estado { get; set; }
        [Display(Name = "Estatos")]
        public string status { get; set; }
        [Display(Name = "Descrição")]
        public string descricao { get; set; }
        [Display(Name ="Data de Início")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime dataIniciado { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data Aguardando")]
        public DateTime dataAguardando { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Finalizado")]
        public DateTime dataFinalizado { get; set; }
    }
}