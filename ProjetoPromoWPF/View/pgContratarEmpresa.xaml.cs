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
        Cliente cliente = new Cliente();
        Empresa empresa = new Empresa();
        EmpresaCliente empresaCliente;
        Context ctx = SingletonContext.GetInstance();

        public pgContratarEmpresa(Cliente c)
        {
            cliente = c;
            empresaCliente = new EmpresaCliente();
            InitializeComponent();
            listarEmpresasParaContratar();
        }
        private void listarEmpresasParaContratar()
        {
            listaDeEmpresasParaContratar.ItemsSource = ctx.Empresas.ToList();            
        }
        private void BtnContratarEsta_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            empresa = button.DataContext as Empresa;

            if (MessageBox.Show("Deseja contratar a empresa "+empresa.Razao+"?","Contratar",MessageBoxButton.YesNo,MessageBoxImage.Question)==MessageBoxResult.Yes)
            {
                empresaCliente.ClienteId = cliente.ClienteId;
                empresaCliente.Cliente = cliente;
                empresaCliente.EmpresaId = empresa.EmpresaId;
                empresaCliente.Empresa = empresa;

                EmpresaClienteDAO.HireCompany(empresaCliente);

                MessageBox.Show("Empresa " + empresa.Razao + " contratada com sucesso!");
            }
            else
            {
                MessageBox.Show("Operação cancelada!");
            }
        }
    }
}
