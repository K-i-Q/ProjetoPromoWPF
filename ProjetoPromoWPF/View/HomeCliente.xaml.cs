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
    /// Lógica interna para HomeCliente.xaml
    /// </summary>
    public partial class HomeCliente : Window
    {
        Cliente cliente = new Cliente();
        public HomeCliente(Cliente c)
        {
            cliente = c;
            InitializeComponent();
        }


        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();

            frmLogin.Show();
            this.Close();
        }

        private void BtnListarEmpresas_Click(object sender, RoutedEventArgs e)
        {
            fmCliente.Content = new pgContratarEmpresa(cliente);
        }

        private void BtnListarEmpresasContratadas_Click(object sender, RoutedEventArgs e)
        {
            fmCliente.Content = new pgListarEmpresasContratadas(cliente);
        }
    }
}
