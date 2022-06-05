using System;

namespace AnimalsEntity
{
    public enum Color
    {
        Black, White, Multicolored
    }
    public class Bird: Animal
    {
        public Bird()
        {
            this.Eggs = 0;
        }
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool IsTalking { get; set; }
        public Color Wings { get; set; }
        public int Eggs { get; set; }

        public override string ToString()
        {
            string rum = (IsTalking) ? "говорящая птица" : "Не говорящая птица";
            string wings = (Wings == Color.Black) ? "черная" :
                (Wings == Color.White) ? "белая" : "разноцветная";
            return $"{Name} - {rum}, у которой {Eggs} детеныша и {wings} окраска перьев";
        }

        public string MakeSong()
        {
            return "Чирик, чирик..";
        }

        public void MakeChick()
        {
            Eggs++;
        }
        
    }
}
