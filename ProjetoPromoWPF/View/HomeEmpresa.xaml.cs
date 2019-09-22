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
    /// Lógica interna para HomeEmpresa.xaml
    /// </summary>
    public partial class HomeEmpresa : Window
    {
        Empresa empresa;
        public HomeEmpresa(Empresa e)
        {
            InitializeComponent();
            empresa = new Empresa();
            empresa = e;
        }
        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();

            frmLogin.Show();
            this.Close();
        }

        private void BtnParcerias_Click(object sender, RoutedEventArgs e)
        {
            fmEmpresa.Content = new pgParceria();
        }

        private void BtnClientes_Click(object sender, RoutedEventArgs e)
        {
            fmEmpresa.Content = new pgCliente();
        }

        private void BtnPerfil_Click(object sender, RoutedEventArgs e)
        {
            fmEmpresa.Content = new pgPerfil();
        }

        private void BtnBeneficios_Click(object sender, RoutedEventArgs e)
        {
            fmEmpresa.Content = new pgBeneficio(empresa);
        }

        private void BtnPlanos_Click(object sender, RoutedEventArgs e)
        {
            fmEmpresa.Content = new pgPlano(empresa);
        }
    }
}
