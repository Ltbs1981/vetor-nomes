using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o tamanho do vetor:");
        int tamanho = int.Parse(Console.ReadLine());
        string[] nomes = new string[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine($"Digite o nome {i + 1}:");
            nomes[i] = Console.ReadLine();
        }

        Console.WriteLine("Digite a posição que deseja pesquisar:");
        int posicao = int.Parse(Console.ReadLine());

        if (posicao >= 0 && posicao < tamanho)
        {
            Console.WriteLine($"O nome na posição {posicao} é: {nomes[posicao]}");
        }
        else
        {
            Console.WriteLine("Posição inválida!");
        }
    }
}
