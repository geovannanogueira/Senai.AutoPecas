using System;
using System.Collections.Generic;

namespace Senai.AutoPecas.WebApi.Domains
{
    public partial class Pecas
    {
        public int IdPeca { get; set; }
        public string CodigoDaPeca { get; set; }
        public string Descricao { get; set; }
        public decimal? Peso { get; set; }
        public decimal? PreçoDoCusto { get; set; }
        public decimal? PreçoDaVenda { get; set; }
        public int? IdFornecedor { get; set; }

        public Fornecedores IdFornecedorNavigation { get; set; }
    }
}
