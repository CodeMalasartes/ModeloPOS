using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ModeloPOS
{
    public class StoreService
    {
        //readonly só pode ser alterado uma vez - como se fosse constant
        //Define uma variavel que depois se torna uma constante que depois nao pode voltar a alterar        
        //SINGLETON - só permite uma instância
        private readonly List<Store> _stores = new List<Store>();
        public Store AddStore(string name, string city) //Store item)
        {
            foreach (var item in _stores)
            {
                if (item.StoreName == name && item.City == city)
                {
                    return null; //devolve sem instanciar
                }
            }
            Store s = new Store { StoreName = name, City = city };
            _stores.Add(s);
            return s;
        }

        //pode fazer aqui ou no constructor
        /*private readonly int x=0; //OU
        public StoreService()
        {
            x = 0;
        }
        
        public StoreService(int y)
        {
            x = y;
        }*/

    }
}
