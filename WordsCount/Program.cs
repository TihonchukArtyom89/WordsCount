using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = String.Empty;
            string[] txt;
            StreamReader sr = new StreamReader("F:\\Downloads\\MEGA\\text_source.txt",Encoding.Default);
            while (sr.EndOfStream != true)
            {
                s = sr.ReadLine();
            }
            txt = s.Split(' ');
            Console.WriteLine("Количество слов:{0}",txt.Length);
            sr.Close();
            Console.ReadLine();
        }
    }
}
