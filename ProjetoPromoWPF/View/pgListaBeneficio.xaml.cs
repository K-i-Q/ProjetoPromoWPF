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
    /// Interação lógica para pgListaBeneficio.xam
    /// </summary>
    public partial class pgListaBeneficio : Page
    {
        Empresa empresa;
        Beneficio beneficio;
        public pgListaBeneficio(Empresa e)
        {
            InitializeComponent();
            empresa = e;
            listarBeneficios(empresa);
        }

        private void listarBeneficios(Empresa empresa)
        {
            listaBeneficios.ItemsSource = BeneficioDAO.BeneficiosDaEmpresa(empresa);
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            beneficio = button.DataContext as Beneficio;

            this.Content = new uclAlterarBeneficio(beneficio);

        }
    }
}