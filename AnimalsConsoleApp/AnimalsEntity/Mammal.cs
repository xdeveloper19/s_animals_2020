using System;

namespace AnimalsEntity
{
    public enum TypeCover
    {
        Spines, Wool, Shell
    }
    public class Mammal: Animal
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public TypeCover Cover { get; set; }
        public double Temperature { get; set; }
        public bool IsSwimming { get; set; }

        public string CompareTemperature(double temp)
        {
            if (this.Temperature < temp)
                return "У этого зверя температура меньше";
            else if (this.Temperature == temp)
                return "У этого зверя температура такая же";
            else return "У этого зверя температура больше";
        }

        public string Swim()
        {
            if (IsSwimming)
                return "Животное плавает.";
            else
                return "Животное не умеет плавать.";
        }

        public string GiveMilk()
        {
            return "Молоко отдоенно.";
        }

        public override string ToString()
        {
            string rum = (IsSwimming) ? "плавающее животное, " : "не плавающее животное";
            string wings = (Cover == TypeCover.Spines) ? "иглы" :
                (Cover == TypeCover.Wool) ? "шерсть" : "панцирь";
            return $"{Name} - {rum}, у которого температура тела составляет {Temperature} градусов и имеется покров - {wings}";
        }
    }
}
