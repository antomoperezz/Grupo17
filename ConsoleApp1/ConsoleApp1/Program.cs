namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hola, vamos a intentar crear un error de tipo 3");
            int i = 0, j = 2;
            int h = i + 2 * j;
            Console.WriteLine("El resultado es " + h);
           

        }
    }
}