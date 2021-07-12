using System;

namespace ConsoleApp2.Entidades
{
    class Contrato
    {
        public DateTime Data { get; set; }
        public Double ValorPorHora { get; set; }
        public int Duracao { get; set; }

        public Contrato(DateTime data, double valorPorHora, int duracao)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Duracao = duracao;
        }
        public double ValorTotal ()
        {
            return ValorPorHora * Duracao;
        }
    }
}
