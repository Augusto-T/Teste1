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
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Teste1
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class INotifyPropertyChanged : Window
    {
        

        public INotifyPropertyChanged()
        { 
            
            InitializeComponent();
        }


        private void Validation()
        {
            User user = new User();
            user.Name = "Augusto";
            user.Senha = "1234";


            string testeuser = usuario.Text;
            string testesenha = password.Password.ToString();

            if (usuario.Text == string.Empty || password.Password.ToString() == string.Empty)
            {
                MessageBox.Show("Preencha todos os campos para executar o login!", "Alerta!");

            }
            else if (testeuser == user.Name && testesenha == user.Senha )
            {
                this.Close();

            }
            else
            {
                MessageBox.Show("A senha ou nome de usuario não constam como validos em nosso" +
                   " banco de dados, verifique se os valores estao corretos e tente o login novamente",
                   "Senha ou nome de usuário inválidos.");

                usuario.Clear();
                password.Clear();

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Validation();

        }

     
    }
}



