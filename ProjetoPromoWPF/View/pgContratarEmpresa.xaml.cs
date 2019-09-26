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
    /// Interação lógica para pgContratarEmpresa.xam
    /// </summary>
    public partial class pgContratarEmpresa : Page
    {
        Cliente cliente;
        Empresa empresa;

        public pgContratarEmpresa(Cliente c)
        {
            InitializeComponent();
            cliente = ClienteDAO.FindClientById(c.ClienteId);
            listarEmpresasParaContratar();
        }
        private void listarEmpresasParaContratar()
        {
            listaDeEmpresasParaContratar.ItemsSource = EmpresaDAO.ShowCompanies();
        }
        private void BtnDetalhesContratar_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            empresa = button.DataContext as Empresa;

            fmDetalhesEmpresaContratar.Content = new pgDetalhesEmpresaContratar(empresa, cliente);
        }
    }
}
