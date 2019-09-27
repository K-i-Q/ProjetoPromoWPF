using ProjetoPromoWPF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPromoWPF.DAL
{
    class EmpresaClienteDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        
        public static void HireCompany(EmpresaCliente empresaCliente)
        {
            ctx.EmpresaCliente.Add(empresaCliente);
            ctx.SaveChanges();
        }

        public static void EditarContratacao(EmpresaCliente empresaCliente)
        {
            ctx.Entry(empresaCliente).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public static void ExcluirContratacao(EmpresaCliente ec)
        {
            ctx.EmpresaCliente.Remove(ec);
            ctx.SaveChanges();
        }

        public static List<EmpresaCliente> ShowAllCompanyClient() => ctx.EmpresaCliente.ToList();

        public static EmpresaCliente ShowHiring(EmpresaCliente ec)
        {
            foreach (EmpresaCliente contratacao in ShowAllCompanyClient())
            {
                if (contratacao.EmpresaClienteId.Equals(ec.EmpresaClienteId))
                {
                    return contratacao;
                }
            }
            return null;
        }
        
        public static List<Empresa> ShowContractorsByClient(Cliente c)
        {
            List<Empresa> empresasContratadas = new List<Empresa>();

            foreach (EmpresaCliente empresaCliente in ShowAllCompanyClient())
            {
                if (c.ClienteId == empresaCliente.ClienteId)
                {
                    empresasContratadas.Add(EmpresaDAO.FindCompanyById(empresaCliente.EmpresaId));
                }
            }

            return empresasContratadas;
        }

        public static Plano ShowPlanByCompanyPlanId(int planoid)
        {
            foreach (EmpresaCliente empresaDoCliente in ShowAllCompanyClient())
            {
                if (planoid.Equals(empresaDoCliente.PlanoId))
                {
                    return PlanoDAO.FindPlanById(planoid);
                }
            }
            return null;
        }

        public static List<EmpresaCliente> ClientesDaEmpresa(Empresa e) => ctx.EmpresaCliente.Where(x => x.Empresa.EmpresaId.Equals(e.EmpresaId)).ToList();

        public static List<EmpresaCliente> EmpresasDoCliente(Cliente c) => ctx.EmpresaCliente.Where(x => x.ClienteId.Equals(c.ClienteId)).ToList();

        public static EmpresaCliente ContratacaoDoPlanoPeloClienteDaEmpresa(Empresa e, Cliente c, Plano p) => ctx.EmpresaCliente.FirstOrDefault(x => x.PlanoId.Equals(p.PlanoId) && x.EmpresaId.Equals(e.EmpresaId) && x.ClienteId.Equals(c.ClienteId));

        public static EmpresaCliente ContratacaoDoClienteDaEmpresa(Empresa e, Cliente c) => ctx.EmpresaCliente.FirstOrDefault(x => x.EmpresaId.Equals(e.EmpresaId) && x.ClienteId.Equals(c.ClienteId));
    }

}
