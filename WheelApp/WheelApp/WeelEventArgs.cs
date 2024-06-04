using System;


namespace WheelApp
{
    public class WheelEventArgs : EventArgs {
        public Sector WinningSector { get; set; }
    }
}