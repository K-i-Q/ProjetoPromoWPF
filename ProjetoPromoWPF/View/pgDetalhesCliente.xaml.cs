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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetoPromoWPF.View
{
    /// <summary>
    /// Interação lógica para pgDetalhesCliente.xam
    /// </summary>
    public partial class pgDetalhesCliente : Page
    {
        Cliente cliente = new Cliente();
        public pgDetalhesCliente(Cliente c)
        {
            InitializeComponent();
            carregarCliente(c);
            cliente = c;
        }

        private void carregarCliente(Cliente c)
        {
            txtEmail.Text = c.Email;
            txtGenero.Text = c.Genero;
            txtNome.Text = c.Nome;
            txtTelefone.Text = c.Telefone;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
