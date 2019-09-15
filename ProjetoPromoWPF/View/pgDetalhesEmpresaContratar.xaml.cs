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
    /// Interação lógica para pgDetalhesEmpresaContratar.xam
    /// </summary>
    public partial class pgDetalhesEmpresaContratar : Page
    {
        Context ctx = SingletonContext.GetInstance();
        public pgDetalhesEmpresaContratar(Empresa e)
        {
            InitializeComponent();
            listarDetalhesDaEmpresa(e);
        }
        private void listarDetalhesDaEmpresa(Empresa e)
        {
            txtCnpj.Text = e.CNPJ;
            txtEmail.Text = e.Email;
            txtRazao.Text = e.Razao;
            txtTelefone.Text = e.Telefone;
            listaDePlanos.ItemsSource = ctx.Planos.Where(x => x.Empresa.EmpresaId.Equals(e.EmpresaId)).ToList();
        }
    }
}
