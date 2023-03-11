using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograDia11DeMarzo
{
    class Program
    {
        static void saludo(string nombre)
        {
            Console.WriteLine($"Hola {nombre} gusto de saludarle:");
        }

        static void desglose(string nom)
        {
            string nuevo = nom.ToUpper();
            string r = "";
            int longitud = nom.Length;
            char letra = 'a';
            char palabras = letra;


            for (int c = 0; c < nuevo.Length; c++)
            {
                Console.SetCursorPosition(10 + c, 10);
                Console.WriteLine(nuevo[c] + " ");

                for (int c = nuevo.Length; c > 0; c--)
                {
                    r = r + nuevo[c].ToString().ToLower();
                }
               
         
                
            }
            Console.WriteLine(nom [2]);

            Console.WriteLine("minusculas= " + r);

            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine();

            if (EsPalindromo(palabra))
            {
                Console.WriteLine($"{palabra} es un palíndromo");
            }
            else
            {
                Console.WriteLine($"{palabra} no es un palíndromo");
            }

            bool EsPalindromo(string palabraa)
            {
                palabraa = palabra.ToLower();

                int longitudd = palabra.Length;
                for (int i = 0; i < longitudd / 2; i++)
                {
                    if (palabra[i] != palabra[longitudd - i - 1])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        static int calculo(int edad)
        {
            int añoNac = 2023 - edad;
            return añoNac;

        }

        static void Main(string[] args)
        {
            string nombre;
            int edad;
            int año;

            

            desglose("Maria");

            Console.WriteLine("Cual es tu nombre: ");
            nombre = Console.ReadLine();
            saludo(nombre);
            Console.WriteLine("cuantos años tienes?");
            edad = Convert.ToInt32(Console.ReadLine());
            año = calculo(edad);
            Console.WriteLine($"naciste en el año: {año}");

                
            Console.WriteLine($"Wow {nombre} esa edad de {edad} es genial");
            Console.ReadLine();
        }
    }
}
