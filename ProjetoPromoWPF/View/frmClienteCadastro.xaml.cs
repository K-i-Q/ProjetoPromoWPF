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
    /// Lógica interna para frmClienteCadastro.xaml
    /// </summary>
    public partial class frmClienteCadastro : Window
    {
        public frmClienteCadastro()
        {
            InitializeComponent();
        }

        private void BtnCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente();
            HomeCliente home;

            if (Validacoes.ValidaCPF(txtCPF.Text))
            {
                cliente.CPF = txtCPF.Text;
                if (Validacoes.ValidaNome(txtNome.Text))
                {
                    cliente.Nome = txtNome.Text;

                    if (Validacoes.ValidaData(txtDataNascimento.Text))
                    {
                        cliente.DataNascimento = txtDataNascimento.Text;
                        if (Validacoes.ValidaGenero(txtGenero.Text))
                        {
                            cliente.Genero = txtGenero.Text;
                            if (Validacoes.ValidaEmail(txtEmail.Text))
                            {
                                cliente.Email = txtEmail.Text;
                                if (Validacoes.ValidaSenha(txtSenha.Text))
                                {
                                    cliente.Senha = txtSenha.Text;
                                    //TODO
                                    if (Validacoes.ValidaTelefone(txtTelefone.Text))
                                    {
                                        cliente.Telefone = txtTelefone.Text;

                                        ClienteDAO.RegisterClient(cliente);
                                        MessageBox.Show(cliente.Nome + " cadastrado com sucesso!");
                                        home = new HomeCliente(cliente);
                                        home.Show();
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Telefone invalida!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Senha invalida!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Email invalido!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Genero invalido!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data de nascimento inválida!");
                    }
                }
                else
                {
                    MessageBox.Show("Nome inválido!");
                }
            }
            else
            {
                MessageBox.Show("CPF inválido!");
            }
            

                
            
            
            
        }
    }
}
