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
    /// Interação lógica para pgEmpresasContratadas.xam
    /// </summary>
    public partial class pgEmpresasContratadas : Page
    {
        Empresa empresa;
        Context ctx = SingletonContext.GetInstance();
        public pgEmpresasContratadas(Empresa e)
        {
            InitializeComponent();
            empresa = e;
            carregarParceirosDaEmpresaContratadaPeloCliente(empresa);
        }

        private void carregarParceirosDaEmpresaContratadaPeloCliente(Empresa empresa)
        {
            List<EmpresaEmpresa> parcerias = new List<EmpresaEmpresa>();
            List<Empresa> parceiros = new List<Empresa>();
            try
            {
                parcerias = ctx.Parceiros.Where(x => x.EmpresaUm.Beneficios.Equals(empresa)).ToList();
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
            }

            foreach (EmpresaEmpresa parceria in parcerias)
            {
                parceiros.Add(EmpresaDAO.FindCompanyById(parceria.EmpresaDoisId));
            }

            listaDeParceiros.ItemsSource = parceiros;
        }

        private void BtnAcessarBeneficio_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
