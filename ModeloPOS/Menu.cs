using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ModeloPOS
{
    public class Menu
     {
        public string CreateMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1 - REGISTRA CLIENTE");
            Console.WriteLine("2 - REGISTRA PRODUTOS");
            Console.WriteLine("3 - REGISTRA VENDA");
            Console.WriteLine("4 - BUSCA PRODUTO POR NOME");
            Console.WriteLine("5 - BUSCA PRODUTO POR MARCA");
            Console.WriteLine("6 - BUSCA PRODUTO POR CATEGORIA");
            Console.WriteLine("0 - SAIR");
            Console.WriteLine("Escolha uma opção: ");
            return Console.ReadLine();
        }

    }
}
