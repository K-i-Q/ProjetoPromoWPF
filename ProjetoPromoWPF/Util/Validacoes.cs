using ProjetoPromoWPF.DAL;
using ProjetoPromoWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoPromoWPF.Util
{
    class Validacoes
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static bool ValidaCPF(string cpf)
        {
                int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string tempCpf;
                string digito;
                int soma;
                int resto;
                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");
                if (cpf.Length != 11)
                    return false;
                tempCpf = cpf.Substring(0, 9);
                soma = 0;

                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = resto.ToString();
                tempCpf = tempCpf + digito;
                soma = 0;
                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = digito + resto.ToString();
                return cpf.EndsWith(digito);
        }

        public static bool ValidaNome(string nome)
        {
            bool containsInt = nome.Any(char.IsDigit);

            if (nome.Length < 6 || containsInt)
            {
                return false;
            }
            return true;
        }

        public static bool ValidaData(string data)
        {
            DateTime retorno;
            if (DateTime.TryParse(data, out retorno))
            {
                return true;
            }
            return false;
        }

        public static bool ValidaGenero(string genero)
        {
            genero = genero.ToLower();

            if (!(genero.Length > 1))
            {
                if (genero == "m" || genero == "f")
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ValidaEmail(string email)
        {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }
        }
        public static bool ValidaSenha(string senha)
        {
                //string MatchEmailPattern = "(?=.{6,})[a-zA-Z0-9]+[^a-zA-Z]+|[^a-zA-Z]+[a-zA-Z]+";
                string MatchEmailPattern = "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{6,15})$";

            if (senha != null) return Regex.IsMatch(senha, MatchEmailPattern);
            else return false;
        }

        //TODO
        //public static bool ValidaTelefone(string telefone)
        //{
            
        //    return false;   
        //}
    }
}
