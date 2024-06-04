using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WheelApp.model;


namespace WheelApp
{
    public class Wheel
    {
        public event EventHandler<WheelEventArgs> wheelSpun;
        public event EventHandler<WheelUpdatedEventArgs> WheelUpdated;
        
        public readonly Timer wheelTimer;
        public bool wheelIsMoving;
        public int numberOfTwists;
        
        public List<Sector> Sectors { get; set; } = new List<Sector>();
        private float angle;
        private int state;
        
        public Wheel() {
            int[] states = new int[] { 1, 2, 20, 1, 5, 2, 1, 10, 1, 2, 1, 5, 1, 40, 1, 2, 1, 2, 1, 5, 1, 10, 1, 2, 1, 2, 1, 5, 1, 20, 1, 2, 1, 2, 1, 10, 2, 5, 1, 2, 40, 2, 1, 2, 1, 5, 1, 2, 1, 10, 1, 5, 1, 2 };
            Sectors = new List<Sector>();

            for (int i = 0; i < states.Length; i++)
            {
                Sectors.Add(new Sector(i + 1,Convert.ToString(states[i]), states[i]));
            }
            
            angle = 0.0f;
            wheelTimer = new Timer();
            wheelTimer.Interval = 50; // как часто вызывается метод ниже
            wheelTimer.Tick += WheelTimerTick;
            
        }

        public void StartSpin() {
            wheelIsMoving = true;
            Random rand = new Random();
            numberOfTwists = rand.Next(50, 100); // кол-во кручений
            wheelTimer.Start();
        }
        
        private void WheelTimerTick(object sender, EventArgs e) {
            if (wheelIsMoving && numberOfTwists > 0)
            {
                angle += numberOfTwists / 10;
                angle = angle % 360;
                numberOfTwists--;

                state = Convert.ToInt32(Math.Ceiling(angle / 6.666666666666667));

                state = state != 0 ? state - 1 : 0;
                NotifyWheelUpdate(angle);
            }
            else
            {
                wheelTimer.Stop();
                wheelIsMoving = false;
                NotifySpinCompletion(Sectors[state]);
            }
            
        }
        
        protected virtual void NotifyWheelUpdate(float angle) {
            WheelUpdated?.Invoke(this, new WheelUpdatedEventArgs { Angle = angle });
        }
        
        protected virtual void NotifySpinCompletion(Sector winningSector) {
            wheelSpun?.Invoke(this, new WheelEventArgs { WinningSector = winningSector });
        }
    }
}