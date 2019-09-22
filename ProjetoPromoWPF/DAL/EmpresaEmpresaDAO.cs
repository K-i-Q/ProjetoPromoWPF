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

        public static EmpresaEmpresa FindPartnership(EmpresaEmpresa parceria)
        {
            return ctx.Parceiros.FirstOrDefault(x => x.EmpresaEmpresaId.Equals(parceria.EmpresaEmpresaId));
        }
        

        public static void EditPartner(EmpresaEmpresa parceria)
        {
            ctx.Entry(parceria).State = EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
