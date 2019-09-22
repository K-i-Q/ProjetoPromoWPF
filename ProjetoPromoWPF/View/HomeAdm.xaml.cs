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
    /// Lógica interna para HomeAdm.xaml
    /// </summary>
    public partial class HomeAdm : Window
    {
        private static Context ctx = SingletonContext.GetInstance();

        public HomeAdm()
        {
            InitializeComponent();
            
        }

        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();

            SingletonContext.CloseContext();

            frmLogin.Show();
            this.Close();
        }

        private void BtnListarTodosOsClientes_Click(object sender, RoutedEventArgs e)
        {
            fmAdm.Content = new pgListaDeTodosOsClientes();
            
        }

        private void BtnListarTodasAsEmpresas_Click(object sender, RoutedEventArgs e)
        {
            fmAdm.Content = new pgListaDeTodasAsEmpresas();
        }
    }
}
