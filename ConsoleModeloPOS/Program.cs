using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using ModeloPOS;

namespace ConsoleModeloPOS
{
    class Program
    {
        static List<Customer> customers;
        static List<Product> products;
        static List<Line> saleLines;
        static void Main(string[] args)
        {
            Login login = new Login();
            LoginService loginService = new LoginService();
            Customer customer = new Customer();
            Sale sale = new Sale();
            Line line = new Line();
            Menu menu = new Menu();
            Product product = new Product();
            customers = new List<Customer>();
            products = new List<Product>();
            saleLines = new List<Line>();

            // Product p2 = new Product() { Name = "CALÇA", Brand = "NIKE", Category = "VESTUARIO" };
            // Product p3 = new Product() { Name = "SAPATILHA", Brand = "PUMA", Category = "SAPATOS" };
            // Product p4 = new Product() { Name = "BRINCO", Brand = "GLORIA ORTIZ", Category = "ACESSORIOS" };

            string SimOuNao = "N";
            string Option;
            bool validaLogin = false;

            Console.Write("Login: ");
            login.LoginMail = Console.ReadLine();
            Console.Write("Password: ");
            login.LoginPassword = Console.ReadLine();
            login.DateTime = DateTime.Now;

            validaLogin = loginService.ValidatesLogin(login);

            if (!validaLogin)
            {
                Console.WriteLine("Login/Password not exist.");
                Console.Write("Deseja registrar um login [S ou N]: ");
                SimOuNao= Console.ReadLine().ToUpper();
                if (SimOuNao == "N")
                   return;

                if (loginService.CreateLogin(login)) { Console.WriteLine("Login/Senha criados com sucesso."); }
                else { throw new System.Exception("Falha na criação do login/senha."); }

                Console.WriteLine();
            }

            do
            {
                Option = menu.CreateMenu();
 
                switch (Option)
                {
                    case "1":
                        Console.WriteLine("Registra Cliente");
                        Console.Write("Nome: ");
                        customer.CustomerName = Console.ReadLine();
                        Console.Write("Morada: ");
                        customer.CustomerAddress = Console.ReadLine();
                        Console.Write("NIF: ");
                        customer.CustomerNIF = int.Parse(Console.ReadLine());
                        customers.Add(customer);

                        /*if (customers.Add(customer)) { Console.WriteLine("Cliente " + customer.CustomerName + " registrado com sucesso.");}
                        else { throw new System.Exception("Falha na criação do cliente."); }*/

                        customer.ShowCustomers(customers); //VERIFICAR PORQUE NAO MOSTRA TODOS OS REGISTROS e o ID nao está mudando
                        break;
                    case "2":
                        Console.WriteLine("Registra Produto");
                        // Exemplo: Name = "BLUSA", Brand = "ADIDAS", Category = "VESTUARIO"
                        Console.Write("Produto: ");
                        product.ProductName = Console.ReadLine();
                        Console.Write("Marca: ");
                        product.ProductBrand = Console.ReadLine();
                        Console.Write("Categoria: ");
                        product.ProductCategory = Console.ReadLine();
                        products.Add(product);
                        product.ShowProducts(products);//VERIFICAR PORQUE NAO MOSTRA TODOS OS REGISTROS e o ID nao está mudando
                        break;
                    case "3":
                        Console.WriteLine("Registra Venda");
                        Console.Write("Produto: ");
                        line.NomeProduto = Console.ReadLine();
                        Console.Write("Quantidade: ");
                        line.Quantidade = int.Parse(Console.ReadLine());
                        Console.Write("Valor Unitário: ");
                        line.ValorUnitario = decimal.Parse(Console.ReadLine());
                        decimal total = ((line.Quantidade) * (line.ValorUnitario));
                        Console.WriteLine("Total: " + string.Format("{0:0.##}", total)); //nao esta funcionando direito
                        line.Total = total;
                        saleLines.Add(line);
                        line.ShowLines(saleLines);//VERIFICAR PORQUE NAO MOSTRA TODOS OS REGISTROS e o ID nao está mudando
                        break;
                    case "4":
                        Console.WriteLine("Exclui Item"); //nao testei
                        Console.Write("Id do Item: ");
                        int id = int.Parse(Console.ReadLine());
                        saleLines.RemoveAt(id);
                        break;
                    case "5":
                        Console.WriteLine("Busca Produto por Nome"); //nao testei
                        Console.WriteLine("Nome do Produto: ");
                        product.FindProdutoByName(products, Console.ReadLine());
                        break;
                    case "6":
                        Console.WriteLine("Busca Produto por Marca"); //nao testei
                        Console.WriteLine("Marca: ");
                        product.FindProductByBrand(products, Console.ReadLine());
                        break;
                    case "7":
                        Console.WriteLine("Busca Produto por Categoria"); //nao testei
                        Console.WriteLine("Categoria: ");
                        product.FindProductByCategory(products, Console.ReadLine());
                        break;
                    case "0":
                        Console.WriteLine("SAIR");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }

            } while (Option != "0");
        }
    }
}
