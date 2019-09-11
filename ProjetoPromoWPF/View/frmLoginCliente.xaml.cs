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
using System.Windows.Shapes;

namespace ProjetoPromoWPF.View
{
    /// <summary>
    /// Lógica interna para frmLoginCliente.xaml
    /// </summary>
    public partial class frmLoginCliente : Window
    {
        public frmLoginCliente()
        {
            InitializeComponent();
        }
        private void BtnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();

            frmCadastro.Show();
            this.Close();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            Index home = new Index();
            Cliente cliente = new Cliente();
            string senha = txtSenha.Text;

            cliente.Email = txtEmail.Text;
            cliente = ClienteDAO.FindClient(cliente);

            if (cliente != null)
            {
                if (cliente.Senha == senha)
                {
                    home.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Senha incorreta");
                }
            }
            else
            {
                MessageBox.Show("Email incorreto");
            }

        }
    }
}
