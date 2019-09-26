using ProjetoPromoWPF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPromoWPF.DAL
{
    class BeneficioDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static void RegisterBenefit(Beneficio beneficio)
        {
            ctx.Beneficios.Add(beneficio);
            ctx.SaveChanges();
        }

        public static List<Beneficio> ShowBenefits() => ctx.Beneficios.ToList();

        public static void RemoveBenefit(Beneficio beneficio)
        {
            ctx.Beneficios.Remove(FindBenefit(beneficio));
            ctx.SaveChanges();
        }

        public static Beneficio FindBenefit(Beneficio beneficio)
        {
            return ctx.Beneficios.FirstOrDefault(x => x.BeneficioId.Equals(beneficio.BeneficioId));
        }

        public static void EditBenefit(Beneficio beneficio)
        {
            ctx.Entry(beneficio).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public static List<Beneficio> BeneficiosDaEmpresa(Empresa e) => ctx.Beneficios.Where(x => x.Empresa.EmpresaId.Equals(e.EmpresaId)).ToList();
    }
}
