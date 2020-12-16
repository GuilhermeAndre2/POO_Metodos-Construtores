using System;

namespace POO_Exercicio_Métodos_Construtores.classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int Estoque { get; set; }
        
        public Produto(int codigo, string nome, string desc, int estoque){
            
            Codigo = codigo;
            Nome = nome;
            Descricao = desc;
            Estoque = estoque;
        }
        
        
        
        
        
        
        
    }
}