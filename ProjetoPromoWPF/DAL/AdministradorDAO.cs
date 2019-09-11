using ProjetoPromoWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPromoWPF.DAL
{
    class AdministradorDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static Administrador FindAdm(Administrador adm)
        {
            return ctx.Administradores.FirstOrDefault(x => x.Login.Equals(adm.Login));
        }
    }
}
