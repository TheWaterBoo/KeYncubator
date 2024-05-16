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
        private readonly Random _rand = new Random();
        private List<Eggs> _eggs = new List<Eggs>();
        private readonly List<string> _names = new List<string> { "Buddy", "Max", "Bella", "Charlie", "Lucy", "Daisy", "Bailey", "Luna", "Cooper", "Sadie", "Sparky", "Rufus", "Aquiles" };
        private readonly List<string> _descriptions = new List<string>
        {
            "Un perro amigable y juguetón.",
            "Un perro leal y protector.",
            "Un perro inteligente y curioso.",
            "Un perro enérgico y travieso.",
            "Un perro cariñoso y dócil.",
            "Un perro valiente y activo.",
            "Un perro tranquilo y amable.",
            "Un perro fiel y cariñoso.",
            "Un perro sociable y amigable.",
            "Un perro afectuoso y juguetón."
        };
        
        private const int MaxEggs = 3;
        private const int unlockedSlots = 3;
        
        public Form1()
        {
            InitializeComponent();
            InitializeAddButtons();
            HookManager.KeyDown += KeyDownPressed;
            HookManager.KeyUp += KeyUpPressed;
            KeyPreview = true;
            
            //CreateEggControl();
        }

        private void CreateEggControl()
        {
            for (int i = 0; i < MaxEggs; i++)
            {
                EggControl eggControl = new EggControl(_rand);
                eggControl.Name = "EggControl" + i;
                eggControl.Location = new Point(10 + i * 150, 10);
                _eggs.Add(Eggs.CreateRandomEgg(_rand));
                eggControl.RemainingKeys = _eggs[i].RemainingKeys;
                Controls.Add(eggControl);
            }
        }

        private void InitializeAddButtons()
        {
            for (int i = 0; i < unlockedSlots; i++)
            {
                AddBtnControl addBtn = new AddBtnControl();
                addBtn.Name = "AddBtn" + i;
                addBtn.Location = new Point(10 + i * 150, 12);
                addBtn.addEggButton_Click(sender, e);
                Controls.Add(addBtn);
            }
        }

        private void KeyDownPressed(object sender, KeyEventArgs e)
        {
            foreach (var egg in _eggs.ToList())
            {
                if (egg.RemainingKeys > 0 && egg.KeyPressed(e.KeyCode))
                {
                    egg.RemainingKeys--;
                    if(egg.RemainingKeys <= 0)
                        OpenEgg(_rand);
                }
                UpdateStatus();
            }
        }

        private void KeyUpPressed(object sender, KeyEventArgs e)
        {
            foreach (var egg in _eggs)
            {
                egg.KeyReleased(e.KeyCode);
            }
        }

        private void UpdateStatus()
        {
            for (int i = 0; i < _eggs.Count; i++)
            {
                EggControl eggControl = (EggControl)this.Controls["EggControl" + i];
                eggControl.RemainingKeys = _eggs[i].RemainingKeys;
            }
        }

        private void OpenEgg(Random rand)
        {
            int rndName = rand.Next(_names.Count);
            int rndInfo = rand.Next(_descriptions.Count);
            
            HatchResult hatchMsgBox = new HatchResult();
            hatchMsgBox.mobName = _names[rndName];
            hatchMsgBox.mobInfo = _descriptions[rndInfo];
            
            hatchMsgBox.HatchedEggInfo();
            hatchMsgBox.ShowDialog();
        }
    }
}