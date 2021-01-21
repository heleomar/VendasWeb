using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasWeb.Models.Enums;

namespace VendasWeb.Models
{
    public class RegistroVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantia { get; set; }
        public SituacaoVenda Situacao { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVendas()
        {

        }

        public RegistroVendas(int id, DateTime data, double quantia, SituacaoVenda situacao, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantia = quantia;
            Situacao = situacao;
            Vendedor = vendedor;
        }
    }
}
