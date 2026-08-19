namespace Övning_1._2___ArgumentOutOfRange
{
    internal class Program
    {
        static List<Animal> animals = new List<Animal>
        {
            new Animal("Pig",23),
            new Animal("Elephant",55),
            new Animal("Rabbit",7)
        };
        static void Main(string[] args)
        {
            string input = String.Empty;
            while (true)
            {
                try
                {
                    var index = ReadInt("Välj ett index för att få reda på mer info om djuret eller [q] för att avsluta: ");
                    if (index < 0 || index >= animals.Count)
                        throw new ArgumentOutOfRangeException();
                    var animal = animals[index];
                    Console.Write($"Djuret {animal.Name} väger {animal.Weight} kilo. ");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.Write($"FEL! Du kan bara välja index mellan 0 och {animals.Count - 1}. ");
                }
                Console.ReadKey();
            }
        }

        public static int ReadInt(string prompt)
        {
            while (true)
            {
                ResetScreen("Övning 1.2 - ArgumentOutOfRange");
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (input == "q")
                    Environment.Exit(0);

                if (!int.TryParse(input, out int value))
                {
                    Console.Write("Fel: ange ett heltal. ");
                    Console.ReadKey();
                    continue;
                }

                return value;
            }
        }

        public static void ResetScreen(string heading)
        {
            Console.Clear();
            Console.WriteLine(heading + "\n----------------------------------------------\n");
            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine($"[{i}] {animals[i].Name}");
            }
            Console.WriteLine();
        }
    }

    class Animal
    {
        public string Name { get; set; }
        public int Weight { get; set; }

        public Animal(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }
    }
}
