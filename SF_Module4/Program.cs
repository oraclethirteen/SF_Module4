using System;

namespace SF_Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* (I)
            Console.WriteLine("Напишите название вашего любимого цвета на английском (с маленькой буквы)");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }
            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }
            */

            /* (II) [4.1.18]
            Console.WriteLine("Напишите название вашего любимого цвета на английском (с маленькой буквы)");

            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            */

            /* (III)
            
            Console.WriteLine("ЦИКЛ for");
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("Напишите название вашего любимого цвета на английском (с маленькой буквы)");

                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }
            }
            */

            /* (IV)
            int k = 0;

            Console.WriteLine("ЦИКЛ while");

            while (k < 3)
            {
                Console.WriteLine(k);
                Console.WriteLine("Напишите название вашего любимого цвета на английском (с маленькой буквы)");

                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }

                k++;
            }
            */

            /* (V) [4.2.11]
            int t = 0;

            Console.WriteLine("ЦИКЛ do");

            do
            {
                Console.WriteLine(t);
                Console.WriteLine("Напишите название вашего любимого цвета на английском (с маленькой буквы)");

                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }

                t++;
            } while (t < 3);
            */

            /* (VI)
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Введите число");
                var number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    continue;
                }
                else if (number == 0)
                {
                    break;
                }

                sum += number;

            }

            Console.WriteLine("Итоговая сумма: {0}", sum);
            */

            /* (VII)
            string[] favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
                favcolors[i] = Console.ReadLine();
            }

            foreach (var color in favcolors)
            {
                switch (color)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }
            }
            */

            /* (VIII) [4.3.7]
            Console.WriteLine("Введите ваше имя");

            var name = Console.ReadLine();

            Console.WriteLine("Ваше имя по буквам: ");

            foreach (var ch in name)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine("\nПоследняя буква вашего имени: {0}", name[name.Length - 1]);

            Console.ReadKey();

            Console.Write("Добро пожаловать в Твин Пикс, ");

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i] + " ");
            }

            Console.ReadKey();
            */

            /* (XIX) [4.3.11]
            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                {
                    Console.Write(array[k, i] + " ");
                }
                Console.WriteLine();
            }
            */

            /* (X) [4.3.12]
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int num = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[k] < arr[i])
                    {
                        num = arr[i];
                        arr[i] = arr[k];
                        arr[k] = num;
                    }
                }
            }

            foreach (var nums in arr)
            {
                Console.Write(nums);
            }
            */

            /* (XI) [4.3.13]
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int sum = 0;

            foreach (var nums in arr)
            {
                sum += nums;
            }

            Console.WriteLine(sum);
            */

            /* (XII) [4.3.14]
            int[][] array = new int[3][];

            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var nums in array)
            {
                foreach (var num in nums)
                {
                    Console.Write(num + " ");
                }
            }
            */

            /* (XIII) [4.3.15]
            var arr = new int[] { -1, 5, 12, -7, 0 };

            int pos = 0;

            foreach (var num in arr)
            {
                if (num > 0)
                {
                    pos++;
                }
            }

            Console.WriteLine(pos);
            */

            /* (XIV) [4.3.16]
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int pos = 0;

            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int k = 0; k <= arr.GetUpperBound(1); k++)
                {
                    if (arr[i, k] > 0)
                    {
                        pos++;
                    }
                }
            }

            Console.WriteLine(pos);
            */

            /* (XV) [4.3.17]
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int num = 0;

            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int k = 0; k <= arr.GetUpperBound(1); k++)
                {
                    for (int j = k + 1; j <= arr.GetUpperBound(1); j++)
                    {
                        if (arr[i, j] < arr[i, k])
                        {
                            num = arr[i, j];
                            arr[i, j] = arr[i, k];
                            arr[i, k] = num;
                        }
                    }
                }
            }

            for(int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int k = 0; k <= arr.GetUpperBound(1); k++)
                {
                    Console.Write(arr[i, k] + " ");
                }
            }
            */

            /* (XVI) [4.4.2 - 4.4.3]
            var (name, age) = ("Andrew", 23);

            Console.WriteLine("My name: {0}", name);
            Console.WriteLine("My age: {0}", age);

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name: {0}", name);
            Console.WriteLine("Your age: {0}", age);

            Console.ReadKey();
            */

            /* (XVII) [4.4.5]
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.WriteLine("Enter your pet's name: ");
            Pet.Name = Console.ReadLine();

            Console.WriteLine("Enter your pet's type: ");
            Pet.Type = Console.ReadLine();

            Console.WriteLine("Enter your pet's age: ");
            Pet.Age = double.Parse(Console.ReadLine());

            Pet.NameCount = Pet.Name.Length;

            Console.WriteLine();
            Console.WriteLine("Your pet's name: {0} ({1})", Pet.Name, Pet.NameCount);
            Console.WriteLine("Your pet's type: {0}", Pet.Type);
            Console.WriteLine("Your pet's age: {0}", Pet.Age);
            */

            // (АНКЕТА 2.0) [4.5.1 - 4.5.6]
            for (int i = 0; i < 3; i++)
            {
                (string Name, string LastName, string Login, int LoginLength, bool HasPet, double Age, string[] FavColors) User;

                Console.Write("Введите ваше имя: ");
                User.Name = Console.ReadLine();

                Console.Write("Введите вашу фамилию: ");
                User.LastName = Console.ReadLine();

                Console.Write("Введите ваш логин: ");
                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length;

                Console.Write("Есть ли у вас домашнее животное? (Да / Нет) ");

                if (Console.ReadLine() == "Да")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }

                Console.Write("Введите ваш возраст: ");
                User.Age = double.Parse(Console.ReadLine());

                User.FavColors = new string[3];

                Console.WriteLine("Введите три ваших любимых цвета");

                for (int k = 0; k < User.FavColors.Length; k++)
                {
                    User.FavColors[k] = Console.ReadLine();
                }

                Console.ReadLine();
            }
        }
    }
}
