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
    /// Interação lógica para pgCadastrarBeneficio.xam
    /// </summary>
    public partial class pgCadastrarBeneficio : Page
    {
        Beneficio beneficio;
        Empresa empresa;
        public pgCadastrarBeneficio(Empresa e)
        {
            InitializeComponent();

            empresa = e;

        }

        private void BtnCadastrarBeneficio_Click(object sender, RoutedEventArgs e)
        {
            beneficio = new Beneficio();
            beneficio.Nome = txtNome.Text;
            beneficio.Nivel = Convert.ToInt32(txtNivel.Text);
            beneficio.Descricao = txtDescricao.Text;
            beneficio.Empresa = empresa;
            BeneficioDAO.RegisterBenefit(beneficio);
            MessageBox.Show("Beneficio " + beneficio.Nome + " cadastrado para empresa " + beneficio.Empresa.Razao);
        }
    }
}
