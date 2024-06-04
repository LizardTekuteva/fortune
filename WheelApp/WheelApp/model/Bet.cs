

namespace WheelApp.model
{
    public class Bet
    {
        public Sector BetSector { get; set; }
        public float Amount { get; set; }
        
        public Bet(Sector sector, float amount)
        {
            BetSector = sector;
            Amount = amount;
        }

        public string GetSectorInfo()
        {
            return $"Сектор: {BetSector.Name} - Ставка: {Amount}";
        }
    }
}