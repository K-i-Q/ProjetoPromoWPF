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
    /// Interação lógica para pgExcluirClientes.xam
    /// </summary>
    public partial class pgExcluirClientes : Page
    {
        Cliente cliente;
        Empresa empresa;
        public pgExcluirClientes(Cliente c, Empresa e)
        {
            InitializeComponent();
            cliente = ClienteDAO.FindClientById(c.ClienteId);
            empresa = EmpresaDAO.FindCompanyById(e.EmpresaId);
            confirmarExclusaoDeCliente(cliente,empresa);
            
        }

        private void confirmarExclusaoDeCliente(Cliente cliente, Empresa e)
        {
            if (MessageBox.Show("Deseja excluir a contratação com este cliente?", "Excluir Contratação", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                if (EmpresaClienteDAO.EmpresasDoCliente(cliente).Contains(EmpresaClienteDAO.ContratacaoDoClienteDaEmpresa(e,cliente)))
                {
                    MessageBox.Show("Conta " + cliente.Nome + " excluída com sucesso!");
                    this.Content = new frmLogin();
                }
            }
            else
            {
                MessageBox.Show("operação cancelada!");
            }
        }
    }
}
