using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using WheelApp;



namespace WheelApp
{
    public class WheelForm
    {
        private readonly Form1 form;
        private readonly Bitmap wheelPic;
        
        private readonly List<Sector> sectors;
        private int state;
        
        public readonly Player player;
        
        public WheelForm(Form1 form, Player player) {
            this.form = form;
            wheelPic = new Bitmap(WheelApp.Properties.Resources.wheel);
            this.player = player;
        }

        private Bitmap RotateImage(Bitmap image, float angle, PointF offset = default(PointF)) {
            Bitmap rotatedBitmap = new Bitmap(image.Width, image.Height);
            rotatedBitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            Graphics g = Graphics.FromImage(rotatedBitmap);

            if (offset == default(PointF)) {
                offset = new PointF((float)image.Width / 2, (float)image.Height / 2);
            }

            g.TranslateTransform(offset.X, offset.Y);
            g.RotateTransform(angle);
            g.TranslateTransform(-offset.X, -offset.Y);
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBitmap;
        }
        
        public void OnWheelSpun(object sender, WheelEventArgs e) {
            form.UpdateWinningSectorDisplay(e.WinningSector.Multiplier);
            form.UpdatePlayerBalanceDisplay(player);
            form.ToggleEnableButton();
        }
        public void wheelDidUpdate(object sender, WheelUpdatedEventArgs e) {
            Bitmap rotatedImage = RotateImage(wheelPic, e.Angle);
            form.UpdateWheelPic(rotatedImage);
        }
        
        public void UpdateBetDisplay(int sector, Label label) {
            form.RefreshBettingDisplay(player, sector, label);
        }
        
        public void ShowPlayerAndBalance() {
            form.UpdatePlayerBalanceDisplay(player);
        }
    }
}
