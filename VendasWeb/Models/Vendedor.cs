using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendasWeb.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimeto { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Derpartamento { get; set; }
        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimeto, double salarioBase, Departamento derpartamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimeto = dataNascimeto;
            SalarioBase = salarioBase;
            Derpartamento = derpartamento;
        }

        public void AddVendas(RegistroVendas rv)
        {
            Vendas.Add(rv);
        }

        public void RemoveVendas(RegistroVendas rv)
        {
            Vendas.Remove(rv);
        }

        public double TotalVendas(DateTime inicio, DateTime Fim)
        {
            return Vendas.Where(rv => rv.Data >= inicio && rv.Data <= Fim).Sum(rv => rv.Quantia);
        }
    }
}
