using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Windows;
using Microsoft.Win32;

namespace Client.Model
{
    class Filex
    {
        string filePath;
        string text;
        string nameFile;

        public Filex(string f, string t, string n)
        {
            filePath = f;
            text = t;
            nameFile = n;
        }
        public Filex(string f)
        {
            filePath = f;
        }

        public string FilePath { get => filePath; set => filePath = value; }
        public string Text { get => text; set => text = value; }
        public string NameFile { get => nameFile; set => nameFile = value; }

        public string readFile()
        {
            StreamReader sr = new StreamReader(this.FilePath);
            
            // Read the file and put it in the attribut
            string line = sr.ReadToEnd();
            this.text = line;
            return line;
        }
        public string gettext()
        {


            return null;
        }
        public void createPdf(int confidence )
        {
           // MessageBox.Show(this.filePath);
          //  PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream(this.filePath, FileMode.Create, FileAccess.Write)));
           // String path = "C:\\Users\\thoma\\Desktop\\testDufutureincroyabesdqzdzddddddddddddddddddd.txt";
            //PdfDocument pdfDocument = new PdfDocument(new PdfWriter(new FileStream(path, FileMode.Create, FileAccess.Write)));
          //  Document document = new Document(pdfDocument);

            String line = this.text;
           // document.Add(new Paragraph(line + " = " + confidence + " = " + nameFile));
            //document.Close();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
           // if (saveFileDialog.ShowDialog() == true)
            //    Filex.WriteAllText(saveFileDialog.FileName, txtEditor.Text);

           // pdfDocument.Close();
        }

    }
}
