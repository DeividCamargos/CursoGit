using System;
using ConsoleApp2.Entidades;
using ConsoleApp2.Entidades.Enums;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do departamento: ");
            string nomeDoDepartamento = Console.ReadLine();

            Console.WriteLine("Dados do Funcionário: ");

            Console.Write("Nome do funcionário: ");
            string nomeDoFuncionario = Console.ReadLine();

            Console.Write("Nivel do funcionário: ");
            NiveldoTrabalhador nivelDoFuncionario = Enum.Parse<NiveldoTrabalhador>(Console.ReadLine());

            Console.Write("Salario base do funcionário: ");
            double salarioBase = double.Parse(Console.ReadLine());

            Console.Write("Quantos contratos deseja ler? ");
            int quantidadeDeContratos = int.Parse(Console.ReadLine());

            Departamento Departamento = new Departamento(nomeDoDepartamento);

            Trabalhador Trabalhador = new Trabalhador(nomeDoFuncionario, nivelDoFuncionario, salarioBase, Departamento);

            for (int i = 0; i < quantidadeDeContratos; i++)
            {
                Console.WriteLine("Dados do funcionário {0}:", i+1);

                Console.Write("Data (dd/MM/yyyy): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine());

                Console.Write("Duracão do contrato (em horas): ");
                int duracao = int.Parse(Console.ReadLine());

                Contrato Contrato = new Contrato(data, valorPorHora, duracao);

                Trabalhador.AdicionarContrato(Contrato);
            }
            Console.WriteLine();

            Console.Write("Digite a data para ver o valor total recebido (MM/yyyy): ");
            string mesAndAno = Console.ReadLine();
            int mes = int.Parse(mesAndAno.Substring(0, 2));
            int ano = int.Parse(mesAndAno.Substring(3, 4));

            double valorTotal = Trabalhador.GanhoTotal(mes, ano);

            Console.WriteLine($"Nome: {Trabalhador.Nome}\n" +
                $"Departamento: {Trabalhador.Departamento.Name}\n" +
                $"Ganho total: {valorTotal}");



        }
    }
}
