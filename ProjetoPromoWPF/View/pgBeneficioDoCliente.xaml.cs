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
    /// Interação lógica para pgBeneficioDoCliente.xam
    /// </summary>
    public partial class pgBeneficioDoCliente : Page
    {
        Cliente cliente;
        Empresa empresa;
        Context ctx = SingletonContext.GetInstance();
        public pgBeneficioDoCliente(Cliente c)
        {
            InitializeComponent();
            cliente = c;
            carregarEmpresasContratadasPeloCliente(cliente);
        }

        private void carregarEmpresasContratadasPeloCliente(Cliente cliente)
        {
            List<EmpresaCliente> contratacoes = new List<EmpresaCliente>();
            List<Empresa> empresas = new List<Empresa>();

            contratacoes = ctx.EmpresaCliente.Where(x => x.ClienteId.Equals(cliente.ClienteId)).ToList();

            foreach (EmpresaCliente contratada in contratacoes)
            {
                empresas.Add(EmpresaDAO.FindCompanyById(contratada.EmpresaId));
            }

            listaDeContratadas.ItemsSource = empresas;
        }

        private void BtnDetalhesContratada_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            empresa = button.DataContext as Empresa;

            fmDetalhesDoBeneficio.Content = new pgEmpresasContratadas(empresa);
        }
        
    }
}
//Cliente cliente;
//Empresa empresa;
//Context ctx = SingletonContext.GetInstance();

//public pgListarEmpresasContratadas(Cliente c)
//{
//    InitializeComponent();
//    cliente = c;
//    listarEmpresasContratadasPeloCliente();
//}

//private void listarEmpresasContratadasPeloCliente()
//{
//    listaDeEmpresasContratadasPeloCliente.ItemsSource = EmpresaClienteDAO.ShowContractorsByClient(cliente);

//    //ctx.EmpresaCliente.Where(x => x.ClienteId.Equals(cliente.ClienteId)).ToList();
//}

//private void BtnDetalhes_Click(object sender, RoutedEventArgs e)
//{
//    Button button = sender as Button;
//    empresa = button.DataContext as Empresa;

//    fmDetalhesEmpresa.Content = new pgDetalhesEmpresaContratada(empresa, cliente);
//}