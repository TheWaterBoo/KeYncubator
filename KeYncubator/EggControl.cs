using System;
using System.Drawing;
using System.Windows.Forms;
using KeYncubator.Properties;

namespace KeYncubator
{
    public partial class EggControl : UserControl
    {
        public EggControl(Random rand)
        {
            InitializeComponent();
            randImgEgg(rand);
        }

        public int RemainingKeys
        {
            get { return int.Parse(remainingKeysLabel.Text); }
            set { remainingKeysLabel.Text = value.ToString();  }
        }

        private void randImgEgg(Random rand)
        {
            int randNum = rand.Next(1, 4);
            
            switch (randNum)
            {
                case 1:
                    pictureEgg.Image = Image.FromFile(@"E:\JobStuff\Github\KeYncubator\KeYncubator\Resources\Egg.png");
                    break;
                case 2:
                    pictureEgg.Image = Image.FromFile(@"E:\JobStuff\Github\KeYncubator\KeYncubator\Resources\BluEgg.png");
                    break;
                case 3:
                    pictureEgg.Image = Image.FromFile(@"E:\JobStuff\Github\KeYncubator\KeYncubator\Resources\GrinEgg.png");
                    break;
            }
        }
    }
}