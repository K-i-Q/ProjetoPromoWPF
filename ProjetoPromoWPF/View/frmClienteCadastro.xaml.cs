using ProjetoPromoWPF.DAL;
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
            Cliente cliente = new Cliente();
            Index home = new Index();


            cliente.CPF = txtCPF.Text;
            cliente.Nome = txtNome.Text;
            cliente.DataNascimento = txtDataNascimento.Text;
            cliente.Genero = txtGenero.Text;
            cliente.Email = txtEmail.Text;
            cliente.Senha = txtSenha.Text;
            cliente.Telefone = txtTelefone.Text;

            ClienteDAO.RegisterClient(cliente);
            MessageBox.Show(cliente.Nome + " cadastrado com sucesso!");

            home.Show();
            this.Close();
        }
    }
}
