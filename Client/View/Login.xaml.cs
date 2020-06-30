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
            string tokenApp = AppToken.APPTOKEN;
            User user = new User(login,password);

           // MessageBox.Show(login + "  " + password);

            //creating the object of WCF service client         
            ServiceReference1.AuthServiceClient platform = new ServiceReference1.AuthServiceClient();

            //Setting the user credentials
            //platform.ClientCredentials = System.Net.CredentialCache.DefaultCredentials;
            /*platform.ClientCredentials.Windows.ClientCredential.Domain = "WORKSPACE";
            platform.ClientCredentials.Windows.ClientCredential.UserName = "AzureUser2";
            platform.ClientCredentials.Windows.ClientCredential.Password = "ProjetDev123";*/

            try
            {
                //assigning the output value from service Response         
                Client.ServiceReference1.UserToken auth = platform.AuthUser(login, password, tokenApp);
                //MessageBox.Show(auth.Id);

                if (auth != null)
                {

                    SendFile r = new SendFile();
                    r.userToken.Tag = auth.Id;
                    this.NavigationService.Navigate(r);
                }
                else
                {
                    MessageBox.Show("The password or username is incorect");
                }
            }
            catch (System.ServiceModel.Security.SecurityNegotiationException exc)
            {
                MessageBox.Show("Security keys negotiation failed");
            }
            catch (Exception exc)
            {

            }
            

            
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