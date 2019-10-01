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
    /// Interação lógica para pgPerfil.xam
    /// </summary>
    public partial class pgPerfil : Page
    {
        Empresa empresa;
        public pgPerfil(Empresa e)
        {
            InitializeComponent();

            empresa = EmpresaDAO.FindCompanyById(e.EmpresaId);
        }

        private void BtnVer_Click(object sender, RoutedEventArgs e)
        {
            fmPerfil.Content = new pgVerPerfil(empresa);
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            fmPerfil.Content = new pgEditarPerfil(empresa);
        }

        private void BtnExcluir_Click(object sender, RoutedEventArgs e)
        {
            fmPerfil.Content = new pgExcluirPerfil(empresa);
        }
    }
}
