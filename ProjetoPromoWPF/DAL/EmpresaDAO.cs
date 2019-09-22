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


        public static void RegisterCompany(Empresa empresa)
        {
            ctx.Empresas.Add(empresa);
            ctx.SaveChanges();
        }

        public static List<Empresa> ShowCompanies() => ctx.Empresas.ToList();

        public static void RemoveCompany(Empresa empresa)
        {
            ctx.Empresas.Remove(FindCompany(empresa));
            ctx.SaveChanges();
        }

        public static Empresa FindCompany(Empresa empresa) => ctx.Empresas.FirstOrDefault(x => x.Email.Equals(empresa.Email));


        public static Empresa FindCompanyByEmail(string email) => ctx.Empresas.FirstOrDefault(x => x.Email.Equals(email));


        public static Empresa FindCompanyById(int id) => ctx.Empresas.FirstOrDefault(x => x.EmpresaId.Equals(id));


        public static Empresa FindCompanyByName(string nome) => ctx.Empresas.FirstOrDefault(x => x.Razao.Contains(nome));
       


        public static void EditCompany(Empresa empresa)
        {
            ctx.Entry(empresa).State = EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}
