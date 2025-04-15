using System.Runtime.CompilerServices;

class Estacionamento
{
    private Stack<string> pilhaEstacionamento = new Stack<string>();
    private const int capacidade = 5;

    public void EntrarCarro(string placa)
    {
        if (pilhaEstacionamento.Count >= capacidade)
        {
            Console.WriteLine("Estacionamento cheio!");
            return;
        }
        else
        {
            Console.Write("Digite a placa do carro: ");
            placa = Console.ReadLine();
            pilhaEstacionamento.Push(placa);
            Console.WriteLine($"Carro placa {placa} estacionou!");
        }
    }
    public void RetirarCarro(string placa)
    {
        if (!pilhaEstacionamento.Contains(placa))
        {
            Console.WriteLine($"Carro placa {placa} não está no estacionamento!");
            return;
        }

        Stack<string> temp = new Stack<string>();

        while (pilhaEstacionamento.Peek() != placa)
        {
            string carroremovido = pilhaEstacionamento.Pop();
            temp.Push(carroremovido);
            Console.WriteLine($"Carro placa {carroremovido} foi retirado do estacionamento!");
        }
        pilhaEstacionamento.Pop();
        Console.WriteLine($"Carro placa {placa} foi retirado do estacionamento!");

        while(temp.Count > 0)
        {
            string carro = temp.Pop();
            pilhaEstacionamento.Push(carro);
            Console.WriteLine($"Carro placa {carro} foi recolocado no estacionamento!");
        }
    }

    public void MostrarEstacionamento()
    {
        Console.WriteLine("O estacionamento contem os seguintes carros.");
        foreach (var carro in pilhaEstacionamento)
        {
            Console.WriteLine(carro);
        }
        Console.WriteLine();
    }


}

class Program
{
    static void Main(string[] args)
    {
        Estacionamento estacionamento = new Estacionamento();
        string opcao;
        do
        {
            Console.WriteLine();
            Console.WriteLine("1. Entrar carro");
            Console.WriteLine("2. Retirar carro");
            Console.WriteLine("3. Mostrar estacionamento");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();
            Console.WriteLine();
            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    estacionamento.MostrarEstacionamento();
                    Console.WriteLine();
                    estacionamento.EntrarCarro("");
                    break;
                case "2":
                    Console.Clear();
                    estacionamento.MostrarEstacionamento();
                    Console.WriteLine();
                    Console.Write("Digite a placa do carro a ser retirado: ");
                    string placa = Console.ReadLine();
                    estacionamento.RetirarCarro(placa);
                    break;
                case "3":
                    Console.Clear();
                    estacionamento.MostrarEstacionamento();
                    break;
                case "4":
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (opcao != "4");
    }
}