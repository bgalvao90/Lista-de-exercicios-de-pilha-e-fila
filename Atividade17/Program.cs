using System.Collections;

enum Prioridade
{
    Alta,
    Baixa
}

class Documento
{
    public string Nome { get; private set; }
    public Prioridade Prioridade { get; private set; }
    public Documento(string nome, Prioridade prioridade)
    {
        Nome = nome;
        Prioridade = prioridade;
    }
}


class GereciadorImpressao
{
    private Queue<string> FilaNormal = new Queue<string>();
    private Queue<string> FilaPrioritaria = new Queue <string>();

    public void AdicionarDocumento(string nome, Prioridade prioridade)
    {
        if (prioridade == Prioridade.Alta)
        {
            FilaPrioritaria.Enqueue(nome);
        }
        else if (prioridade == Prioridade.Baixa)
        {
            FilaNormal.Enqueue(nome);
        }

        
        Console.WriteLine($"Documento {nome} adicionado à fila {(prioridade == Prioridade.Alta ? "Prioritária" : "Normal")}.");
        Console.WriteLine();
    }
    public void Imprimir()
    {
        Console.WriteLine();
        while (FilaPrioritaria.Count > 0)
        {
            string documento = FilaPrioritaria.Dequeue();
            Console.WriteLine($"Imprimindo documento: {documento}");
        }
        while (FilaNormal.Count > 0)
        {
            string documento = FilaNormal.Dequeue();
            Console.WriteLine($"Imprimindo documento: {documento}");
        }
       
    }

    public void MostrarFila()
    {
        Console.WriteLine();
        if(FilaNormal.Count == 0 && FilaPrioritaria.Count == 0)
        {
            Console.WriteLine("Fila vazia!");
            return;
        }

        foreach (var item in FilaNormal)
        {
            Console.WriteLine("Fila Normal: "+ item + " ");
        }
        Console.WriteLine();
        foreach (var item in FilaPrioritaria)
        {
            Console.WriteLine("Fila Prioritária: "+ item + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        GereciadorImpressao gerenciador = new GereciadorImpressao();
        gerenciador.AdicionarDocumento("Relatório", Prioridade.Baixa);
        gerenciador.AdicionarDocumento("Fatura", Prioridade.Alta);
        gerenciador.AdicionarDocumento("Currículo", Prioridade.Baixa);
        gerenciador.AdicionarDocumento("Apresentação", Prioridade.Alta);
        gerenciador.MostrarFila();
        gerenciador.Imprimir();
        gerenciador.MostrarFila();
    }
}