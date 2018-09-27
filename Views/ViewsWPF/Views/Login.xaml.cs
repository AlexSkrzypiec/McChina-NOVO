using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using ViewsWPF.Views;

namespace ViewsWPF
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        private void entrar_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B9FOF0O;Initial Catalog=McChinaDBNovo3;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Usuario WHERE Login='" + login.Text + "' AND Senha='" + senhalogin.Password + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                Pedidos ped = new Pedidos();
                ped.Show();
                this.Hide();

            }
            else

                MessageBox.Show("Usuário ou senha inválidos");
            }

        private void cancela_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }

    }
}
