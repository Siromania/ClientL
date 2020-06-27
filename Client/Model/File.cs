using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Client.Model
{
    class File
    {
        string filePath;
        string text;
        string nameFile;

        public File(string f, string t, string n)
        {
            filePath = f;
            text = t;
            nameFile = n;
        }

        public string FilePath { get => filePath; set => filePath = value; }
        public string Text { get => text; set => text = value; }
        public string NameFile { get => nameFile; set => nameFile = value; }

        public void readFile()
        {
            StreamReader sr = new StreamReader("TestFile.txt");
            
            // Read the file and put it in the attribut
            string line = sr.ReadToEnd();
            this.text = line;
        }
        public string gettext()
        {


            return null;
        }

    }
}
