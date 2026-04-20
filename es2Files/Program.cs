using System.ComponentModel.Design;

namespace es2Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] prezziArray = { "19.99", "23.95", "5.50", "15.99", "10.50" };
            string prezzi = "prezzi.dat";

            if(File.Exists(prezzi))
            {
                Console.WriteLine("Cosa vuoi fare: ");
                Console.WriteLine("1) Sovrascrivere il file");
                Console.WriteLine("2) Aggiungere le righe");
                int scelta = Convert.ToInt32(Console.ReadLine());
                if(scelta == 1)
                {
                    File.WriteAllLines(prezzi, prezziArray);
                }
                else if(scelta == 2)
                {
                    File.AppendAllLines(prezzi, prezziArray);
                }
            }
            else
            {
                File.WriteAllLines(prezzi, prezziArray);
            }
                  
            






        }
    }
}
