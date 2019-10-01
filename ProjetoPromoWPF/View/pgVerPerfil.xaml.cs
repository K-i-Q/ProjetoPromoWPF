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
    /// Interação lógica para pgVerPerfil.xam
    /// </summary>
    public partial class pgVerPerfil : Page
    {
        Empresa empresa;
        public pgVerPerfil(Empresa e)
        {
            InitializeComponent();

            empresa = EmpresaDAO.FindCompanyById(e.EmpresaId);
            carregarDetalhesDaEmpresa(empresa);
        }

        private void carregarDetalhesDaEmpresa(Empresa empresa)
        {
            txtCNPJ.Text = empresa.CNPJ;
            txtRazao.Text = empresa.Razao;
            txtEmail.Text = empresa.Email;
            txtTelefone.Text = empresa.Telefone;
            txtCriadoEm.Text = empresa.CriadoEm.ToString();
        }
    }
}
