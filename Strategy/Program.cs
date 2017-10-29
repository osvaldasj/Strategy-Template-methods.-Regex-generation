using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, pStrategy, dStrategy, password, date, temp;
            PasswordStrategy passwordStrategy;
            DateStrategy dateStrategy;

            while (true)
            {
                Console.WriteLine("Account registration");

                Console.Write("Enter name: ");
                firstName = Console.ReadLine();

                Console.Write("Enter last name: ");
                lastName = Console.ReadLine();

                Client client = new Client(firstName, lastName);

                Console.Write("Type one of the password startegies\n(Weak, Normal, Strong, VeryStrong): ");
                pStrategy = Console.ReadLine();
                passwordStrategy = GetPasswordStrategy(pStrategy);
                Console.WriteLine(passwordStrategy.Rules());

                while (true)
                {
                    Console.Write("Enter password: ");
                    password = Console.ReadLine();
                    temp = client.CreatePassword(password, passwordStrategy);
                    if (temp == "Password isn't strong enough")
                    {
                        Console.WriteLine(temp + "\n" + "Try again");
                    }
                    else
                    {
                        Console.WriteLine("Password created: " + temp);
                        break;
                    }
                }

                Console.Write("Type one of the date startegies\n(DMY, MDY, YMD): ");
                dStrategy = Console.ReadLine();
                dateStrategy = GetDateStrategy(dStrategy);
                Console.WriteLine(dateStrategy.Rules());

                while (true)
                {
                    Console.Write("Enter birth date: ");
                    date = Console.ReadLine();
                    temp = client.EnterBirthDate(date, dateStrategy);
                    if (temp == "Wrong date format")
                    {
                        Console.WriteLine(temp + "\n" + "Try again");
                    }
                    else
                    {
                        Console.WriteLine("Birth date entered: " + temp);
                        break;
                    }
                }

                Console.WriteLine();
                Console.Write(client.Info());
                Console.WriteLine();

                Console.WriteLine("Repeat simulaton? y/n");
                if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    break;
                }

            }
        }

        public static PasswordStrategy GetPasswordStrategy(string strategy)
        {
            switch (strategy)
            {
                case "Weak":
                    return new WeakPassword();
                case "Normal":
                    return new NormalPassword();
                case "Strong":
                    return new StrongPassword();
                case "VeryStrong":
                    return new VeryStrongPassword();
                default:
                    return new NormalPassword();
            }
        }

        public static DateStrategy GetDateStrategy(string strategy)
        {
            switch (strategy)
            {
                case "DMY":
                    return new DaysMonthsYears();
                case "MDY":
                    return new MonthsDaysYears();
                default:
                    return new YearsMonthsDays();
            }
        }
    }
}
