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
    /// Lógica interna para frmLoginEmpresa.xaml
    /// </summary>
    public partial class frmLoginEmpresa : Window
    {
        public frmLoginEmpresa()
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
            Empresa empresa = new Empresa();
            string senha = txtSenha.Text;

            empresa.Email = txtEmail.Text;
            empresa = EmpresaDAO.FindCompany(empresa);

            if (empresa != null)
            {
                if (empresa.Senha == senha)
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
