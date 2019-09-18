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
    /// Interação lógica para pgBeneficio.xam
    /// </summary>
    public partial class pgBeneficio : Page
    {
        public pgBeneficio()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            fmBeneficio.Content = new pgCadastrarBeneficio();
        }

        private void BtnListar_Click(object sender, RoutedEventArgs e)
        {
            fmBeneficio.Content = new pgListaBeneficio();
        }

        private void BtnAlterar_Click(object sender, RoutedEventArgs e)
        {
            fmBeneficio.Content = new pgAlteraBeneficio();
        }

        private void BtnExcluir_Click(object sender, RoutedEventArgs e)
        {
            fmBeneficio.Content = new pgExcluiBeneficio();
        }
    }
}
