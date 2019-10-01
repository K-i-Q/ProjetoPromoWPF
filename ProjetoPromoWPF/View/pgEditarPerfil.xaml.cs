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
    /// Interação lógica para pgEditarPerfil.xam
    /// </summary>
    public partial class pgEditarPerfil : Page
    {
        Empresa empresa;
        public pgEditarPerfil(Empresa e)
        {
            InitializeComponent();

            empresa = EmpresaDAO.FindCompanyById(e.EmpresaId);

            carregarDadosDaEmpresa(empresa);
        }

        private void carregarDadosDaEmpresa(Empresa empresa)
        {
            txtRazao.Text = empresa.Razao;
            txtEmail.Text = empresa.Email;
            txtTelefone.Text = empresa.Telefone;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Operação cancelada!");
            carregarDadosDaEmpresa(empresa);
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            empresa.Razao = txtRazao.Text;
            empresa.Email = txtEmail.Text;
            empresa.Telefone = txtTelefone.Text;

            if (MessageBox.Show("Deseja salvar as alterações feitas em seu cadastro?","Salvar Alterações",MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                EmpresaDAO.EditCompany(empresa);
                MessageBox.Show("Alterações salvas com sucesso!");
            }
            else
            {
                MessageBox.Show("Operação cancelada!");
            }
        }
    }
}
