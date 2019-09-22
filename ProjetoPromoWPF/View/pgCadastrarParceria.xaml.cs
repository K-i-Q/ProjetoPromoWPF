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
    /// Interação lógica para pgCadastrarParceria.xam
    /// </summary>
    public partial class pgCadastrarParceria : Page
    {
        EmpresaEmpresa parceria;
        Empresa empresaUm;
        Empresa empresaDois;
        public pgCadastrarParceria(Empresa e)
        {
            InitializeComponent();

            empresaUm = e;
        }

        private void BtnCadastrarParceria_Click(object sender, RoutedEventArgs e)
        {
            empresaDois = EmpresaDAO.FindCompanyByName(txtNome.Text);

            parceria = new EmpresaEmpresa();

            parceria.EmpresaUmId = empresaUm.EmpresaId;
            parceria.EmpresaUm = empresaUm;
            parceria.EmpresaDoisId = empresaDois.EmpresaId;
            parceria.EmpresaDois = empresaDois;
            if (!parceria.EmpresaUm.Equals(parceria.EmpresaDois))
            {
                EmpresaEmpresaDAO.RegisterPartner(parceria);
                MessageBox.Show("Parceria feita entre: " + parceria.EmpresaUm.Razao + " e " + parceria.EmpresaDois.Razao+" efetuada com sucesso!");
            }
            else
            {
                MessageBox.Show("Empresas iguais. Escolha uma empresa diferente para fazer parcerias.");
            }


        }
    }
}
