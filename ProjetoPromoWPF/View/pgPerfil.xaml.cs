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
    /// Interação lógica para pgPerfil.xam
    /// </summary>
    public partial class pgPerfil : Page
    {
        public pgPerfil()
        {
            InitializeComponent();
        }

        private void BtnVer_Click(object sender, RoutedEventArgs e)
        {
            fmPerfil.Content = new pgVerPerfil();
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            fmPerfil.Content = new pgEditarPerfil();
        }

        private void BtnExcluir_Click(object sender, RoutedEventArgs e)
        {
            fmPerfil.Content = new pgExcluirPerfil();
        }
    }
}
