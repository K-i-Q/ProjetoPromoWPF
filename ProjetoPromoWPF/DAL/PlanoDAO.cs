using ProjetoPromoWPF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPromoWPF.DAL
{
    class PlanoDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        
        public static void RegisterPlan(Plano plano)
        {
            ctx.Planos.Add(plano);
            ctx.SaveChanges();
        }

        public static List<Plano> ShowPlans() => ctx.Planos.ToList();
        
        public static void RemovePlan(Plano plano)
        {
            ctx.Planos.Remove(FindPlan(plano));
            ctx.SaveChanges();
        }

        public static Plano FindPlan(Plano plano)
        {
            return ctx.Planos.FirstOrDefault(x => x.PlanoId.Equals(plano.PlanoId));
        }
        public static Plano FindPlanById(int id)
        {
            //return ctx.Planos.FirstOrDefault(x => x.PlanoId.Equals(plano));
            return ctx.Planos.Find(id);
        }

        public static void EditPlan(Plano plano)
        {
            ctx.Entry(plano).State = EntityState.Modified;
            ctx.SaveChanges();
        }

    }
}
