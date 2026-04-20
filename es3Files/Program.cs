namespace es3Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeri = "numeri.txt";
            string[] n = { "1", "2", "3", "4", "5" };
            List<string> lista = new List<string>();
            File.WriteAllLines(numeri, n);
            string[] numeriArray = File.ReadAllLines(numeri);
            for (int i = 0; i < numeriArray.Length; i++)
            {
                
                lista.Add(numeriArray[i]);
            }







        }
    }
}
