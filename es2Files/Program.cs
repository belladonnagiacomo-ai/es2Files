using System.ComponentModel.Design;

namespace es2Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] prezziArray = { "19.99", "23.95", "5.50", "15.99", "10.50" };
            string prezzi = "prezzi.dat";

            
            File.WriteAllLines(prezzi, prezziArray);    






        }
    }
}
