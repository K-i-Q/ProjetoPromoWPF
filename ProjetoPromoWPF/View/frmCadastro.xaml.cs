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
    /// Lógica interna para frmCadastro.xaml
    /// </summary>
    public partial class frmCadastro : Window
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void BtnBackToLogin_Click(object sender, RoutedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void BtnClienteCadastro_Click(object sender, RoutedEventArgs e)
        {
            frmClienteCadastro frmClienteCadastro = new frmClienteCadastro();

            frmClienteCadastro.Show();
            this.Close();

        }

        private void BtnEmpresaCadastro_Click(object sender, RoutedEventArgs e)
        {
            frmEmpresaCadastro frmEmpresaCadastro = new frmEmpresaCadastro();

            frmEmpresaCadastro.Show();
            this.Close();
        }
    }
}
