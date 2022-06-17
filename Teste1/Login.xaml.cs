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



 //<Grid Height="145" Width="460" VerticalAlignment="Top" Margin="0,84,0,0" >
 //       <Label Content="User:"  Margin="226,12,21,0" VerticalAlignment="Top" FontSize="14"/>
 //       <Label Content="Senha:"  Margin="226,42,11,0" VerticalAlignment="Top" FontSize="14"/>
 //       <TextBox HorizontalAlignment="Left" Name="UsuarioTextBox" Margin="290,16,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="120"/>
 //       <TextBox HorizontalAlignment="Left" Name="PasswordBox" Margin="290,47,0,0" VerticalAlignment="Top" Width="120"/>
 //       <Button Content="Logar" HorizontalAlignment="Left" Margin="349,72,0,0" VerticalAlignment="Top" Width="61" Click="Button_Click"/>
 //       <Image HorizontalAlignment="Left" Height="126" Margin="36,0,0,0" VerticalAlignment="Top" Width="125" Source="/295128.png"/>

 //   </Grid>