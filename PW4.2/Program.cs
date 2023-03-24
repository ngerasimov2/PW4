namespace PW4._2
{
    // Класс Посылка
    class Package
    {
        // Своства "Описание" и "Вес"
        public string Description { get; set; }
        public int Weight { get; set; }

        // Конструктор
        public Package(string description, int weight)
        {
            Weight = weight;
            Description = description;
        }
    }
    // Класс Сервис отправки
    class MailService
    {
        // Свойства лимита веса и общего веса
        public int WeightLimit { get; set; }
        private int TotalWeight { get; set; }

        // Конструктор
        public MailService(int weightLimit)
        {
            WeightLimit = weightLimit;
            TotalWeight = 0;
        }
        // Метод отправки посылок
        public void SendPackage(Package package)
        {
            if (TotalWeight + package.Weight > WeightLimit)
            {
                Console.WriteLine($"Ошибка! Нельзя отправить посылку, которая превышает лимит веса! Лимит - {WeightLimit}, вес посылки - {package.Weight}");
                return;
            }
            TotalWeight += package.Weight;
            Console.WriteLine($"Посылка отправлена! Вес - {package.Weight} описание - {package.Description}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // СОздание экземпляра класса Сервиса отправки
            MailService myMailService = new MailService(5000);
            // Создание экземпляра класса Посылка
            Package package1 = new Package("Посылка с конфетами", 2000);
            myMailService.SendPackage(package1);
            // Создание экземпляра класса Посылка
            Package package2 = new Package("Очень большая посылка", 15000);
            myMailService.SendPackage(package2);
            // Создание экземпляра класса Посылка
            Package package3 = new Package("Корм для собак", 777);
            myMailService.SendPackage(package3);

            Console.ReadKey(true);
        }
    }
}