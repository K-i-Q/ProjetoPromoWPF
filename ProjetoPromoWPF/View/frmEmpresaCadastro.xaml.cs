using ProjetoPromoWPF.DAL;
using ProjetoPromoWPF.Model;
using ProjetoPromoWPF.Util;
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
            HomeEmpresa home;

            if (Validacoes.ValidaCNPJ(txtCNPJ.Text))
            {
                empresa.CNPJ = txtCNPJ.Text;

                if (Validacoes.ValidaNome(txtRazao.Text))
                {
                    empresa.Razao = txtRazao.Text;

                    if (Validacoes.ValidaEmail(txtEmail.Text))
                    {
                        empresa.Email = txtEmail.Text;

                        if (Validacoes.ValidaTelefone(txtTelefone.Text))
                        {
                            empresa.Telefone = txtTelefone.Text;

                            if (Validacoes.ValidaSenha(txtSenha.Password.ToString()))
                            {
                                empresa.Senha = txtSenha.Password.ToString();
                                empresa.Responsavel = txtResponsavel.Text;
                                EmpresaDAO.RegisterCompany(empresa);
                                MessageBox.Show(empresa.Razao + " cadastrada com sucesso!");

                                home = new HomeEmpresa(empresa);
                                home.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Senha inválida!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Telefone inválido!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email inválido!");
                    }
                }
                else
                {
                    MessageBox.Show("Nome inválido!");
                }
            }
            else
            {
                MessageBox.Show("CNPJ inválido!");
            }


            
        }

        private void BtnVoltar_Click(object sender, RoutedEventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.Show();
            this.Close();
        }
    }
}
