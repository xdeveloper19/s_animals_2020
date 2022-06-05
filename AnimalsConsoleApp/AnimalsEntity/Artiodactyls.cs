using System;

namespace AnimalsEntity
{
    public class Artiodactyls: Mammal
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        //жвачное
        public bool IsRum { get; set; }
        //копыта
        public int Hoofs { get; set; }
        //рога  
        public bool HornAvailable { get; set; }

        public int HornLength { get; set; }

        public string ForceJump()
        {
            if (HornAvailable)
                return "Зверь атакует";
            else
                return "Зверь убегает";
        }

        public string CompareHorn(int horn)
        {
            if (HornAvailable)
            {
                if (this.HornLength < horn)
                    return "У этого зверя длина рогов меньше";
                else if (this.HornLength == horn)
                    return "Длина рогов одинаковые";
                else return "У этого зверя длина рогов больше";
            }
            else return "Рогов нет";
        }

        public override string ToString()
        {
            string rum = (IsRum) ? "Жвачное" : "Не жвачное";
            string horn = (HornAvailable) ? "длина рог: " + this.HornLength : "рогов нет ";
            return $"{Name} - парнокопытное, {horn}, {rum} животное, имеет {Hoofs} копыта";
        }

    }
}
