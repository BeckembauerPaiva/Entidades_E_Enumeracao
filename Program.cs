using System;
using Entidades_E_Enumeracao.Entities.Enums;
using Entidades_E_Enumeracao.Entities;

namespace EstudosEntitiesAndEnums;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dados do Cliente:");
        Console.Write("Nome:");
        string Name = Console.ReadLine();
        Console.Write("Cpf:");
        string Cpf = Console.ReadLine();
        Console.Write("Endereço:");
        string Endereco= Console.ReadLine();
        Console.Write("Email:");
        string Email = Console.ReadLine();
        Console.Write("Celular:");
        string Celular = Console.ReadLine();
        Console.Write("Forma de pagamento (Pix/Boleto/Dinheiro):");
        FormaDePagamento formaDePagamento = Enum.Parse<FormaDePagamento>(Console.ReadLine());//Somente aprendizagem

        DadosDoCliente Cliente = new DadosDoCliente(Name,Cpf,Endereco,Email,Celular,formaDePagamento);
        List<int>ListaDasCaçambas = new List<int>();

        Console.Write("Quantidade de Caçambas Contratadas:");
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <=N; i++)
        {
            Console.Write($"Numêro da caçamba #{i}:");
            int NumeroDaCacamba = int.Parse(Console.ReadLine());
            Console.Write("Data de Colocação (ano/mês/dia):");
            DateTime DataDeColocacao = DateTime.Parse(Console.ReadLine());
            Console.Write("Data de retirada (ano/mês/dia):");
            DateTime DataDeRetirada = DateTime.Parse(Console.ReadLine());
            Cacambas cacambas = new Cacambas(NumeroDaCacamba,DataDeColocacao,DataDeRetirada);
            Cliente.AddCacambasLista(cacambas);//Associando caçamcas ao cliente
            ListaDasCaçambas.Add(NumeroDaCacamba);
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(Cliente);
        

        foreach (int i in ListaDasCaçambas)
        {
            Console.WriteLine($"Caçambas alugadas pelo cliente: {i}");
        }
    }
}