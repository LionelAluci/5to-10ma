using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string quispe = Console.ReadLine();
            Console.Clear();

            //for (int i = 0; i < quispe.Length; i++)
            //{
                //for (int j = 0; j < i; j++)
                //{
                //    Console.Write(" ");
                //}
                //Console.SetCursorPosition(i, i);
                //Console.WriteLine(quispe[i]);
                //Console.SetCursorPosition((quispe.Length-1) - i, i);
                //Console.WriteLine(quispe[i]);
            //}
            for (int i = 0, j = quispe.Length - 1; i < quispe.Length; i++, j--)
            {
                Console.SetCursorPosition(i, i);
                Console.Write(quispe[i]);
                Console.SetCursorPosition(j, i);
                Console.Write(quispe[i]);

            }
            Console.ReadKey();
        }
    }
}
