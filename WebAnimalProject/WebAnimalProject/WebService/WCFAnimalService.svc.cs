using AnimalsEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebAnimalProject.Context;

namespace WebAnimalProject.WebService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "WCFAnimalService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы WCFAnimalService.svc или WCFAnimalService.svc.cs в обозревателе решений и начните отладку.
    public class WCFAnimalService : IWCFAnimalService
    {
        public bool AddAnimal(string name, int age, double weight)
        {
            using (AnimalContext bd = new AnimalContext())
            {
                Animal animal = new Animal
                {
                    Age = age,
                    Name = name,
                    Weight = weight
                };

                bd.Animals.Add(animal);
                bd.SaveChanges();
                return true;
            }
        }

        public bool AddMammal(string name, double temp, bool isIswimming)
        {
            using (AnimalContext bd = new AnimalContext())
            {
                Mammal animal = new Mammal
                {
                    IsSwimming = isIswimming,
                    Name = name,
                    Temperature = temp
                };

                bd.Mammals.Add(animal);
                bd.SaveChanges();
                return true;
            }
        }

        public bool AddAtri(string name, int h_count, bool isRum)
        {
            using (AnimalContext bd = new AnimalContext())
            {
                Artiodactyls animal = new Artiodactyls
                {
                    IsRum = isRum,
                    Name = name,
                    Hoofs = h_count
                };

                bd.Artiodactylses.Add(animal);
                bd.SaveChanges();
                return true;
            }
        }

        public bool AddBird(string name, Color wings, bool isTalking)
        {
            using (AnimalContext bd = new AnimalContext())
            {
                Bird animal = new Bird
                {
                    Wings = wings,
                    Name = name,
                    IsTalking = isTalking
                };

                bd.Birds.Add(animal);
                bd.SaveChanges();
                return true;
            }
        }

        public List<Animal> GetAnimals()
        {
            List<Animal> animals = new List<Animal>();

            using (AnimalContext bd = new AnimalContext())
            {
                var founded_animal = bd.Animals.ToList();
                animals.AddRange(founded_animal);
            }

            return animals;
        }

        public List<Mammal> GetMammals()
        {
            List<Mammal> animals = new List<Mammal>();

            using (AnimalContext bd = new AnimalContext())
            {
                var founded_animal = bd.Mammals.ToList();
                animals.AddRange(founded_animal);
            }

            return animals;
        }

        public List<Artiodactyls> GetArti()
        {
            List<Artiodactyls> animals = new List<Artiodactyls>();

            using (AnimalContext bd = new AnimalContext())
            {
                var founded_animal = bd.Artiodactylses.ToList();
                animals.AddRange(founded_animal);
            }

            return animals;
        }

        public List<Bird> GetBirds()
        {
            List<Bird> animals = new List<Bird>();

            using (AnimalContext bd = new AnimalContext())
            {
                var founded_animal = bd.Birds.ToList();
                animals.AddRange(founded_animal);
            }

            return animals;
        }

        public bool RemoveAnimals()
        {
            using (AnimalContext bd = new AnimalContext())
            {
                foreach (var item in bd.Animals)
                {
                    bd.Animals.Remove(item);
                }
                bd.SaveChanges();
            }

            return true;
        }

        public bool RemoveMammals()
        {
            using (AnimalContext bd = new AnimalContext())
            {
                foreach (var item in bd.Mammals)
                {
                    bd.Mammals.Remove(item);
                }
                bd.SaveChanges();
            }

            return true;
        }

        public bool RemoveArti()
        {
            using (AnimalContext bd = new AnimalContext())
            {
                foreach (var item in bd.Artiodactylses)
                {
                    bd.Artiodactylses.Remove(item);
                }
                bd.SaveChanges();
            }

            return true;
        }

        public bool RemoveBirds()
        {
            using (AnimalContext bd = new AnimalContext())
            {
                foreach (var item in bd.Birds)
                {
                    bd.Birds.Remove(item);
                }
                bd.SaveChanges();
            }

            return true;
        }
    }
}
    
