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
    /// Interação lógica para uclAlterarPlano.xam
    /// </summary>
    public partial class uclAlterarPlano : UserControl
    {
        Plano plano;
        public uclAlterarPlano(Plano p)
        {
            InitializeComponent();
            plano = PlanoDAO.FindPlanById(p.PlanoId);

            carregarPlanoDaEmpresa(plano);
        }

        private void carregarPlanoDaEmpresa(Plano plano)
        {
            txtNome.Text = plano.Nome;
            txtDescricao.Text = plano.Descricao;
            txtPreco.Text = plano.Preco.ToString();
            txtNivel.Text = plano.Nivel.ToString();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Operação Cancelada!");
            carregarPlanoDaEmpresa(plano);
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Deseja salvar essas alterações?","Salvar Alterações",MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                plano.Nome = txtNome.Text;
                plano.Descricao = txtDescricao.Text;
                plano.Preco = Convert.ToDouble(txtPreco.Text);
                plano.Nivel = Convert.ToInt32(txtNivel.Text);

                PlanoDAO.EditPlan(plano);
                MessageBox.Show("Alterações salvas com sucesso!");
            }
            else
            {
                MessageBox.Show("Operação Cancelada!");
            }
           
        }
    }
}
