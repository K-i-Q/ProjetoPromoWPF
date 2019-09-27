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
    /// Interação lógica para pgListaDeClientesParaEmpresaExcluir.xam
    /// </summary>
    public partial class pgListaDeClientesParaEmpresaExcluir : Page
    {
        Empresa empresa;
        Cliente cliente;
        public pgListaDeClientesParaEmpresaExcluir(Empresa e)
        {
            InitializeComponent();
            empresa = EmpresaDAO.FindCompanyById(e.EmpresaId);
        }

        private void BtnPesquisarNomeParaExcluir_Click(object sender, RoutedEventArgs e)
        {
            Cliente encontrado; 
            cliente = ClienteDAO.ProcurarClientePorNome(txtNome.Text);
            encontrado = ClienteDAO.ProcurarClientePorNome(txtNome.Text);
            if (MessageBox.Show("O Cliente é "+encontrado.Nome, "Confirmar Cliente", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                confirmarExclusaoDeCliente(cliente, empresa);
            }
            else
            {
                MessageBox.Show("operação cancelada!");
            }
        }

        private void confirmarExclusaoDeCliente(Cliente cliente, Empresa empresa)
        {
            if (MessageBox.Show("Deseja excluir a contratação com este cliente ("+cliente.Nome+")?", "Excluir Contratação", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                EmpresaClienteDAO.ExcluirContratacao(EmpresaClienteDAO.ContratacaoDoClienteDaEmpresa(empresa, cliente));
                MessageBox.Show("Cliente "+cliente.Nome+" excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("operação cancelada!");
            }
        }
    }
}
