﻿using ProjetoPromoWPF.Model;
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
using System.Windows.Shapes;

namespace ProjetoPromoWPF.View
{
    /// <summary>
    /// Lógica interna para HomeEmpresa.xaml
    /// </summary>
    public partial class HomeEmpresa : Window
    {
        public HomeEmpresa(Empresa e)
        {
            InitializeComponent();
            Empresa empresa = e;
            MessageBox.Show("Empresa: " + e.Razao);
        }
        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();

            frmLogin.Show();
            this.Close();
        }
    }
}
