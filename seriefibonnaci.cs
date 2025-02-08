using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de n términos de la serie de Fibonacci: ");
        int cantidad = int.Parse(Console.ReadLine()); // Leer número de términos

        int v1 = 0;
        int v2 = 1;

        // Mostrar el primer número de Fibonacci
        Console.WriteLine(v1);

        for (int i = 1; i < cantidad; i++) // Se inicia en 1 porque el 0 ya se mostró
        {
            int temp = v1; //Almacenamos el valor v1 en una variable temporal para no perderlo.
            v1 = v2; //El valor 1 se convierte en el valor 2.
            v2 = temp + v1;//Sumamos los valores

            Console.WriteLine(v1);
        }
    }
}
