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
    /// Interação lógica para pgListaParceria.xam
    /// </summary>
    public partial class pgListaParceria : Page
    {
        Empresa empresa;
        public pgListaParceria(Empresa e)
        {
            InitializeComponent();
            empresa = e;
            listarParceiros(empresa);
        }

        private void listarParceiros(Empresa empresa)
        {
            Context ctx = SingletonContext.GetInstance();

            List<Empresa> listaParceiros = new List<Empresa>();
            List<EmpresaEmpresa> listaParcerias = ctx.Parceiros.Where(x => x.EmpresaUm.EmpresaId.Equals(empresa.EmpresaId)).ToList();


            foreach (EmpresaEmpresa parceria in listaParcerias)
            {
                listaParceiros.Add(EmpresaDAO.FindCompanyById(parceria.EmpresaDoisId));
            }

            listaParceria.ItemsSource = listaParceiros;
        }
    }
}