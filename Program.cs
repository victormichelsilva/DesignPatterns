using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Victor", 33);
            //cliente.nome = "Victor";
            cliente.Saudacao();

            //Console.WriteLine(cliente.nome);
        }
    }
}
