namespace es3Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int somma = 0;
            double media = 0;
            string numeri = "numeri.txt";
            List<int> lista = new List<int>();
            string[] numeriArray = File.ReadAllLines(numeri);
            int[] intArray = Array.ConvertAll(numeriArray, int.Parse);
            for (int i = 0; i < numeriArray.Length; i++)
            {

                if (intArray[i] %2 == 0)
                {
                    lista.Add(Convert.ToInt32(numeriArray[i]));
                    
                }
            }
            foreach (int i in lista)
            {
                somma += i;

            }
            media = somma / lista.Count;
            Console.WriteLine("La media e: " + media);
        }
    }
}
