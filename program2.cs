using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int quispe;
            for (quispe = 10; quispe >= 1; quispe--) {
                Console.WriteLine(quispe);
            }
            Console.ReadKey();

            //Primera a ultima
            string txt = "Lionel";
            for(int i = 0; i< txt.Length; i++)
            {
                Console.Write(txt[i]);
            }

            Console.WriteLine();

            //ultima a primera
            for (int i = txt.Length - 1; i >= 0; i--) {
                Console.WriteLine(txt[i]);
            }
            Console.ReadKey();
        }
    }
}
