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
    /// Interação lógica para pgListarEmpresasContratadas.xam
    /// </summary>
    public partial class pgListarEmpresasContratadas : Page
    {
        Cliente cliente;
        Empresa empresa;

        public pgListarEmpresasContratadas(Cliente c)
        {
            InitializeComponent();
            cliente = ClienteDAO.FindClientById(c.ClienteId);
            listarEmpresasContratadasPeloCliente();
        }

        private void listarEmpresasContratadasPeloCliente()
        {
            listaDeEmpresasContratadasPeloCliente.ItemsSource = EmpresaClienteDAO.ShowContractorsByClient(cliente);
            
        }

        private void BtnDetalhes_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            empresa = button.DataContext as Empresa;

            fmDetalhesEmpresa.Content = new pgDetalhesEmpresaContratada(empresa, cliente);
        }
    }
}
