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
    /// Lógica interna para frmLoginAdm.xaml
    /// </summary>
    public partial class frmLoginAdm : Window
    {
        public frmLoginAdm()
        {
            InitializeComponent();
        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            HomeAdm home = new HomeAdm();
            Administrador adm = new Administrador();
            string senha = txtSenha.Text;

            adm.Login = txtLogin.Text;
            adm = AdministradorDAO.FindAdm(adm);

            if (adm != null)
            {
                if (adm.Senha == senha)
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
                MessageBox.Show("Login incorreto");
            }

        }
    }
}
