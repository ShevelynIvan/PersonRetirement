namespace PersonRetirement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person alex = new Person("Alex", 65, 35);
            Person olha = new Person("Olha", 57, 40);
            Person dima = new Person("Dima", 20, 0);

            Console.WriteLine($"Retirement value for {alex.Name}");
            Console.WriteLine($"UA in uah: {alex.GetRetirementValue(GetRetirementValueUA)}");
            Console.WriteLine($"PL in uah: {alex.GetRetirementValue(GetRetirementValuePL)}");
            Console.WriteLine($"GB in uah: {alex.GetRetirementValue(GetRetirementValueGB)}");

            Console.WriteLine($"Retirement value for {olha.Name}");
            Console.WriteLine($"UA in uah: {olha.GetRetirementValue(GetRetirementValueUA)}");
            Console.WriteLine($"PL in uah: {olha.GetRetirementValue(GetRetirementValuePL)}");
            Console.WriteLine($"GB in uah: {olha.GetRetirementValue(GetRetirementValueGB)}");

            Console.WriteLine($"Retirement value for {dima.Name}");
            Console.WriteLine($"UA in uah: {dima.GetRetirementValue(GetRetirementValueUA)}");
            Console.WriteLine($"PL in uah: {dima.GetRetirementValue(GetRetirementValuePL)}");
            Console.WriteLine($"GB in uah: {dima.GetRetirementValue(GetRetirementValueGB)}");
        }

        static double GetRetirementValueUA(int age, int exp)
        {
            if (age < 60)
                return 0;

            if (exp < 16)
                return 2400;

            return age * exp * 4;
        }

        static double GetRetirementValuePL(int age, int exp)
        {
            if (age < 55)
                return 0;

            if (exp < 16)
                return 3200;

            return age * exp * 5;
        }

        static double GetRetirementValueGB(int age, int exp)
        {
            if (age < 55)
                return 0;

            if (exp < 21)
                return 4100;

            return age * exp * 6;
        }
    }
}