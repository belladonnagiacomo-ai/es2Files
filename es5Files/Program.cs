namespace es5Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            string file2 = "log_sistema";
            string file3 = "allert.txt";
            using (StreamReader sr = new StreamReader(file2))
            {
                string riga = sr.ReadLine();
                 while(riga != null){

                    lista.Add(riga);
                    riga = sr.ReadLine();
                 }
            }

            for (int i = lista.Count - 1; i > 0; i++)
            {
                if (lista.Contains("CRITICAL"))
                {
                    
                }
                else
                {
                    lista.RemoveAt(i);
                }
            }

            using (StreamWriter sw =  new StreamWriter(file3))
            {
                for(int i = 0; i < lista.Count; i++)
                {
                    sw.WriteLine(lista[i]);
                }
            }

        }
    }
}
