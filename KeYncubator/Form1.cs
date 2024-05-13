using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using KeyboardHookManager;
using KeYncubator.Entitys;

namespace KeYncubator
{
    public partial class Form1 : Form
    {
        private List<Eggs> eggs = new List<Eggs>();
        private const int maxEggs = 3;
        Random rand = new Random();
        
        private int remainingKeys;
        private bool keyPressed;
        
        public Form1()
        {
            InitializeComponent();
            HookManager.KeyDown += new KeyEventHandler(KeyDownPressed);
            HookManager.KeyUp += new KeyEventHandler(KeyUpPressed);
            this.KeyPreview = true;
            
            for (int i = 0; i < maxEggs; i++)
            {
                EggControl eggControl = new EggControl(rand);
                eggControl.Name = "EggControl" + i;
                eggControl.Location = new Point(10 + i * 150, 10);
                eggs.Add(Eggs.CreateRandomEgg(rand));
                eggControl.RemainingKeys = eggs[i].RemainingKeys;
                this.Controls.Add(eggControl);
            }
        }

        private void KeyDownPressed(object sender, KeyEventArgs e)
        {
            foreach (var egg in eggs.ToList())
            {
                if (egg.RemainingKeys > 0 && egg.KeyPressed(e.KeyCode))
                {
                    egg.RemainingKeys--;
                    if(egg.RemainingKeys <= 0)
                        openEgg();
                    else
                        updateStatus();
                }
            }
        }

        private void KeyUpPressed(object sender, KeyEventArgs e)
        {
            foreach (var egg in eggs)
            {
                egg.KeyReleased(e.KeyCode);
            }
        }

        private void updateStatus()
        {
            for (int i = 0; i < eggs.Count; i++)
            {
                EggControl eggControl = (EggControl)this.Controls["EggControl" + i];
                eggControl.RemainingKeys = eggs[i].RemainingKeys;
            }
        }

        private void openEgg()
        {
            MessageBox.Show("Egg Hatched!! :OOO", "Egg Hatched!");
        }
    }
}