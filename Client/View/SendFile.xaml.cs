using System;
using System.Collections.Generic;
using System.IO;
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
using Client.Model;
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

        private void btnOnClickChooseFile(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();
            openFileDlg.Filter = "All files (*.txt)|*.txt";

            Nullable<bool> result = openFileDlg.ShowDialog();

            if (result == true)
            {
                FileNameTextBox.Text = openFileDlg.SafeFileName;
                FileNameTextBox.Tag = openFileDlg.FileName;
            }
        }

        private void btnOnClickSend(object sender, RoutedEventArgs e)
        {
           // if (String.IsNullOrEmpty(FileNameTextBox.Tag.ToString())) { 
            //Get File
            String tag = FileNameTextBox.Tag.ToString();
            //readFile
            StreamReader sr = new StreamReader(tag);
            String txt = sr.ReadToEnd();
            //Create Message
            // User user = new User();
             // Message msg = new Message();

            MessageBox.Show(txt);
           // }
        }

        private void btnOnClickExit(object sender, MouseButtonEventArgs e)
        {
            Login l = new Login();
            this.NavigationService.Navigate(l);
        }
    }
}
