using System;
using POO_Exercicio_Métodos_Construtores.classes;

namespace POO_Exercicio_Métodos_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto(10, "Bolacha", "Biscoito recheado", 100 );
            Console.WriteLine($"Codigo = {produto1.Codigo} Nome = {produto1.Nome} Descrição = {produto1.Descricao} Estoque = {produto1.Estoque}");
            
            Produto produto2 = new Produto(5, "Refrigerante", "Liquido gasoso com sabor", 20 );
            Console.WriteLine($"Codigo = {produto2.Codigo} Nome = {produto2.Nome} Descrição = {produto2.Descricao} Estoque = {produto2.Estoque}");
            
            Produto produto3 = new Produto(8,"Hamburguer", "Dois pães, carne, molho, queijo, alface, picles", 50);
            Console.WriteLine($"Codigo = {produto3.Codigo} Nome = {produto3.Nome} Descrição = {produto3.Descricao} Estoque = {produto3.Estoque}");
        }
    }
}
