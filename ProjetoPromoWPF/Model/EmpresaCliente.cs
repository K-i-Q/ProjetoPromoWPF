using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPromoWPF.Model
{
    [Table("ClientesDaEmpresa")]
    class EmpresaCliente
    {

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        public DateTime ContratadaEm { get; set; }

        public EmpresaCliente()
        {
            ContratadaEm = DateTime.Now;

            Cliente = new Cliente();
            Empresa = new Empresa();
        }
    }
}
