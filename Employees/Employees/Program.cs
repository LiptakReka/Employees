using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace Employees
{
    public class employee
    {
        public int id { get; set; }
        public string nev { get; set; }
        public int kor { get; set; }
        public int fizetes { get; set; }


        public employee(int id, string nev, int kor, int fizetes)
        {
            this.id = id;
            this.nev = nev;
            this.kor = kor;
            this.fizetes = fizetes;
        }
    }
    internal class Program
    {
         static List<employee> listaadat = new List<employee>();
        static void Main(string[] args)
        {
           string[] adatok= File.ReadAllLines("tulajdonsagok_100sor.txt");
            for (int i = 0; i < adatok.Length; i++)
            {
                string[] reszek = adatok[i].Split(';');
                int id = int.Parse(reszek[0]);
                string nev = reszek[1];
                int kor = int.Parse(reszek[2]);
                int fzetes = int.Parse(reszek[3]);

                listaadat.Add(new employee(id, nev, kor, fzetes));

            }

            //1.feladat
            Console.WriteLine("Dolgozók nevei:");
            foreach (var employe in listaadat)
            {
                Console.WriteLine(employe.nev);
            }

            int legmagasabb =listaadat.Max(x => x.fizetes);
            var top =listaadat.Where(x => x.fizetes==legmagasabb).ToList();


            Console.WriteLine("A legmagasabb fizetéssel bíró tag: ");
            foreach (var fizetesek in top)
            {
                Console.WriteLine($"Id : {fizetesek.id} neve: {fizetesek.nev} kora : {fizetesek.kor}  Fizetése: {fizetesek.fizetes}");
            }
        }
    }
}
