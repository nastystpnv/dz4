using System;


namespace ConsoleApp1
{
    public enum VorchlivostLevel
    {
        Низкий,
        Средний,
        Высокий
    }
    public struct Ded
    {
        public string Имя;
        public VorchlivostLevel УровеньВорчливости;
        public string[] ФразыДляВорчания;
        public int КоличествоСиняков;
        public Ded(string имя, VorchlivostLevel уровеньВорчливости, string[] фразыДляВорчания)
        {
            Имя = имя;
            УровеньВорчливости = уровеньВорчливости;
            ФразыДляВорчания = фразыДляВорчания;
            КоличествоСиняков = 0;
        }

        public int ПроверкаМатерныхСлов(params string[] матерныеСлова)
        {
            int количествоФингалов = 0;

            foreach (string фраза in ФразыДляВорчания)
            {
                foreach (string матерноеСлово in матерныеСлова)
                {
                    if (фраза.Contains(матерноеСлово))
                    {
                        КоличествоСиняков++;
                        количествоФингалов++;
                    }
                }
            }

            return количествоФингалов;
        }
    }

    class Program
    {
        static void Main()
        {
            Ded[] деды = new Ded[]
            {
            new Ded("Дед1", VorchlivostLevel.Высокий, new string[] {"Проститутки!", "Гады!", "Бяка!"}),
            new Ded("Дед2", VorchlivostLevel.Низкий, new string[] {"Погода отвратительная.", "Нет сил вставать."}),
            new Ded("Дед3", VorchlivostLevel.Средний, new string[] {"Старая техника!", "Молодежь тупая."}),
            new Ded("Дед4", VorchlivostLevel.Высокий, new string[] {"Электроника!"}),
            new Ded("Дед5", VorchlivostLevel.Средний, new string[] {"Природа заменяется бетоном."})
            };

            Console.WriteLine("Введите матерные слова через пробел: ");
            string[] матерныеСлова = Console.ReadLine().Split(' ');

            int общееКоличествоФингалов = 0;

            foreach (Ded дед in деды)
            {
                int количествоФингалов = дед.ПроверкаМатерныхСлов(матерныеСлова);
                общееКоличествоФингалов += количествоФингалов;

                Console.WriteLine($"{дед.Имя}: {количествоФингалов} фингалов");
            }

            Console.WriteLine($"Общее количество фингалов: {общееКоличествоФингалов}");
        }
    }

    internal class Program1
    {
        static void Main(string[] args)
        {
            {
                new Ded("Дед1", VorchlivostLevel.Высокий, new string[] { "Проститутки!", "Гады!", "Бяка!" }),
            new Ded("Дед2", VorchlivostLevel.Низкий, new string[] { "Погода отвратительная.", "Нет сил вставать." }),
            new Ded("Дед3", VorchlivostLevel.Средний, new string[] { "Старая техника!", "Молодежь тупая." }),
            new Ded("Дед4", VorchlivostLevel.Высокий, new string[] { "Электроника!" }),
            new Ded("Дед5", VorchlivostLevel.Средний, new string[] { "Природа заменяется бетоном." })
        };

            Console.WriteLine("Введите матерные слова через пробел: ");
            string[] матерныеСлова = Console.ReadLine().Split(' ');

            int общееКоличествоФингалов = 0;

            foreach (Ded дед in дед)
            {
                int количествоФингалов = дед.ПроверкаМатерныхСлов(матерныеСлова);
                общееКоличествоФингалов += количествоФингалов;

                Console.WriteLine($"{дед.Имя}: {количествоФингалов} фингалов");
            }

            Console.WriteLine($"Общее количество фингалов: {общееКоличествоФингалов}");
        }

    }
    
}
