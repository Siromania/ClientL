using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
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
using Client.Model;
using Client.ServiceReference1;
using Client.ServiceReference2;

using Microsoft.Win32;

namespace Client.View
{
    /// <summary>
    /// Logique d'interaction pour SendFile.xaml
    /// </summary>
    public partial class SendFile : Page
    {
        public SendFile()
        {
            InitializeComponent();
        }

        Microsoft.Win32.OpenFileDialog openFileDlgGlobal ;

        private void btnOnClickChooseFile(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            openFileDlg.Filter = "All files (*.txt)|*.txt";
            openFileDlg.Multiselect = true;

            Nullable<bool> result = openFileDlg.ShowDialog();

            if (result == true)
            {
                ListFile.ItemsSource = openFileDlg.SafeFileNames;
                //message += Path.GetFileName(file) + " - " + file + Environment.NewLine;
            }
            openFileDlgGlobal = openFileDlg;
        }

        private void btnOnClickSend(object sender, RoutedEventArgs e)
        {
            List<Task> tasks = new List<Task>();
            ServiceReference2.DecryptClient platform = new ServiceReference2.DecryptClient();
            //Client.ServiceReference1.UserToken auth = platform.AuthUser(login, password, "d");
            foreach (string fileName in openFileDlgGlobal.FileNames)
            {

                bool statusOp = false;
                string operationVersion = "1";
                string appVersion = "toto";
                string operationName = "m_service";
                string info = "Envoi du msg a .net";
                string tokenUser = this.userToken.Tag.ToString();
                NameValueCollection appConfig = ConfigurationManager.AppSettings;
                string tokenApp = appConfig.Get("AppToken");

                Filex f = new Filex(fileName);
                string txt = f.readFile();
                Object[] data = new Object[]{
                        f.FilePath,
                        txt
                    };

                Task task = new Task(() =>
                {
                    Client.ServiceReference2.STG msg = new STGClient(statusOp, operationVersion, appVersion, operationName, info, tokenUser, tokenApp, data);
                    Client.ServiceReference2.STG call = platform.m_service(msg);
                    System.Diagnostics.Debug.WriteLine("Return of the call = " + fileName + " - " + call.StatusOp.ToString());
                    //MessageBox.Show("Return of the call = " + fileName +" - "+ call.StatusOp.ToString());
                });

                tasks.Add(task);
                task.Start();

            }
            //Task.WaitAll(tasks.ToArray());

        }

        private void btnOnClickExit(object sender, MouseButtonEventArgs e)
        {
            Login l = new Login();
            this.NavigationService.Navigate(l);
        }
    }
}
