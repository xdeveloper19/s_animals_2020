using AnimalsEntity;
using System;

namespace AnimalsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, HornLength, Eggs, choice, Hoofs = 0;
            double Weight, Temperature = 0;
            string Name, value;
            bool IsRum, HornAvailable, IsTalking, IsSwimming, res;
            Color Wings;
            TypeCover Cover;

            int menu;
            for (; ;)
            {
                Console.WriteLine("1. Животное\n2. Млекопитающее\n3. Птица\n4. Парнокопытное\n0. Выход\n");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    default:
                        {
                            Console.WriteLine("Выбран неверный пункт меню!");
                            break;
                        }
                    case 0:
                        {
                            return;
                        }

                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Добавить животное ");
                            Console.WriteLine("Введите вес, кг: ");
                            value = Console.ReadLine();
                            res = double.TryParse(value, out Weight);

                            Console.WriteLine("Введите наименование: ");
                            Name = Console.ReadLine();

                            Console.WriteLine("Введите возраст: ");
                            value = Console.ReadLine();
                            res = int.TryParse(value, out age);

                            Animal b = new Animal()
                            {
                                Age = age,
                                Name = Name,
                                Weight = Weight
                            };

                            Console.WriteLine("\n" + b.ToString());
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Добавить млекопитающее ");
                            Console.WriteLine("Введите вес, кг: ");
                            value = Console.ReadLine();
                            res = double.TryParse(value, out Weight);

                            Console.WriteLine("Введите наименование: ");
                            Name = Console.ReadLine();

                            Console.WriteLine("Введите возраст: ");
                            value = Console.ReadLine();
                            res = int.TryParse(value, out age);

                            Animal b = new Animal()
                            {
                                Age = age,
                                Name = Name,
                                Weight = Weight
                            };
                            Console.WriteLine("\n" + b.ToString());

                            Cover = TypeCover.Wool;
                            Console.WriteLine("Выберите тип покрова: 0 - иглы, 1 - шерсть, 2 - панцирь");
                            value = Console.ReadLine();
                            res = int.TryParse(value, out choice);

                            switch (choice)
                            {
                                case 0: Cover = TypeCover.Spines;
                                    break;
                                case 1: Cover = TypeCover.Wool;
                                    break;
                                case 2:
                                    break;
                                default: Cover = TypeCover.Shell;
                                    break;
                            }

                            Console.WriteLine("Введите температуру тела: ");
                            value = Console.ReadLine();
                            res = double.TryParse(value, out Temperature);

                            Console.WriteLine($"{Name} плавает? 0 - да, 1 - нет");
                            value = Console.ReadLine();
                            IsSwimming = (value == "0") ? true : false;

                            Mammal mam = new Mammal()
                            {
                                Age = b.Age,
                                Cover = Cover,
                                IsSwimming = IsSwimming,
                                Name = b.Name,
                                Temperature = Temperature,
                                Weight = Weight
                            };

                            Console.WriteLine("\n" + mam.ToString());
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Добавить птицу ");
                            Console.WriteLine("Введите вес, кг: ");
                            value = Console.ReadLine();
                            res = double.TryParse(value, out Weight);

                            Console.WriteLine("Введите наименование: ");
                            Name = Console.ReadLine();

                            Console.WriteLine("Введите возраст: ");
                            value = Console.ReadLine();
                            res = int.TryParse(value, out age);

                            Animal b = new Animal()
                            { 
                                Age = age,
                                Name = Name,
                                Weight = Weight
                            };
                            Console.WriteLine("\n" + b.ToString());

                            Wings = Color.Black;
                            Console.WriteLine("Выберите окраску перьев: 0 - черная, 1 - белая, 2 - разноцветная");
                            value = Console.ReadLine();
                            res = int.TryParse(value, out choice);

                            switch (choice)
                            {
                                case 0:
                                    Wings = Color.Black;
                                    break;
                                case 1:
                                    Wings = Color.White;
                                    break;
                                case 2:
                                    Wings = Color.Multicolored;
                                    break;
                                default:
                                    Wings = Color.Multicolored;
                                    break;
                            }

                            Console.WriteLine($"{Name} - говорящая? 0 - да, 1 - нет");
                            value = Console.ReadLine();
                            IsTalking = (value == "0") ? true : false;

                            Bird mam = new Bird()
                            {
                                Age = b.Age,
                                IsTalking = IsTalking,
                                Name = b.Name,
                                Wings = Wings,
                                Weight = Weight
                            };
                            Console.WriteLine("\n" + mam.ToString());
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            HornLength = 0;
                            Console.WriteLine("Добавить парнокопытное ");
                            Console.WriteLine("Введите вес, кг: ");
                            value = Console.ReadLine();
                            res = double.TryParse(value, out Weight);

                            Console.WriteLine("Введите наименование: ");
                            Name = Console.ReadLine();

                            Console.WriteLine("Введите возраст: ");
                            value = Console.ReadLine();
                            res = int.TryParse(value, out age);

                            Animal b = new Animal()
                            {
                                Age = age,
                                Name = Name,
                                Weight = Weight
                            };
                            Console.WriteLine("\n" + b.ToString());

                            Cover = TypeCover.Wool;
                            Console.WriteLine("Выберите тип покрова: 0 - иглы, 1 - шерсть, 2 - панцирь");
                            value = Console.ReadLine();
                            res = int.TryParse(value, out choice);

                            switch (choice)
                            {
                                case 0:
                                    Cover = TypeCover.Spines;
                                    break;
                                case 1:
                                    Cover = TypeCover.Wool;
                                    break;
                                case 2:
                                    Cover = TypeCover.Shell;
                                    break;
                                default:
                                    Cover = TypeCover.Shell;
                                    break;
                            }

                            Console.WriteLine("Введите температуру тела: ");
                            value = Console.ReadLine();
                            res = double.TryParse(value, out Temperature);

                            Console.WriteLine($"{Name} плавает? 0 - да, 1 - нет");
                            value = Console.ReadLine();
                            IsSwimming = (value == "0") ? true : false;

                            Mammal mam = new Mammal()
                            {
                                Age = b.Age,
                                Cover = Cover,
                                IsSwimming = IsSwimming,
                                Name = b.Name,
                                Temperature = Temperature,
                                Weight = Weight
                            };

                            Console.WriteLine("\n" + mam.ToString());
                            Console.WriteLine("\n" + $"{Name} - жвачное животное? 0 - да, 1 - нет");
                            value = Console.ReadLine();
                            IsRum = (value == "0") ? true : false;

                            Console.WriteLine($"{Name} - животное с рогами? 0 - да, 1 - нет");
                            value = Console.ReadLine();
                            HornAvailable = (value == "0") ? true : false;

                            Console.WriteLine("Введите количество копыт: ");
                            value = Console.ReadLine();
                            res = int.TryParse(value, out Hoofs);

                            if (HornAvailable)
                            {
                                Console.WriteLine("Введите длину рогов, см: ");
                                value = Console.ReadLine();
                                res = int.TryParse(value, out HornLength);
                            }
                           

                            Artiodactyls art = new Artiodactyls()
                            {
                                Age = b.Age,
                                Cover = Cover,
                                Name = b.Name,
                                Hoofs = Hoofs,
                                Weight = Weight,
                                HornLength = HornLength,
                                IsRum = IsRum,
                                HornAvailable = HornAvailable,
                                IsSwimming = IsSwimming,
                                Temperature = Temperature
                            };
                            Console.WriteLine("\n" + art.ToString());
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                }
            }
        }
    }
}
