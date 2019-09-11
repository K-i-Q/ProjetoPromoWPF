using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPromoWPF.Model
{
    [Table("Administradores")]
    class Administrador
    {
        [Key]
        public int AdministradorId { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public override bool Equals(object obj)
        {
            Administrador a = (Administrador)obj;
            return Login == a.Login;
        }
    }
}
