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
    /// Interação lógica para pgCliente.xam
    /// </summary>
    public partial class pgCliente : Page
    {
        Empresa empresa;
        public pgCliente(Empresa e)
        {
            InitializeComponent();
            empresa = e;
        }

        private void BtnListar_Click(object sender, RoutedEventArgs e)
        {
            fmCliente.Content = new pgListarClientes(empresa);
        }

        private void BtnExcluir_Click(object sender, RoutedEventArgs e)
        {
            fmCliente.Content = new pgExcluirClientes();
        }
    }
}
