using System;
using System.Security.Cryptography;
using System.Text;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            var word1 = "Mathias";
            Console.WriteLine($"Before GetHashCode hash: {word1} {System.Environment.NewLine}After GetHashCode hash: {word1.GetHashCode()}");
            var word2 = "Mathias";
            Console.WriteLine($"Before md5 hash: {word2} {System.Environment.NewLine}After md5 hash: {md5output(word2)}");
            var word3 = "Mathias";
            md5output(word3);
            if(word3 == word2)
            {
                Console.WriteLine($"Word 2 and 3 are the same {System.Environment.NewLine}Word2: {md5output(word2)} {System.Environment.NewLine}Word3: {md5output(word3)}");
            }
            else
            {
                Console.WriteLine($"Word 2 and 3 are not the same {System.Environment.NewLine}Word2: {md5output(word2)} {System.Environment.NewLine}Word3: {md5output(word3)}");
            }
            
        }
        public static StringBuilder md5output(string input) 
        {
            var md5 = MD5.Create();
            byte[] byteArrayInput = Encoding.UTF8.GetBytes(input);
            byte[] bytesArrayHash = md5.ComputeHash(byteArrayInput);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < bytesArrayHash.Length; i++)
            {
                stringBuilder.Append(bytesArrayHash[i].ToString("x2"));
            }
            return stringBuilder;
        }
    }
}
