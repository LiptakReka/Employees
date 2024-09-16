using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace Employees
{
    internal class Program
    {
         static List<string> listaadat = new List<string>();
        static void Main(string[] args)
        {
           string[] adatok= File.ReadAllLines("tulajdonsagok_100sor.txt");
            for (int i = 0; i < adatok.Length; i++)
            {
                string id = adatok[i].Split(';')[0];
                string nev = adatok[i].Split(';')[1];
                string kor = adatok[i].Split(';')[2];
                string fzetes = adatok[i].Split(';')[3];

                listaadat.Add(id);
                listaadat.Add(nev);
                listaadat.Add(kor);
                listaadat.Add(fzetes);
            }
            

        }
    }
}
