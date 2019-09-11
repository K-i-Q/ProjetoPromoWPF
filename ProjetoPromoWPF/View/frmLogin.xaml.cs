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
    /// Lógica interna para frmLogin.xaml
    /// </summary>
    public partial class frmLogin : Window
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void BtnLoginEmpresa_Click(object sender, RoutedEventArgs e)
        {
            frmLoginEmpresa frmLoginEmpresa = new frmLoginEmpresa();

            frmLoginEmpresa.Show();
            this.Close();
        }

        private void BtnLoginCliente_Click(object sender, RoutedEventArgs e)
        {
            frmLoginCliente frmLoginCliente = new frmLoginCliente();

            frmLoginCliente.Show();
            this.Close();
        }
        private void BtnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();

            frmCadastro.Show();
            this.Close();
        }
    }
}
