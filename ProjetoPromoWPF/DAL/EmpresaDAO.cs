using ProjetoPromoWPF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPromoWPF.DAL
{
    class EmpresaDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        //ADD new Company
        public static void RegisterCompany(Empresa empresa)
        {
            ctx.Empresas.Add(empresa);
            ctx.SaveChanges();
        }
        //List all Companies
        public static List<Empresa> ShowCompanies() => ctx.Empresas.ToList();
        //Remove a Company
        public static void RemoveCompany(Empresa empresa)
        {
            ctx.Empresas.Remove(FindCompany(empresa));
            ctx.SaveChanges();
        }
        //Find Company
        public static Empresa FindCompany(Empresa empresa)
        {
            return ctx.Empresas.FirstOrDefault(x => x.Nome.Equals(empresa.Nome));

            //foreach (Empresa e in ShowCompanies())
            //{
            //    if (empresa == e)
            //    {
            //        return e;
            //    }
            //}
            //return null;
        }
        //find Company by ID
        public static Empresa FindCompanyById(int id)
        {
            foreach (Empresa empresa in ShowCompanies())
            {
                if (empresa.EmpresaId == id)
                {
                    return empresa;
                }
            }
            return null;
        }
        //Edit a Company
        public static void EditCompany(Empresa empresa)
        {
            ctx.Entry(empresa).State = EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
