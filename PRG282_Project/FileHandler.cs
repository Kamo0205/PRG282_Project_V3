using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PRG282_Project
{
    class FileHandler
    {
        private string path;

        public FileHandler(string path)
        {
            this.path = path;
        }

        public string Path { get => path; }

        public List<string> Read()
        {
            List<string> text = new List<string>();
            FileStream fs;
            try
            {
                using (fs = new FileStream(this.Path, FileMode.Open,FileAccess.Read))
                {
                    StreamReader sr = new StreamReader(fs);
                    string line = string.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        text.Add(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                text.Add("File not found.");
            }
            
            return text;
        }

        public void Write(List<string> text)
        {
            try
            {
                FileStream clear = new FileStream(this.Path, FileMode.Truncate, FileAccess.Write);
                clear.Close();
                using (FileStream fs = new FileStream(this.Path, FileMode.Open, FileAccess.Write))
                {
                    StreamWriter sw = new StreamWriter(fs);
                    for (int i = 0; i < text.Count; i++)
                    {
                        sw.WriteLine(text[i]);
                        sw.Flush();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
