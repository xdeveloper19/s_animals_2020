using System;


namespace AnimalsEntity
{
    public class Animal
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public double Weight { get;  set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string CompareWeight(double weight)
        {
            if (this.Weight < weight)
                return "Этот зверь весит меньше";
            else if (this.Weight == weight)
                return "Этот зверь точно такого веса";
            else return "Этот зверь тяжелее";
        }

        public override string ToString()
        {
            return $"Наименование: {Name}\n Вес: {Weight}\n Возраст: {Age}\n";
        }

        public string Sleep()
        {
            return "Животное заснуло.";
        }
    }
}
