using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kockapoker
{
  class Program
  {
    static void Ellenorzes()
    {
      StreamReader be = new StreamReader("teszteles.txt");

      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split(',');

        List<int> sz = a.Select(x => int.Parse(x)).ToList();
        
        Dobas d = new Dobas(sz[0], sz[1], sz[2], sz[3], sz[4]);

        d.Kiiras();
      }

      be.Close();
    }
    static void Main(string[] args)
    {
            //Ellenorzes();

            //Dobas gep = new Dobas();
            //Dobas ember = new Dobas();

            //gep.EgyDobas();
            //ember.EgyDobas();

            //gep.Kiiras();
            //ember.Kiiras();


            Console.ReadLine();
    }
  }
}
