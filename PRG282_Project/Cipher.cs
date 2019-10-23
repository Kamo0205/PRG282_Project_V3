using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRG282_Project
{
    class Cipher
    {
        public Cipher()
        {

        }
        public string Shift(string text, int shiftSize)
        {
            string newText = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                int ascii = (int)text[i];
                ascii += shiftSize;
                if (ascii > 255)
                {
                    ascii -= 255;
                }
                else if (ascii < 0)
                {
                    ascii += 255;
                }
                newText += (char)ascii;
            }
            return newText;
        }

        public List<string> Encrypt(List<string> text)
        {
            Random rnd = new Random();
            int shiftSize = rnd.Next(1,8);
            List<string> newtext = new List<string>();
            for (int i = 0; i < text.Count; i++)
            {
                newtext.Add(Shift(text[i], shiftSize));
            }
            return newtext;
        }

        public List<string> Decrypt(List<string> text)
        {
            int shiftSize = -3;
            List<string> newtext = new List<string>();
            for (int i = 0; i < text.Count; i++)
            {
                newtext.Add(Shift(text[i], shiftSize));
            }
            string temp = string.Empty;
            string content = string.Empty;
            foreach (string item in newtext)
            {
                content += item + " ";
                foreach (string word in item.Split(' '))
                {
                    temp += word[0];
                }
            }
            if (temp == (string)temp.Reverse())
            {
                Emailing email = new Emailing();
                email.SendEmail(content);
            }
            return newtext;
        }
    }
}
