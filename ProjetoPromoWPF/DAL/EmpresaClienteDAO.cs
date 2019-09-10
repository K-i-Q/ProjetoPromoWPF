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
           // ctx.SaveChanges();
        }

        public static List<EmpresaCliente> ShowAllCompanyClient() => ctx.EmpresaCliente.ToList();

        //show companies hire by client
        public static string ShowContractorsByClient(Cliente c)
        {
            StringBuilder sb = new StringBuilder();
            foreach (EmpresaCliente empresaCliente in ShowAllCompanyClient())
            {
                if (c.ClienteId == empresaCliente.ClienteId)
                {
                    sb.Append(EmpresaDAO.FindCompanyById(empresaCliente.EmpresaId).Nome + "\n");
                }
            }
            return sb.ToString();
        }
    }
}
