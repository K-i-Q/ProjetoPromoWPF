using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPromoWPF.Model
{
    [Table("Empresas")]
    public class Empresa
    {
        [Key]
        public int EmpresaId { get; set; }
        public string CNPJ { get; set; }
        public string Razao { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Responsavel { get; set; }
        public string Telefone { get; set; }
        public DateTime CriadoEm { get; set; }

        public List<EmpresaCliente> EmpresaCliente { get; set; }
        public List<Plano> Planos { get; set; }
        public List<Beneficio> Beneficios { get; set; }

         
        public Empresa()
        {
            CriadoEm = DateTime.Now;
            EmpresaCliente = new List<EmpresaCliente>();
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\n");
            sb.Append("CNPJ: ");
            sb.Append(CNPJ);
            sb.Append("\n");
            sb.Append("Nome: ");
            sb.Append(Razao.ToUpper());
            sb.Append("\n");
            sb.Append("Email: ");
            sb.Append(Email.ToUpper());
            sb.Append("\n");
            sb.Append("Telefone: ");
            sb.Append(Telefone);
            sb.Append("\n");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            Empresa e = (Empresa)obj;
            return Razao == e.Razao;
        }
    }
}
