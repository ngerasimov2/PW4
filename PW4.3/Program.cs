namespace PW4._3
{
    class Orc
    {
        // Статические поля
        private static int totalGold = 0;
        private static int orcCount = 0;
        // Свойство gold
        public int Gold { get; private set; }

        public Orc()
        {
            // Увеличивает количество орков
            orcCount++;
            // Если орков < или = 5
            if (orcCount <= 5)
            {
                Gold = totalGold;
                totalGold += 2;
            }
            else
            {
                Gold = totalGold - (orcCount - 5) * 2;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Orc orc = new Orc();
                Console.WriteLine($"Создан орк №{i + 1}, он может переносить {orc.Gold} золота");
            }

            Console.ReadKey(true);
        }
    }
}
