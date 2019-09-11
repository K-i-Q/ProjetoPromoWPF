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
using System.Windows.Shapes;

namespace ProjetoPromoWPF.View
{
    /// <summary>
    /// Lógica interna para frmEmpresaCadastro.xaml
    /// </summary>
    public partial class frmEmpresaCadastro : Window
    {
        public frmEmpresaCadastro()
        {
            InitializeComponent();
        }

        private void BtnCadastrarEmpresa_Click(object sender, RoutedEventArgs e)
        {
            Empresa empresa = new Empresa();
            Index home = new Index();

            empresa.CNPJ = txtCNPJ.Text;
            empresa.Razao = txtRazao.Text;
            empresa.Email = txtEmail.Text;
            empresa.Telefone = txtTelefone.Text;
            empresa.Senha = txtSenha.Text;

            EmpresaDAO.RegisterCompany(empresa);
            MessageBox.Show(empresa.Razao + " cadastrada com sucesso!");

            home.Show();
            this.Close();
        }
    }
}
