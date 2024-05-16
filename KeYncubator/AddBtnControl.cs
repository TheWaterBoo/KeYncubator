using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KeYncubator
{
    public partial class AddBtnControl : UserControl
    {
        public AddBtnControl()
        {
            InitializeComponent();
            SetButtonImg();
            addEggButton.Click += addEggButton_Click;
        }

        private void SetButtonImg()
        {
            addEggButton.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath + "/../../Resources/", "add_btn64.png"));
        }

        public void addEggButton_Click(object sender, EventArgs e)
        {
            //Elimina el control para agregar huevos
            this.Dispose();
        }
    }
}