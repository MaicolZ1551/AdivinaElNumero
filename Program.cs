using System;

public class RandomNumero
{
    public static int Generar()
    {
        Random random = new Random();
        return random.Next(1, 101);
    }
}

public class TomarInput
{
    public static int LeerNumero()
    {
        Console.WriteLine("Elige un número del 1 al 100:");
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 100)
        {
            Console.WriteLine("Por favor, ingresa un número válido entre 1 y 100:");
        }
        return numero;
    }
}

public class Reiniciar
{
    public static bool DeseaReiniciar()
    {
        Console.WriteLine("¿Quieres jugar otra vez? (s/n)");
        string respuesta = Console.ReadLine().Trim().ToLower();
        return respuesta == "s";
    }
}

class Program
{
    static void Main()
    {
        do
        {
            int numeroAleatorio = RandomNumero.Generar();
            int numeroUsuario = 0;

            while (numeroUsuario != numeroAleatorio)
            {
                numeroUsuario = TomarInput.LeerNumero();

                if (numeroUsuario > numeroAleatorio)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Muy alto");
                }
                else if (numeroUsuario < numeroAleatorio)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Muy bajo");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("¡Has adivinado el número!");
                }

                Console.ResetColor();
            }

        } while (Reiniciar.DeseaReiniciar());

        Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");
    }
}
