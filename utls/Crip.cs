using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Teste.entities;

namespace Teste.utils
{
    public static class Crip
    {
        public static string EncryptAccessAsync(string pass)
        {

            string cripPass = ReturnMD5Async(pass);


            return cripPass;
        }

        public static string ReturnHashAsync(MD5 hashmd5, string input)
        {
            byte[] data = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sbuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sbuilder.Append(data[i].ToString("X2"));
            }
            return sbuilder.ToString();
        }

        public static string ReturnMD5Async(string Senha)
        {


            using (MD5 md5Hash = MD5.Create())
            {
                return ReturnHashAsync(md5Hash, Senha);
            }

        }

        public static async Task<bool> CheckHashAsync(string input, string Hash)
        {
            StringComparer comparar = StringComparer.OrdinalIgnoreCase;
            if (comparar.Compare(input, Hash) == 0)
            {
                return await Task.FromResult(true);
            }
            else
            {
                return await Task.FromResult(false);
            }
        }

        public static Task<bool> CompareMD5Async(string senhaEntrada, string Senhamd5)
        {
            return CheckHashAsync(Senhamd5, senhaEntrada);
        }
    }

}


