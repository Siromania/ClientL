using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text;
using System.Security.Cryptography;
using Client.Model;

namespace Client.View
{
    /// <summary>
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnOnClickLogin(object sender, RoutedEventArgs e)
        {
            String login = this.Username.Text;
            String password = this.Password.Password;
            password = Sha256Hash(password);
            string tokenApp = "f12458d120e6d32cf89ee714d35c723d8caa1273c3bcdf1ba79c63df7329254a";
            User user = new User(login,password);

            MessageBox.Show(login + "  " + password);


            //creating the object of WCF service client         
           //ServiceReference.Service1Client platform = new ServiceReference.Service1Client();

            //assigning the output value from service Response         
           // bool auth = platform.authentication(login, password, tokenApp);

           // if (auth) { 
                SendFile r = new SendFile();
                this.NavigationService.Navigate(r);
         //   }
        }

        private void btnOnClickRegister(object sender, RoutedEventArgs e)
        {

                Register r = new Register();
                this.NavigationService.Navigate(r);
        }

        static string Sha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}