using WheelApp.model;

namespace WheelApp
{
    public class Sector
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Multiplier { get; set; }

        public Bet Bet;
        
        public Sector(int id, string name, float multiplier)
        {
            Id = id;
            Name = name;
            Multiplier = multiplier;
        }
    }
}