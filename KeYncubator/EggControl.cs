using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using KeYncubator.Properties;

namespace KeYncubator
{
    public partial class EggControl : UserControl
    {
        private List<String> eggsImgs = new List<string>
        {
            "Egg.png", "BluEgg.png", "GrinEgg.png"
        };
        
        public EggControl(Random rand)
        {
            InitializeComponent();
            RandImgEgg(rand);
        }

        public int RemainingKeys
        {
            get { return int.Parse(remainingKeysLabel.Text); }
            set { remainingKeysLabel.Text = value.ToString();  }
        }

        private void RandImgEgg(Random rand)
        {
            int randNum = rand.Next(eggsImgs.Count);
            PicBoxAssign(eggsImgs[randNum]);
        }

        private void PicBoxAssign(string name)
        {
            pictureEgg.Image = Image.FromFile(Path.Combine(Application.StartupPath + "/../../Resources/", name));
        }
    }
}