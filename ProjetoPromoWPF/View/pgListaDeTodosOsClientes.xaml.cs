﻿using ProjetoPromoWPF.DAL;
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
    /// Interação lógica para pgListaDeTodosOsClientes.xam
    /// </summary>
    public partial class pgListaDeTodosOsClientes : Page
    {
        public pgListaDeTodosOsClientes()
        {
            InitializeComponent();
            listarTodosOsClientes();
        }
        private void listarTodosOsClientes()
        {
            listaDeTodosOsClientes.ItemsSource = ClienteDAO.ShowClients();
        }
    }
}
