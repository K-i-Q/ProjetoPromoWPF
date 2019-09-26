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
    /// Interação lógica para uclAlterarBeneficio.xam
    /// </summary>
    public partial class uclAlterarBeneficio : UserControl
    {
        Beneficio beneficio;

        public uclAlterarBeneficio(Beneficio b)
        {
            InitializeComponent();
            beneficio = BeneficioDAO.FindBenefit(b);
            carregarBeneficio(beneficio);
        }

        private void carregarBeneficio(Beneficio beneficio)
        {
            txtNome.Text = beneficio.Nome;
            txtNivel.Text = beneficio.Nivel.ToString();
            txtDescricao.Text = beneficio.Descricao;
        }
        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            beneficio.Nome = txtNome.Text;
            beneficio.Nivel = Convert.ToInt32(txtNivel.Text);
            beneficio.Descricao = txtDescricao.Text;
            BeneficioDAO.EditBenefit(beneficio);
            MessageBox.Show("Beneficio " + beneficio.Nome + " alterado com sucesso!");
        }
    }
}