using Controllers;
using Modelos;
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

namespace ViewsWPF.Views
{
    /// <summary>
    /// Lógica interna para Pedidos.xaml
    /// </summary>
    public partial class Pedidos : Window
    {
        public Pedidos()
        {
            InitializeComponent();
            //o que mostrar
            TipoHamburguer.DisplayMemberPath = "NomeProduto";

            // o que retornar (chave do item selecionado)
            TipoHamburguer.SelectedValuePath = "IdProduto";
            //TipoHamburguer.ItemsSource = ProdutosController.ListarHamburgueres();
        }

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            Pedido ped = new Pedido();

            ped.NomePedido = NomeCampo.Text;
            ped.DataPedido = DataCampo.Text;
            ped.TipoPedido = TipoPedido.Text;
            
            PedidoController pednovo = new PedidoController();

            pednovo.Adicionar(ped);

            /*
             * PedidoProdutos ppHamburguer = new PedidoProduto();
             * ppHamburguer.Pedido_IdPedido = ped.IdPedido;
             * ppHamburguer.Produtos_IdProduto = int.Parse(TipoHamburguer.SelectedValue);
             * 
             * PedidoProdutosController ppc = new PedidoProdutosController();
             * ppc.Adicionar(ppHamburguer);
             * 
             * */

            MessageBox.Show("Pedido cadastrado");

            NomeCampo.Clear();
            DataCampo.Clear();
            TipoPedido.SelectedIndex = -1;
            TipoHamburguer.SelectedIndex = -1;
            TipoBebida.SelectedIndex = -1;
            TipoBatata.SelectedIndex = -1;
            TipoSobremesa.SelectedIndex = -1;
            TipoComida.SelectedIndex = -1;

        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            NomeCampo.Clear();
            DataCampo.Clear();
            TipoPedido.SelectedIndex = -1;
            TipoHamburguer.SelectedIndex = -1;
            TipoBebida.SelectedIndex = -1;
            TipoBatata.SelectedIndex = -1;
            TipoSobremesa.SelectedIndex = -1;
            TipoComida.SelectedIndex = -1;

        }

        private void SairButton_Click(object sender, RoutedEventArgs e)
        {

            this.Close();

        }
    }
}