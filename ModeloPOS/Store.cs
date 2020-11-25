using System;

namespace ModeloPOS
{
    //Armazena as lojas - guardamos quem criou, apagou ou alterou
    //responsavel por atualizar seus atributos
    
    public class Store : Auditable
    {
        /*Unique identify - Para não ter valor duplicado em cada localidade - cria um Id único
        Lisboa Id=0 Porto Id=1 
        Hash da classe mais timestamp
        Guid utiliza também num serie da board e do processador
        Muito utilizado em Big Data
        Usa um novo valor a partir da aplicação não precisa ler da BD
        Se uma empresa compra outra e quer integrar as lojas no sistema garante que será único
        Na Web é mais difícil de aceder pelo id porque é um código hash*/
        /*public*/ private Guid StoreId { get; set; } = Guid.NewGuid();

        private string _storeName;
        private string _city;

        public string StoreName
        {
            get { return _storeName; }
            set { _storeName = value; 
                UpdatedAt = DateTime.Now; /*No SqlServer faz no Temporal Data Table - 
                                            com o Design Pattern podemos colocar eventos 
                                            mandar email quando for alterada alguma info critica*/
            }
        }
        public string City
        {
            get { return _city; }
            set { _city = value;
                UpdatedAt = DateTime.Now; //No SqlServer faz no Temporal Data Table
            }
        }
    }
}
