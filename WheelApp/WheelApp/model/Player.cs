using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelApp.model;


namespace WheelApp
{

    public class Player
    {
       
            public string Name { get; set; }
            public float Balance { get; set; }
            public List<Bet> Bets { get; set; } = new List<Bet>();

            public Dictionary<int, Bet>  DictionaryBets { get; set; }= new Dictionary<int, Bet>();
            public Player(string name, float balance)
            {
                Name = name;
                Balance = balance;
            }

            public void OnWheelSpun(object sender, WheelEventArgs e) {
                float Multiplier = e.WinningSector.Multiplier;
                
                foreach (var bet in Bets)
                {
                    if (bet.BetSector.Multiplier == Multiplier)
                    {
                        TopUpBalance(bet.Amount * Multiplier);
                    }
                }
                Bets = new List<Bet>();
                DictionaryBets = new Dictionary<int, Bet>();
                
            }
            
            public void CreateBet(int sectorId, float amount)
            {
                
                Balance -= amount;
                if (DictionaryBets.ContainsKey(sectorId))
                {
                    DictionaryBets[sectorId].Amount += amount;
                } else {
                    Sector sector = new Sector(sectorId, Convert.ToString(sectorId), sectorId);
                    Bet bet = new Bet(sector, amount);
                    Bets.Add(bet);
                    DictionaryBets.Add(sectorId, bet);
                }
                
            }

            public void TopUpBalance(float amount)
            {
                Balance += amount;
            }

            public void ChangeBetSize(int sectorId, float newSize)
            {
                var bet = Bets.FirstOrDefault(b => b.BetSector.Id == sectorId);
                if (bet != null)
                {
                    bet.Amount = newSize;
                }
            }
    }
}
