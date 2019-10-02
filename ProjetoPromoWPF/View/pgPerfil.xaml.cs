using ProjetoPromoWPF.DAL;
using ProjetoPromoWPF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
        frmLogin login;
        public pgPerfil(Empresa e)
        {
            InitializeComponent();

            empresa = EmpresaDAO.FindCompanyById(e.EmpresaId);
            carregarEmpresa(empresa);
        }

        private void carregarEmpresa(Empresa empresa)
        {
            txtCNPJ.Text = empresa.CNPJ;
            txtRazao.Text = empresa.Razao;
            txtEmail.Text = empresa.Email;
            txtTelefone.Text = empresa.Telefone;
            txtResponsavel.Text = empresa.Responsavel;
            txtCriadoEm.Text = empresa.CriadoEm.ToString();
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            fmDetalhesDaEmpresa.Content = new pgEditarPerfil(empresa);
        }

        private void BtnExcluir_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Tem certeza de que deseja excluir sua conta? Esta operação não pode ser revertida.", "Exclusão de Conta", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                login = new frmLogin();
                try
                {
                    EmpresaDAO.RemoveCompany(empresa);
                    MessageBox.Show("Sua conta foi excluída com sucesso, você será redirecionado para página de Login");
                    login.Show();
                    Window.GetWindow(this).Close();
                    
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("Primeiro você precisa deletar todos os seus benefícios, planos e parcerias. Faça isso e tente novamente");
                }

            }
            else
            {
                MessageBox.Show("Operação Cancelada!");
            }
        }
    }
}
