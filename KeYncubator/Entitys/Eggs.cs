using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KeYncubator.Entitys
{
    public class Eggs
    {
        public int RemainingKeys { get; set; }
        private HashSet<Keys> pressedKeys = new HashSet<Keys>();

        public Eggs(int remainingKeys)
        {
            RemainingKeys = remainingKeys;
        }

        public bool KeyPressed(Keys key)
        {
            if (!pressedKeys.Contains(key))
            {
                pressedKeys.Add(key);
                return true;
            }

            return false;
        }

        public void KeyReleased(Keys key)
        {
            pressedKeys.Remove(key);
        }

        public static Eggs CreateRandomEgg(Random rand)
        {
            return new Eggs(rand.Next(100, 200));
        }
    }
}