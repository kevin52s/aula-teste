// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("digite numeros a serem somados");
int numero1 = Convert.ToInt32(Console.ReadLine());
int numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O resultado da soma é {Soma(numero1, numero2)}");

object Soma(int numero1, int numero2)
{
    throw new NotImplementedException();
}

Console.WriteLine("aperte enter para finaizar o programa");
Console.ReadLine();


   



