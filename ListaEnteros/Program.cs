using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 2, 7, 11, 15 };
        int objetivo = 13;
        int[] resultado = EncontrarIndices(numeros, objetivo);

        if (resultado != null)
        {
            Console.WriteLine($"Los índices de los números que suman {objetivo} son: [{resultado[0]}, {resultado[1]}]");
        }
        else
        {
            Console.WriteLine("No se encontraron números que sumen el objetivo.");
        }

        // Espera a que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("Presiona cualquier tecla para cerrar la consola...");
        Console.ReadKey();
    }

    static int[] EncontrarIndices(int[] nums, int objetivo)
    {
        List<(int numero, int indice)> lista = new List<(int, int)>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complemento = objetivo - nums[i];

            // Busca el complemento en la lista
            foreach (var par in lista)
            {
                if (par.numero == complemento)
                {
                    return new int[] { par.indice, i };
                }
            }

            lista.Add((nums[i], i)); // Agrega el número y su índice a la lista
        }

        return null;
    }
}
