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
    /// Interação lógica para pgParceria.xam
    /// </summary>
    public partial class pgParceria : Page
    {
        Empresa empresa;
        public pgParceria(Empresa e)
        {
            InitializeComponent();

            empresa = e;
        }

        private void BtnCadastrarParceria_Click(object sender, RoutedEventArgs e)
        {
            fmParceria.Content = new pgCadastrarParceria(empresa);
        }

        private void BtnListarParceria_Click(object sender, RoutedEventArgs e)
        {
            fmParceria.Content = new pgListaParceria(empresa);
        }

        private void BtnAlterarParceria_Click(object sender, RoutedEventArgs e)
        {
            fmParceria.Content = new pgAlterarParceria();
        }

        private void BtnExcluirParceria_Click(object sender, RoutedEventArgs e)
        {
            fmParceria.Content = new pgExcluirParceria();
        }
    }
}
