using Client.Model;
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
using System.Security.Cryptography;
using Client.Model;

namespace Client.View
{
    /// <summary>
    /// Logique d'interaction pour Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        private const string V = "f12458d120e6d32cf89ee714d35c723d8caa1273c3bcdf1ba79c63df7329254a";

        public Register()
        {
            InitializeComponent();
        }

        private void btnOnClickRegister(object sender, RoutedEventArgs e)
        {

            String login = this.username.Text;
            String password = this.password.Password;
            password = Sha256Hash(password);
            string tokenApp = V;
            User user = new User(login, password);

            MessageBox.Show(login + "  " + password);


            //creating the object of WCF service client         
           // ServiceReference.Service1Client platform = new ServiceReference.Service1Client();

            //assigning the output value from service Response         
          //  bool auth = platform.authentication(login, password, tokenApp);

          //  if (auth){
                Login l = new Login();
                this.NavigationService.Navigate(l);
          //  }

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
