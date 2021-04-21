using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoulMV.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Unidade { get; set; }
        public DateTime Validade { get; set; }
        //public IEnumerable<Estoque> Estoque { get; set; } = new List<Estoque>();

        // construtores
        public Produto()
        {
        }
        public Produto(int id, string nome, string unidade, DateTime validade)
        {
            Id = id;
            Nome = nome;
            Unidade = unidade;
            Validade = validade;
        }
    }
}
