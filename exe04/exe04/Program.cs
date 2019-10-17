using System;

namespace exe04
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim(); // Apaga espaços brancos

            int n1 = original.IndexOf("bc"); // primeira aparição
            int n2 = original.LastIndexOf("bc"); //última aparição



            Console.WriteLine("Original: " + original + ".");
            Console.WriteLine("ToUpper: " + s1 + ".");
            Console.WriteLine("ToLower: " + s2 + ".");
            Console.WriteLine("Trim: "+ s3 + ".");

            Console.WriteLine("Primeira aparição: " + n1 + ".");
            Console.WriteLine("Última aparição: " + n2 + ".");
        }
    }
}
