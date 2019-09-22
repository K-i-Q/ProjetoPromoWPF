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
        public pgMeuPerfil(Cliente c)
        {
            InitializeComponent();
            cliente = c;
            carregarInfoCliente(c);
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

        }
    }
}
