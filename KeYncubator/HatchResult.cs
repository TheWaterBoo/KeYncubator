using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KeYncubator
{
    public partial class HatchResult : Form
    {
        private List<String> mobsImgs = new List<string>
        {
            "randDogGif1.gif", "annoyDogGif.gif"
        };
        
        public string mobName { get; set; }
        public string mobInfo { get; set; }
        private readonly Random _rand = new Random();
        
        public HatchResult()
        {
            InitializeComponent();
            RandMobImg(_rand);
        }

        public void HatchedEggInfo()
        {
            mobNameLbl.Text = mobName;
            mobInfoLbl.Text = mobInfo;
        }

        private void RandMobImg(Random rand)
        {
            int randNum = rand.Next(mobsImgs.Count);
            PicBoxAssign(mobsImgs[randNum]);
        }

        private void PicBoxAssign(string name)
        {
            mobPicBox.Image = Image.FromFile(Path.Combine(Application.StartupPath + "/../../Resources/", name));
        }
        
        private void CloseMsgBtn(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}