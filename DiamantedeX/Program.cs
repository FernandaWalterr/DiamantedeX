namespace DiamantedeX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            do
            {
                Console.Write("Digite um número ímpar: ");
                numero = int.Parse(Console.ReadLine());
            } while (numero % 2 == 0); // Verifica se o número é ímpar

            // Imprime a metade superior do diamante
            for (int i = 1; i < numero; i += 2)
            {
                Console.Write(new string(' ', (numero - i) / 2));
                Console.WriteLine(new string('x', i));
            }

            // Imprime a linha central do diamante
            Console.WriteLine(new string('x', numero));

            // Imprime a metade inferior do diamante
            for (int i = numero - 2; i > 0; i -= 2)
            {
                Console.Write(new string(' ', (numero - i) / 2));
                Console.WriteLine(new string('x', i));
            }
        }
    }
}