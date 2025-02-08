using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int numeroApostado = 1234; // Número apostado por Genérico
        int numeroSorteo = 4321;   // Número ganador del sorteo

        int premio = CalcularPremio(numeroApostado, numeroSorteo);
        Console.WriteLine($"El premio obtenido es: ${premio}");
    }

    static int CalcularPremio(int numeroApostado, int numeroSorteo)
    {
        // Convertir los números a cadenas para facilitar la comparación de dígitos
        string apostado = numeroApostado.ToString("D4"); // Asegura que tenga 4 dígitos
        string sorteo = numeroSorteo.ToString("D4");     // Asegura que tenga 4 dígitos

        // 1. Premio por acertar las 4 cifras en orden
        if (apostado == sorteo)
        {
            return 4500 * 1000; // 4500 por cada 1 apostado
        }

        // 2. Premio por acertar las 4 cifras en desorden
        if (apostado.OrderBy(c => c).SequenceEqual(sorteo.OrderBy(c => c)))
        {
            return 200 * 1000; // 200 por cada 1 apostado
        }

        // 3. Premio por acertar las últimas 3 cifras en orden
        if (apostado.Substring(1) == sorteo.Substring(1))
        {
            return 400 * 1000; // 400 por cada 1 apostado
        }

        // 4. Premio por acertar las últimas 2 cifras en orden
        if (apostado.Substring(2) == sorteo.Substring(2))
        {
            return 50 * 1000; // 50 por cada 1 apostado
        }

        // 5. Premio por acertar la última cifra
        if (apostado[3] == sorteo[3])
        {
            return 5 * 1000; // 5 por cada 1 apostado
        }

        // Si no se cumple ninguna condición, no hay premio
        return 0;
    }
}