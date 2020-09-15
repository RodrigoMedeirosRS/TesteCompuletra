using Negocio;
using System;

namespace TesteCompuletra
{
    class Program
    {
        static void Main(string[] args)
        {           
            var automato = new AutomatoEscritor();
            
            // Não Mudar
            //----------------------------------------------------
            Executa.ExecutaAutomato(automato);
            Console.ReadKey();
            //----------------------------------------------------
        }
    }
}
