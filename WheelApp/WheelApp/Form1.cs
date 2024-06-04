using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WheelApp;

namespace WheelApp
{
    public partial class Form1 : Form
    {
        private PlayController _playController;

        public Form1() {
            InitializeComponent();
            _playController = new PlayController(this);
        }

        private void FilterNonNumericKeyPress(object sender, KeyPressEventArgs e) {
            char button = e.KeyChar;

            if (!Char.IsDigit(button) && button != (char)8) {
                e.Handled = true;
            }
        }

        private void BetOnSectorX1(object sender, EventArgs e) {
            BetOnSector(1, labelBetX1);
        }

        private void BetOnSectorX2(object sender, EventArgs e) {
            BetOnSector(2, labelBetX2);
        }

        private void BetOnSectorX5(object sender, EventArgs e) {
            BetOnSector(5, labelBetX5);
        }

        private void BetOnSectorX10(object sender, EventArgs e) {
            BetOnSector(10, labelBetX10);
        }

        private void BetOnSectorX20(object sender, EventArgs e) {
            BetOnSector(20, labelBetX20);
        }

        private void BetOnSectorX40(object sender, EventArgs e) {
            BetOnSector(40, labelBetX40);
        }

        private void BetOnSector(int multiplier, Label label) {
            if (!string.IsNullOrEmpty(textBoxBet.Text)) {
                int bet = int.Parse(textBoxBet.Text);
                _playController.BetOnSector(multiplier, bet, label);
            }
        }
        
        private void TriggerWheelSpin(object sender, EventArgs e) {
            if (_playController.player.Bets.Count == 0) {
                MessageBox.Show("Сделайте ставку");
            } else {
                ToggleEnableButton();
                labelWinningSector.Visible = false;
                _playController.TriggerWheelSpin();
                Label[] labels = new[] { labelBetX1, labelBetX2, labelBetX5, labelBetX10, labelBetX20, labelBetX40 };
                int[] multipliers = new[] { 1, 2, 5, 10, 20, 40 };
                for (int i = 0; i < labels.Length; i++) {
                    labels[i].Text = $"Сектор: {multipliers[i]} - Ставка: ";
                }
            }
        }
        
        public void ToggleEnableButton() {
            this.buttonStartTurn.Enabled = !this.buttonStartTurn.Enabled;
        }

        public void UpdatePlayerBalanceDisplay(Player player) {
            labelBalance.Text = $"Баланс: {player.Balance}"; 
        }

        public void UpdateWinningSectorDisplay(float sector) {
            labelWinningSector.Visible = true;
            labelWinningSector.Text = $"Победный сектор x{sector}";
        }
        
        public void UpdateWheelPic(Bitmap rotatedImage) {
            pictureBoxWheel.Image = rotatedImage;
        }

        public void RefreshBettingDisplay(Player player, int sector, Label label) {
            label.Text = player.DictionaryBets[sector].GetSectorInfo();
            labelBalance.Text = $"Баланс: {player.Balance}";
            label.Visible = true;
        }
        
        private void depositAmount_Click(object sender, EventArgs e) {
           
            string input = depositTextBox.Text;
            if (!string.IsNullOrEmpty(input))
            {
                int amount;
                bool success = int.TryParse(input, out amount);
                if (success) {
                    _playController.Deposit(amount);
                }
                else {
                    MessageBox.Show("Введите корректное число");
                }
            }
            else {
                MessageBox.Show("Поле ввода не может быть пустым");
            }
        }
        
        private void button2_Click(object sender, EventArgs e) {
            RuleForm ruleForm = new RuleForm();
            ruleForm.ShowDialog();
        }


     
    }
}