using System;

namespace DesignPatterns
{
    class Cliente 
    {
        // campos
        public string nome;

        // métodos
        public Cliente(string nome, int idade) 
        {
            this.nome = nome;
        }

        public void Saudacao() 
        {
            Console.WriteLine("- Olá, meu nome é: " + nome);
        }
    }
}
