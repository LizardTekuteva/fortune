using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WheelApp;


namespace WheelApp
{
    public class PlayController
    {
        private WheelForm wheelForm;
        private Wheel wheel;

        public Player player;
        public PlayController(Form1 form)
        {
            wheel = new Wheel();
            player = new Player("player", 1000);
            wheelForm = new WheelForm(form, player);
            
            wheel.wheelSpun += player.OnWheelSpun;
            wheel.wheelSpun += wheelForm.OnWheelSpun;
            wheel.WheelUpdated += wheelForm.wheelDidUpdate;
        }

        public void BetOnSector(int sector, int amount, Label label) {
            if (player.Balance < amount)
            {
                MessageBox.Show("Недостаточно средств на балансе");
                return;
            }
            player.CreateBet(sector, amount);
            
            wheelForm.UpdateBetDisplay(sector, label);
        }
        
        public void TriggerWheelSpin() {
            wheel.StartSpin();
        }

        public void Deposit(int amount) {
            player.Balance += amount;
            wheelForm.ShowPlayerAndBalance();
        }
    }
}
