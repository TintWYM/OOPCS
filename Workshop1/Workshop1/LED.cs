using System;
namespace Workshop1
{
	public class LED
	{
        private bool isOn;
        public string color;
        private int tracker;
        private static readonly string[] colors = { "Red", "Green", "Blue" };

        public LED()
        {
            isOn = false;
            this.color = "";
            this.tracker = -1;
        }

        public string getColor()
        {
            return color;
        }

        public bool isLEDOn()
        {
            return isOn;
        }

        public void isTurnOn() {
            if (!isLEDOn()) {
                isOn = true;
                tracker = IncrementTracker();
                color = colors[tracker];
            }
        }

        public void isTurnOff()
        {
            if (isLEDOn())
            {
                isOn = false;
                color = "";
            }
        }

        private int IncrementTracker()
        {
            tracker = (tracker + 1) % colors.Length;
            return tracker;
        }
    }
}

