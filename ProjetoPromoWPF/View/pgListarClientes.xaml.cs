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
    /// Interação lógica para pgListarClientes.xam
    /// </summary>
    public partial class pgListarClientes : Page
    {
        Empresa empresa;
        public pgListarClientes(Empresa e)
        {
            InitializeComponent();

            empresa = e;

            listaDeClientesDaEmpresa(empresa);
        }

        private void listaDeClientesDaEmpresa(Empresa empresa)
        {
            List<EmpresaCliente> listaDeContratacoes = EmpresaClienteDAO.ClientesDaEmpresa(empresa);
            List<Cliente> listaDeClientesDaEmpresa = new List<Cliente>();

            foreach (EmpresaCliente contratacao in listaDeContratacoes)
            {
                listaDeClientesDaEmpresa.Add(ClienteDAO.FindClientById(contratacao.ClienteId));
            }
            
            listaClientesDaEmpresa.ItemsSource = listaDeClientesDaEmpresa;
        }
    }
}
