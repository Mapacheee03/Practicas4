using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas4
{
    internal class Practica
    {
        public void Practicaa() 
        {
            // a) Declarar y crear la matriz t
            int[,] t = new int[3, 4]; // Supongamos que es una matriz 3x4

            // b) Número de filas
            int numRows = t.GetLength(0);

            // c) Número de columnas
            int numCols = t.GetLength(1);

            // d) Número de elementos
            int numElements = numRows * numCols;

            // e) Expresiones de acceso para la fila 1
            for (int i = 0; i < numCols; i++)
            {
                int element = t[0, i];
                Console.WriteLine(element);
            }

            // f) Expresiones de acceso para la columna 2
            for (int i = 0; i < numRows; i++)
            {
                int element = t[i, 1];
                Console.WriteLine(element);
            }

            // g) Asignar cero al elemento en la fila 0 y columna 1
            t[0, 1] = 0;

            // h) Inicializar todos los elementos de t con cero (sin instrucción de repetición)
            Array.Clear(t, 0, numElements);

            // i) Inicializar cada elemento de t con cero usando una instrucción for anidada
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    t[i, j] = 0;
                }
            }

            // j) Inicializar la matriz con entrada de usuario
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    Console.Write("Ingrese el valor para t[" + i + "][" + j + "]: ");
                    t[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // k) Encontrar el valor más pequeño en t
            int min = t[0, 0];
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    if (t[i, j] < min)
                    {
                        min = t[i, j];
                    }
                }
            }
            Console.WriteLine("El valor más pequeño en t es: " + min);

            // l) Imprimir la primera fila de t
            for (int i = 0; i < numCols; i++)
            {
                Console.Write(t[0, i] + " ");
            }
            Console.WriteLine();

            // m) Totalizar los elementos de la tercera columna
            int total = 0;
            for (int i = 0; i < numRows; i++)
            {
                total += t[i, 2];
            }
            Console.WriteLine("La suma de la tercera columna es: " + total);

            // n) Imprimir la matriz en formato tabular
            Console.WriteLine("Matriz t en formato tabular:");
            Console.Write("  ");
            for (int i = 0; i < numCols; i++)
            {
                Console.Write("Col " + i + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < numRows; i++)
            {
                Console.Write("Fila " + i + " ");
                for (int j = 0; j < numCols; j++)
                {
                    Console.Write(t[i, j] + " ");
                }
                Console.WriteLine();
            }
    }
}
