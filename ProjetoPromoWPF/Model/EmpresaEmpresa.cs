﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPromoWPF.Model
{
    [Table("ParceiroDaEmpresa")]
    public class EmpresaEmpresa
    {
        [Key]
        public int EmpresaEmpresaId { get; set; }
        public int EmpresaUmId { get; set; }
        public Empresa EmpresaUm { get; set; }
        public int EmpresaDoisId { get; set; }
        public Empresa EmpresaDois { get; set; }
        public DateTime CriadoEm { get; set; }

        public EmpresaEmpresa()
        {
            CriadoEm = DateTime.Now;
        }
    }
}
