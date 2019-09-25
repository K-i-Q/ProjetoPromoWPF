using ProjetoPromoWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPromoWPF.DAL
{
    class EmpresaClienteDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        //Cadastra a contratação de uma empresa para um cliente
        public static void HireCompany(EmpresaCliente empresaCliente)
        {
            ctx.EmpresaCliente.Add(empresaCliente);
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

        //show companies hire by client
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
    }
}
