﻿using System;
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
    /// Lógica interna para frmClienteCadastro.xaml
    /// </summary>
    public partial class frmClienteCadastro : Window
    {
        public frmClienteCadastro()
        {
            InitializeComponent();
        }

        private void BtnCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            Index home = new Index();

            home.Show();
            this.Close();
        }
    }
}
