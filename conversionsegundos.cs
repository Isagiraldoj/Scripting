using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de segundos: ");
        int segundos = int.Parse(Console.ReadLine());

        string resultado = ConvertirASegundos(segundos);
        Console.WriteLine(resultado);
    }

    static string ConvertirASegundos(int totalSegundos)
    {
        int horas = totalSegundos / 3600; // 1 hora = 3600 segundos
        int minutos = (totalSegundos % 3600) / 60; // Extraer los minutos
        int segundos = totalSegundos % 60; // Extraer los segundos restantes

        return $"{horas:D2}:{minutos:D2}:{segundos:D2}"; // Formato HH:MM:SS 
    }
}
