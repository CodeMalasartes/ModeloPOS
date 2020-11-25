using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloPOS
{
    public class LoginService
    {
        private readonly List<Login> listaLogins = new List<Login>();

        public bool CreateLogin(Login login)
        {
            Console.WriteLine("Criando Login...");
            listaLogins.Add(login);
            Console.WriteLine("Bem-Vindo(a) " + login.LoginMail);
            return true;
        }

        public bool ValidatesLogin(Login login)
        {
            Console.WriteLine("Validando login...");
            foreach(var itens in listaLogins) 
            {
                if (listaLogins.Equals(login.LoginMail) || listaLogins.Equals(login.LoginPassword))
                    return true;
            }

            //Console.WriteLine("Login or Password invalid or not exist.");
            return false;
        }
    }
}
