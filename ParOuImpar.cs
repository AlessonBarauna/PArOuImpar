
namespace ParOuImpar
{
    class prgrama
    {
        static void Main(String[] args)
        {
            int Num = 0;
            int R = 0;

            Console.WriteLine("Digite um numero: ");
            Num = Convert.ToInt32(Console.ReadLine());
            R = Num % 2;

            if (R == 0)
            {
                Console.WriteLine("O numero é par!");

            }
            else
            {
                Console.WriteLine("O numero é impar!");
            }
            Console.WriteLine("Tecle enter para sair!");
            Console.ReadKey();
        }
    }
}