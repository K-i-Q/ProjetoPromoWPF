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
        Cliente cliente;
        EmpresaCliente empresaCliente;
        public pgEmpresasContratadas(Empresa e, Cliente c)
        {
            InitializeComponent();
            empresa = EmpresaDAO.FindCompanyById(e.EmpresaId);
            cliente = ClienteDAO.FindClientById(c.ClienteId);
            empresaCliente = EmpresaClienteDAO.ContratacaoDoClienteDaEmpresa(empresa, cliente);
            carregarParceirosDaEmpresaContratadaPeloCliente(empresa);
        }

        private void carregarParceirosDaEmpresaContratadaPeloCliente(Empresa empresa)
        {
            List<EmpresaEmpresa> parcerias = new List<EmpresaEmpresa>();
            List<Empresa> parceiros = new List<Empresa>();
            parcerias = EmpresaEmpresaDAO.ParceirosDaEmpresa(empresa);

            foreach (EmpresaEmpresa parceria in parcerias)
            {
                switch (empresaCliente.Nivel)
                {
                    case 1:
                        parceiros.Add(EmpresaDAO.FindCompanyById(parceria.EmpresaDoisId));
                        break;
                    case 2:
                        parceiros.Add(EmpresaDAO.FindCompanyById(parceria.EmpresaDoisId));
                        
                        foreach (EmpresaEmpresa parceriaDaParceria in EmpresaEmpresaDAO.ParceirosDaEmpresa(EmpresaDAO.FindCompanyById(parceria.EmpresaDoisId)))
                        {
                            parceiros.Add(EmpresaDAO.FindCompanyById(parceriaDaParceria.EmpresaDoisId));
                        }
                        break;
                    case 3:
                        parceiros.Add(EmpresaDAO.FindCompanyById(parceria.EmpresaDoisId));

                        foreach (EmpresaEmpresa parceriaDaParceria in EmpresaEmpresaDAO.ParceirosDaEmpresa(EmpresaDAO.FindCompanyById(parceria.EmpresaDoisId)))
                        {
                            parceiros.Add(EmpresaDAO.FindCompanyById(parceriaDaParceria.EmpresaDoisId));
                            foreach (EmpresaEmpresa parceriaDaParceriaDaParceria in EmpresaEmpresaDAO.ParceirosDaEmpresa(EmpresaDAO.FindCompanyById(parceriaDaParceria.EmpresaDoisId)))
                            {
                                parceiros.Add(EmpresaDAO.FindCompanyById(parceriaDaParceriaDaParceria.EmpresaDoisId));
                            }
                        }
                        break;
                    default:
                        break;
                }

                
            }

            listaDeParceiros.ItemsSource = parceiros;
        }

        private void BtnAcessarBeneficio_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
