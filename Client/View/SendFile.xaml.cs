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
                string tokenApp = AppToken.APPTOKEN;

                Filex f = new Filex(fileName);
                string txt = f.readFile();
                Object[] data = new Object[]{
                        f.FilePath,
                        txt
                    };

                Client.ServiceReference2.STG msg = new Client.ServiceReference2.STG();
                msg.StatusOp = statusOp;
                msg.OperationVersion = operationVersion;
                msg.AppVersion = appVersion;
                msg.OperationName = operationName;
                msg.Info = info;
                msg.TokenUser = tokenUser;
                msg.TokenApp = tokenApp;
                msg.Data = data;



                Task task = new Task((message) =>
                {
                     Client.ServiceReference2.STG call = platform.m_service((STG)message);
                    //System.Diagnostics.Debug.WriteLine("Return of the call = " + fileName + " - " + call.Info + " " + call.OperationName );
                    System.Diagnostics.Debug.WriteLine("Return of the call = " + fileName + " - " + call.Info  + " " + call.OperationVersion);
                    //MessageBox.Show("Return of the call = " + fileName +" - "+ call.StatusOp.ToString());
                }, msg);

                tasks.Add(task);
                task.Start();
                System.Diagnostics.Debug.WriteLine("Task lancé");

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
