﻿using ProjetoPromoWPF.DAL;
using ProjetoPromoWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetoPromoWPF.View
{
    /// <summary>
    /// Interação lógica para pgDetalhesEmpresa.xam
    /// </summary>
    public partial class pgDetalhesEmpresaContratada : Page
    {
        EmpresaCliente empresaCliente;
        Cliente cliente;
        Empresa empresa;
        Plano plano;

        public pgDetalhesEmpresaContratada(Empresa e, Cliente c)
        {
            InitializeComponent();
            empresa = e;
            cliente = c;
            empresaCliente = EmpresaClienteDAO.ShowAllCompanyClient().FirstOrDefault(x => x.EmpresaId.Equals(empresa.EmpresaId) && x.ClienteId.Equals(cliente.ClienteId));
            plano = EmpresaClienteDAO.ShowPlanByCompanyPlanId(empresaCliente.PlanoId);
            carregarEmpresaContratada(e);
        }

        private void carregarEmpresaContratada(Empresa e)
        {
            txtRazao.Text = e.Razao;
            txtCnpj.Text = e.CNPJ;
            txtEmail.Text = e.Email;
            txtTelefone.Text = e.Telefone;
            txtPlano.Text = plano.Nome;
        }
    }
}
