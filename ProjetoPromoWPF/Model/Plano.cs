using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPromoWPF.Model
{
    [Table("Planos")]
    public class Plano
    {
        [Key]
        public int PlanoId { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public string Descricao { get; set; }
        public Empresa Empresa { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\nNome: " + Nome);
            sb.Append("\nDescrição: " + Descricao);
            sb.Append("\nPreco: " + Preco);

            return sb.ToString();

        }

        public override bool Equals(object obj)
        {
            Plano p = (Plano) obj;

            return p.PlanoId == PlanoId;
        }
    }
}
