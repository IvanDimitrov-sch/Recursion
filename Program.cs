using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (IsPower(x))
            {
                Console.WriteLine("yes");
            }else
            {
                Console.WriteLine("no");
            }
        }
        
        static bool IsPower(int x)
        {
            
            if(x == 1) return true;
            if(x % 2 != 0) return false;

            return IsPower(x/2);
        }
    }
}
