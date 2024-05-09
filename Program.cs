namespace JogodaForca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = new string[29]
            { "ABACATE", "ABACAXI", "ACEROLA", "ACAI", "ARACA", "BACABA", "BACURI", "BANANA", "CAJA", "CAJU", 
            "CARAMBOLA", "CUPUACU", "GRAVIOLA", "GOIABA", "JABUTICABA", "JENIPAPO", "MACA", "MANGABA", "MANGA", 
            "MARACUJA", "MURICI", "PEQUI", "PITANGA", "PITAYA", "SAPOTI", "TANGERINA", "UMBU", "UVA", "UVAIA"};

            Random numero = new Random();

            string palavra = frutas[numero.Next(0, 28)];
            char[] resultado = new char[palavra.Length];
            char[] alegria = new char[palavra.Length];

            for (int i = 0; i < palavra.Length; i++)
            {
                resultado[i] = palavra[i];
                alegria[i] = '_';
            }

            for (int i = 4; i >= 0; i--)
            {
                Console.Write("Escolha uma letra: ");
                char letra = Convert.ToChar(Console.ReadLine().ToUpper());

                for (int j = 0; j < resultado.Length; j++)
                {
                    if (letra == resultado[j])
                    {
                        alegria[j] = resultado[j];
                        i++;
                    }
                }
                
                foreach (char item in alegria)
                {
                    Console.Write(item);
                }
                
                Console.WriteLine();
                Console.WriteLine($"Você ainda tem {i} chances.");
                
                if (i == 0)
                {
                    Console.WriteLine("Acabaram as chances!");
                }
            }
        }
    }
}
