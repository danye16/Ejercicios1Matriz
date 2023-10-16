using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1Matriz
{
    internal class Ejercicios
    {
        public void Imprimir()
        {
            int[] arrelo = new int[5] { 1, 2, 3, 4, 5 };

            foreach (int i in arrelo) 
            {
                Console.WriteLine(i);
            }
        }


        public void Imprimir2()
        {
            int[] arrelo = new int[5];

            Console.WriteLine("Ingrese 5 numeros");
            for (int c=0; c<arrelo.Length; c++)
            {
                arrelo[c] = Convert.ToInt32(Console.ReadLine());
            }    

            foreach (int i in arrelo)
            {
                Console.WriteLine("Sus numeros son "+i);
            }
        }


        public void Media()
        {
            float[] arrelo = new float[10];
            float media = 0;
            float total = 0;
            Console.WriteLine("Ingrese 10 numeros");
            for (int c = 0; c < arrelo.Length; c++)
            {
                arrelo[c] = Convert.ToInt32(Console.ReadLine());
                media += arrelo[c];
               
            }
            total = media / arrelo.Length;
            Console.WriteLine("La media de sus numeros es " + total);

        }

        public void Multi()
        {
            int tamaño;
            int numero; 
            int total;
            Console.WriteLine("Ingrese El Tamaño de su arreglo");
            tamaño = Convert.ToInt32(Console.ReadLine());
            int[] arrelo = new int[tamaño];
            Console.WriteLine("Ingrese El numero por el que desea el multiplo");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int c = 0; c< tamaño; c++)
            {
                arrelo[c] = c * numero;
                Console.WriteLine($"Los multiplos son {numero} * {c} = " + arrelo[c]);
            }
            

        }

        public void Nombre()
        {
            int tamaño;
            int numero;
            int total;
            Console.WriteLine("Ingrese El Tamaño de su arreglo");
            tamaño = Convert.ToInt32(Console.ReadLine());
            string[] nombre = new string[tamaño];
            int[] arrelo1 = new int[tamaño];

            Console.WriteLine("Ingrese los nombres");

            for (int c = 0; c < tamaño; c++)
            {
                nombre[c]= Console.ReadLine();
                arrelo1[c] = nombre[c].Length;
                Console.WriteLine($"El nombre es {nombre[c]} y tiene una longitud de " + arrelo1[c]);
                

            }


        }

    }
}
