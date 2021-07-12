using System;
using ConsoleApp2.Entidades.Enums;
using System.Collections.Generic;
namespace ConsoleApp2.Entidades
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public NiveldoTrabalhador Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<Contrato> ListadeContratos { get; set; } = new List<Contrato>();

        public Trabalhador(string nome, NiveldoTrabalhador nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }
        public void AdicionarContrato (Contrato contrato)
        {
            ListadeContratos.Add(contrato);
        }
        public void RemoverContrato(Contrato contrato)
        {
            ListadeContratos.Remove(contrato);
        }
        public double GanhoTotal (int mes, int ano)
        {
            double Soma = SalarioBase;
            foreach (Contrato x in ListadeContratos)
            {
                if (x.Data.Year == ano && x.Data.Month == mes)
                {
                    Soma += x.ValorTotal();
                }
            }
            return Soma;
        }
    }   
}
