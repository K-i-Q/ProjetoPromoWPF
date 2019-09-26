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
    /// Lógica interna para HomeCliente.xaml
    /// </summary>
    public partial class HomeCliente : Window
    {
        Cliente cliente;

        public HomeCliente(Cliente c)
        {
            InitializeComponent();
            cliente = c;
        }


        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();

            SingletonContext.CloseContext();

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

        private void BtnMeuPerfil_Click(object sender, RoutedEventArgs e)
        {
            fmCliente.Content = new pgMeuPerfil(cliente);
        }

        private void BtnBeneficios_Click(object sender, RoutedEventArgs e)
        {
            fmCliente.Content = new pgBeneficioDoCliente(cliente);
        }
    }
}
