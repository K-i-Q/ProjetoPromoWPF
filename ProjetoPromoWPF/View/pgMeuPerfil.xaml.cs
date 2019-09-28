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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetoPromoWPF.View
{
    /// <summary>
    /// Interação lógica para pgMeuPerfil.xam
    /// </summary>
    public partial class pgMeuPerfil : Page
    {
        Cliente cliente;
        frmLogin login;
        public pgMeuPerfil(Cliente c)
        {
            InitializeComponent();
            cliente = ClienteDAO.FindClientById(c.ClienteId);
            carregarInfoCliente(cliente);
        }

        private void carregarInfoCliente(Cliente c)
        {
            txtCriadoEm.Text = c.CriadoEm.ToString();
            txtDataNasscimento.Text = c.DataNascimento;
            txtEmail.Text = c.Email;
            txtGenero.Text = c.Genero;
            txtNome.Text = c.Nome;
            txtTelefone.Text = c.Telefone;
            txtCpf.Text = c.CPF;
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            fmDetalhesCliente.Content = new pgDetalhesCliente(cliente);
        }

        private void BtnExcluir_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Tem certeza de que você quer excluir sua conta? A exclusão não pode ser revertida", "Exclusão de Conta", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                login = new frmLogin();

                ClienteDAO.RemoveClient(cliente);
                MessageBox.Show("Sua conta foi excluída com sucesso!");

                login.Show();
                Window.GetWindow(this).Close();
            }
            else
            {
                MessageBox.Show("Operação cancelada!");
            }

        }
    }
}
