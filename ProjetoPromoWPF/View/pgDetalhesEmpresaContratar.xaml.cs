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
    /// Interação lógica para pgDetalhesEmpresaContratar.xam
    /// </summary>
    public partial class pgDetalhesEmpresaContratar : Page
    {
        Empresa empresa;
        Cliente cliente;
        Plano plano;
        EmpresaCliente empresaCliente;

        public pgDetalhesEmpresaContratar(Empresa e, Cliente c)
        {
            InitializeComponent();
            listarDetalhesDaEmpresa(e);
            empresa = EmpresaDAO.FindCompanyById(e.EmpresaId);
            cliente = ClienteDAO.FindClientById(c.ClienteId);
        }
        private void listarDetalhesDaEmpresa(Empresa e)
        {
            txtCnpj.Text = e.CNPJ;
            txtEmail.Text = e.Email;
            txtRazao.Text = e.Razao;
            txtTelefone.Text = e.Telefone;
            listaDePlanos.ItemsSource = PlanoDAO.PlanosDaEmpresa(e);
        }

        private void BtnAssinar_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            plano = button.DataContext as Plano;

            if (MessageBox.Show("Deseja contratar o plano " + plano.Nome + "?", "Contratar", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                empresaCliente = new EmpresaCliente();

                empresaCliente.ClienteId = cliente.ClienteId;
                empresaCliente.Cliente = cliente;
                empresaCliente.EmpresaId = empresa.EmpresaId;
                empresaCliente.Empresa = empresa;
                empresaCliente.PlanoId = plano.PlanoId;
                empresaCliente.Plano = plano;
                empresaCliente.Nivel = plano.Nivel;

                EmpresaClienteDAO.HireCompany(empresaCliente);

                MessageBox.Show("Plano " + plano.Nome + " da empresa "+ empresa.Razao+" contratado com sucesso!");
            }
            else
            {
                MessageBox.Show("Operação cancelada!");
            }
        }
    }
}
