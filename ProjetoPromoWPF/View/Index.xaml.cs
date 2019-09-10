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
using System.Windows.Shapes;

namespace ProjetoPromoWPF.View
{
    /// <summary>
    /// Lógica interna para Index.xaml
    /// </summary>
    public partial class Index : Window
    {
        public Index()
        {
            InitializeComponent();
            
        }

        private void BtnLoginIndex_Click(object sender, RoutedEventArgs e)
        {
            fmMain.Content = new pgLogin();
        }

        private void BtnHomeIndex_Click(object sender, RoutedEventArgs e)
        {
            fmMain.Content = new pgHome();
        }

        private void BtnTipoCadastroIndex_Click(object sender, RoutedEventArgs e)
        {

            fmMain.Content = new pgTipoCadastro();
        }
    }
}
