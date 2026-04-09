using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string milagros = " ";
            //int soledad = 0;

            //Console.Write("escribi algo pe causa: ");
            //milagros = Console.ReadLine().ToLower();

            //for (int i = 0; i < milagros.Length; i++)
            //{
            //    if (milagros[i] == 'a' || milagros[i] == 'e' || milagros[i] == 'i' || milagros[i] == 'o' || milagros[i] == 'u')
            //    {
            //        soledad++;
            //    }
            //}
            //Console.WriteLine("Cantidad de vocales: " + soledad);
            //Console.ReadKey();


            //ej 2

            //string milagros = " ";
            //string soledad = " ";

            //Console.Write("escribi algo pe causa: ");
            //milagros = Console.ReadLine();

            //for (int i = milagros.Length - 1; i >= 0; i--) { 
            //    soledad += milagros[i];  

            //}
            //Console.WriteLine("invertido " + soledad);
            //Console.ReadKey();


            //ej 3

            //string fras = " ";
            //string limp = " ";
            //string inv = " ";

            //Console.Write("Escribi algo: ");
            //fras = Console.ReadLine();

            //for (int i = 0; i < fras.Length; i++)
            //{
            //    if (fras[i] != ' ')
            //    {
            //        limp += fras[i];
            //    }
            //}

            //for (int i = limp.Length-1; i >= limp.Length; i--)
            //{
            //    inv += limp[i];
            //}

            //if(inv == fras)
            //{
            //    Console.WriteLine("Es palíndromo");
            //}

            //else
            //{
            //    Console.WriteLine("no es palíndromo");
            //}
            //Console.ReadKey();


            //ej4

            //string palab = " ";
            //string resul = " ";

            //Console.Write("escribi pe: ");
            //palab = Console.ReadLine().ToLower();

            //for (int i = 0; i < palab.Length; i++)
            //{
            //    char letra = palab[i];

            //    if(letra == 'z')
            //    {
            //        resul += 'a';
            //    }

            //    else
            //    {
            //        resul += (char)(letra + 1);
            //    }
            //}
            //Console.WriteLine(resul);
            //Console.ReadKey();


            //ej5

            //string mail;
            //string dominio = "";
            //bool encon = false;

            //Console.Write("Escribí tu mail: ");
            //mail = Console.ReadLine();

            //for (int i = 0; i < mail.Length; i++)
            //{
            //    if (encon)
            //    {
            //        dominio += mail[i];
            //    }

            //    if (mail[i] == '@')
            //    {
            //        encon = true;
            //    }
            //}

            //Console.WriteLine("Dominio: " + dominio);
            //Console.ReadKey();


            //ej6

            string frase;
            string resul = "";

            Console.Write("Escribí una frase en minúsculas: ");
            frase = Console.ReadLine();

            bool nuevaPalabra = true;

            for (int i = 0; i < frase.Length; i++)
            {
                if (nuevaPalabra && frase[i] != ' ')
                {
                    resul += Char.ToUpper(frase[i]);
                    nuevaPalabra = false;
                }
                else
                {
                    resul += frase[i];
                }

                if (frase[i] == ' ')
                {
                    nuevaPalabra = true;
                }
            }

            Console.WriteLine("Resultado: " + resul);
            Console.ReadKey();
        }
    }
}
