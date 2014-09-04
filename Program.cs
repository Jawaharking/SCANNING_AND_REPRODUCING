using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
       
        static void Main(string[] args)
        {
             string j;
             string[] i;
             string newk;
             string numbers;
             string hi;
        label:
            Console.Clear();
           j = Console.ReadLine();
           hi = j;
           i = j.Split(' ');
           for (int i1 = 0; i1 < i.Length; i1++)
           {
               newk = i[i1].Substring(0, 1);
               string nn = newk;
              numbers = nn.ToUpper();
               //hi = hi.Remove(newk,0);
              hi = hi.Replace(newk, numbers.ToUpper());
              
               //ks = ks + ks;
              // Console.WriteLine(ks);
               //a = Convert.ToDouble(int.Parse(newk));
               //b = Convert.ToDouble(k);
               //newj = Convert.ToInt32(Math.Pow(a, b));
               //k1 = newj + k1;

           }
           Console.WriteLine(hi);
           Console.ReadKey();
          // goto label;
            goto label;
        }
    }
}
