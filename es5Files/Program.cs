namespace es5Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            string file1 = "log.txt";
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

            for (int i = lista.Count; i > 0; i++)
            {
                if (lista.Contains("CRITICAL"))
                {
                    
                }
            }

        }
    }
}
