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
    /// Lógica interna para Registro.xaml
    /// </summary>
    public partial class Registro : Window
    {
        public Registro()
        {
            InitializeComponent();
        }
        private void RegistrarNovo_Click(object sender, RoutedEventArgs e)
        {

            Usuario usuario = new Usuario
            {
                Login = RegistrarLogin.Text,
                Senha = senha.Password
            };

            UsuarioController user = new UsuarioController();

            user.Adicionar(usuario);

            MessageBox.Show("Usuário cadastrado com sucesso");

            Login log = new Login();

            log.Show();
            this.Hide();

        }

        private void cancela_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
