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
    /// Interação lógica para pgCadastrarPlano.xam
    /// </summary>
    public partial class pgCadastrarPlano : Page
    {
        Empresa empresa;
        Plano plano;
        public pgCadastrarPlano(Empresa e)
        {
            InitializeComponent();
            empresa = new Empresa();
            plano = new Plano();

            empresa = e;
        }

        private void BtnCadastrarPlano_Click(object sender, RoutedEventArgs e)
        {
            plano.Nome = txtNome.Text;
            plano.Preco = Convert.ToDouble(txtPreco.Text);
            plano.Descricao = txtDescricao.Text;
            plano.Empresa = empresa;

            PlanoDAO.RegisterPlan(plano);
            MessageBox.Show("Plano: "+plano.Nome+" cadastrado para empresa " +plano.Empresa.Razao);
        }
    }
}
