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
    /// Interação lógica para pgListarPlano.xam
    /// </summary>
    public partial class pgListarPlano : Page
    {
        Empresa empresa;
        public pgListarPlano(Empresa e)
        {
            InitializeComponent();
            empresa = EmpresaDAO.FindCompanyById(e.EmpresaId);
            listarPlanos(empresa);
        }

        private void listarPlanos(Empresa empresa)
        {
            listaPlanos.ItemsSource = PlanoDAO.PlanosDaEmpresa(empresa);
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Plano plano = button.DataContext as Plano;
            this.Content = new uclAlterarPlano(plano);
        }

        private void BtnExcluir_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Plano plano = button.DataContext as Plano;
        }
    }
}