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
    /// Interação lógica para pgExcluirParceria.xam
    /// </summary>
    public partial class pgExcluirParceria : Page
    {
        Empresa empresa;
        public pgExcluirParceria(Empresa e)
        {
            InitializeComponent();

            empresa = EmpresaDAO.FindCompanyById(e.EmpresaId);

            carregarParceirosDaEmpresa(empresa);
        }

        private void carregarParceirosDaEmpresa(Empresa empresa)
        {
            listaEmpresasParceiras.ItemsSource = EmpresaEmpresaDAO.ParceirosDaEmpresa(empresa);
        }

        private void BtnExcluir_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Empresa parceira = button.DataContext as Empresa;
            EmpresaEmpresa parceria = EmpresaEmpresaDAO.ParceriaDasEmpresas(empresa, parceira); ;
            if (MessageBox.Show("Tem certeza que quer remover a parceria com a empresa "+parceira.Razao+"? Esta operação não pode ser revertida.", "Remoção de parceiro", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                EmpresaEmpresaDAO.RemovePartner(parceria);
            }
            else
            {
                MessageBox.Show("Operação cancelada");
            }
        }
    }
}
