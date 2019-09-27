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
    /// Interação lógica para uclAlterarContratacao.xam
    /// </summary>
    public partial class uclAlterarContratacao : UserControl
    {
        Empresa empresa;
        EmpresaCliente empresaCliente;

        public object EmepresaClienteDAO { get; private set; }

        public uclAlterarContratacao(EmpresaCliente ec)
        {
            InitializeComponent();
            empresaCliente = EmpresaClienteDAO.ShowHiring(ec);
            //TODO
            empresa = EmpresaDAO.FindCompanyById(ec.EmpresaId);
            carregarPlanosDaEmpresa(empresa);
        }

        private void carregarPlanosDaEmpresa(Empresa empresa)
        {
            listaDePlanos.ItemsSource = PlanoDAO.PlanosDaEmpresa(empresa);
        }

        private void BtnAssinar_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Plano plano = button.DataContext as Plano;


            empresaCliente.PlanoId = plano.PlanoId;
            empresaCliente.Plano = plano;

            EmpresaClienteDAO.EditarContratacao(empresaCliente);
            MessageBox.Show("Contrato atualizado com sucesso. Novo plano: " + empresaCliente.Plano.Nome);
        }
    }
}
