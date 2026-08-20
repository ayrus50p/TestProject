using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace LeeTCodes
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        static void Main(string[] args)
        {
            var algsort = new SortingAlg();
            // algsort.polindrome("1234321"); 
            var sols = new longestPrefix();
            Console.WriteLine(sols.LongestCommonPrefix(null));
            /*ProblemsSourceCode problemsSourceCode = new ProblemsSourceCode();
            Console.WriteLine(problemsSourceCode.LongestCommonPrefix(null));*/

        }


       
        
    }
}