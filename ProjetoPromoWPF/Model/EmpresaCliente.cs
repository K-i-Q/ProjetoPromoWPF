using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPromoWPF.Model
{
    [Table("ClientesDaEmpresa")]
    public class EmpresaCliente
    {
        [Key]
        public int EmpresaClienteId { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        public int PlanoId { get; set; }
        public Plano Plano { get; set; }
        public DateTime ContratadaEm { get; set; }

        public EmpresaCliente()
        {
            ContratadaEm = DateTime.Now;

            Cliente = new Cliente();
            Empresa = new Empresa();
            Plano = new Plano();
        }
    }
}
