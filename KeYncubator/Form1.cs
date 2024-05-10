using System;
using System.Collections.Generic;
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
        
        private int remainingKeys;
        private bool keyPressed;
        
        public Form1()
        {
            InitializeComponent();
            HookManager.KeyDown += new KeyEventHandler(KeyDownPressed);
            HookManager.KeyUp += new KeyEventHandler(KeyUpPressed);
            this.KeyPreview = true;
            createEgg();
            updateStatus();
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

        private void createEgg()
        {
            if (eggs.Count < maxEggs)
            {
                Eggs egg = Eggs.CreateRandomEgg();
                eggs.Add(egg);
            }
        }

        private void updateStatus()
        {
            remainingKeysLabel.Text = remainingKeys.ToString();
        }

        private void openEgg()
        {
            MessageBox.Show("Egg Hatched!! :OOO", "Egg Hatched!");
        }
    }
}