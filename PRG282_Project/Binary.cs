using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRG282_Project
{
    class Binary
    {
        Cipher cipher;
        public Binary()
        {
            cipher = new Cipher();
        }

        public List<string> ToBinary(List<string> text)
        {
            List<string> temp = new List<string>();
            text = cipher.Encrypt(text);
            for (int i = 0; i < text.Count; i++)
            {
                string letters = string.Empty;
                for (int j = 0; j < text[i].Length; j++)
                {
                    letters += Convert.ToString(text[i][j],2).PadLeft(8,'0');
                }
                temp.Add(letters);
            }
            return temp;
        }

        public List<string> ToString(List<string> text)
        {
            List<List<byte>> temp = new List<List<byte>>();
            for (int i = 0; i < text.Count; i++)
            {
                List<byte> tempBytes = new List<byte>();
                for (int j = 0; j < text[i].Length; j+=8)
			    {
                    tempBytes.Add(Convert.ToByte(text[i].Substring(i,8),2));
			    }
                temp.Add(tempBytes);
            }
            List<string> realText = new List<string>();
            for (int i = 0; i < temp.Count; i++)
			{
			    realText.Add(Encoding.ASCII.GetString(temp[i].ToArray()));
			}
            return cipher.Decrypt(realText);
        }
    }
}
