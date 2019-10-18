using System;

namespace exe04
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "  abcde FGHIJ ABC abc DEFG ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim(); // Apaga espaços brancos

            int n1 = original.IndexOf("bc"); // primeira aparição
            int n2 = original.LastIndexOf("bc"); //última aparição

            string s4 = original.Substring(3); // começando na posição 3
            string s5 = original.Substring(3, 5); // Do 3 ao 5

            string s6 = original.Replace('a', 'x'); //substitui todo caratere a por x
            string s7 = original.Replace("abc","xyz"); //Substritui um conjunto de caractere

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: " + original + ".");
            Console.WriteLine("ToUpper: " + s1 + ".");
            Console.WriteLine("ToLower: " + s2 + ".");
            Console.WriteLine("Trim: "+ s3 + ".");

            Console.WriteLine("Primeira aparição: " + n1 + ".");
            Console.WriteLine("Última aparição: " + n2 + ".");
             
            Console.WriteLine("Substring(3): " + s4);
            Console.WriteLine("Substring(3, 5): " + s5);

            Console.WriteLine("Replace('a','x'): "+s6);
            Console.WriteLine("Replace('abc','xyz'): " + s7);

            Console.WriteLine("Is null or Empty: "+b1);
            Console.WriteLine("Is null or White Spare: "+b2);

        }
    }
}
