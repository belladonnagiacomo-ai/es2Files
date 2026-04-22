namespace es4Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "log.txt";

            if(!File.Exists(file))
            {
                File.Create(file);
            }

            DateTime oralocale = DateTime.Now;
            using (StreamWriter sw = new StreamWriter(file))
            {
                sw.WriteLine(oralocale + " Sessione utente avviata");

            }
        }
    }
}
