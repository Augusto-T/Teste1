using System;
using System.Windows;
using System.IO;

namespace Teste1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            
            InitializeComponent();

            if (File.Exists(@"C:\Users\augusto.t\Documents\Licença\Licença.bin") == true)
                {
                    string valor;
                    using (FileStream fs = new FileStream(@"C:\Users\augusto.t\Documents\Licença\Licença.bin", FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs))
                        {
                            valor = sr.ToString().Trim();
                            fs.Position = 0;

                            using (BinaryReader br = new BinaryReader(fs))
                            {
                                Console.WriteLine(br.ReadString());
                                if (valor.Equals(sr.ToString()))
                                {
                                    Sarf TelaSarf = new Sarf();
                                    TelaSarf.Show();
                                    this.Close();
                                }
                            }
                        }
                    }
             
                }
                else
                {
                    this.Show();
                    imgFalse.Visibility = Visibility.Visible;
                    lbTextoFalse.Visibility = Visibility.Visible;
                }
        }

        private void OkButton(object sender, RoutedEventArgs e)
        {
            INotifyPropertyChanged TelaLogin = new INotifyPropertyChanged();
            TelaLogin.Show();
                   
        }

        private void VerificButton(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
