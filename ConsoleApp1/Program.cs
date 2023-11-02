namespace Calculado
{
    internal class Program
    { 
     static void Main(string[] args)
        {
            Console.WriteLine("Qual sera a operação:\n");
            Console.WriteLine("1 - Adição\n");
            Console.WriteLine("2 - Subtração\n");
            Console.WriteLine("3 - Multiplicão\n");
            Console.WriteLine("4 - Divisão\n");

           // Console.ReadLine();
            int operacao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o primeiro número:");
            int n1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Informe o primeiro número:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int resultado = 0;

            switch(operacao)
            {
                case 1:
                    {
                        resultado= n1+ n2;
                        break;
                    }
                    case 2:
                    {
                        resultado= n1- n2;
                        break;
                    }
                    case 3:
                    {
                        resultado= n1*n2;
                        break;  
                    }
                    case 4:
                    {
                        resultado= n1/n2;
                        break;  
                    }
                    default:
                    Console.WriteLine("Numeero invalido, tentar novamente");
                    break;
            }
            Console.WriteLine("O resultado: {0} ",  resultado);
        }
    }

}
