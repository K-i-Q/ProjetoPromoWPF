using ProjetoPromoWPF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPromoWPF.DAL
{
    class EmpresaEmpresaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static void RegisterPartner(EmpresaEmpresa parceria)
        {
            ctx.Parceiros.Add(parceria);
            ctx.SaveChanges();
        }

        public static List<EmpresaEmpresa> ShowPartnerships() => ctx.Parceiros.ToList();

        public static void RemovePartner(EmpresaEmpresa parceria)
        {
            ctx.Parceiros.Remove(FindPartnership(parceria));
            ctx.SaveChanges();
        }

        public static List<Empresa> ParceirosDaEmpresa(Empresa e)
        {
            List<Empresa> parceiros = new List<Empresa>();

            foreach (EmpresaEmpresa parceria in ParceriasDaEmpresa(e))
            {
                parceiros.Add(EmpresaDAO.FindCompanyById(parceria.EmpresaDoisId));
            }

            return parceiros;
        }

        public static EmpresaEmpresa FindPartnership(EmpresaEmpresa parceria)
        {
            return ctx.Parceiros.FirstOrDefault(x => x.EmpresaEmpresaId.Equals(parceria.EmpresaEmpresaId));
        }

        public static EmpresaEmpresa ParceriaDasEmpresas(Empresa e, Empresa em) => ctx.Parceiros.FirstOrDefault(x => x.EmpresaUmId.Equals(e.EmpresaId)  && x.EmpresaDoisId.Equals(em.EmpresaId));

        public static void EditPartner(EmpresaEmpresa parceria)
        {
            ctx.Entry(parceria).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public static List<EmpresaEmpresa> ParceriasDaEmpresa(Empresa e) => ctx.Parceiros.Where(x => x.EmpresaUm.EmpresaId.Equals(e.EmpresaId)).ToList();
    }
}
