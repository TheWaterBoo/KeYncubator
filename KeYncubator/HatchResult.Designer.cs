using System.ComponentModel;

namespace KeYncubator
{
    partial class HatchResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HatchResult));
            this.close = new System.Windows.Forms.Button();
            this.mobPicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mobNameLbl = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.mobInfoLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mobPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(111, 142);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(56, 29);
            this.close.TabIndex = 0;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.CloseMsgBtn);
            // 
            // mobPicBox
            // 
            this.mobPicBox.Image = ((System.Drawing.Image)(resources.GetObject("mobPicBox.Image")));
            this.mobPicBox.Location = new System.Drawing.Point(12, 26);
            this.mobPicBox.Name = "mobPicBox";
            this.mobPicBox.Size = new System.Drawing.Size(110, 110);
            this.mobPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mobPicBox.TabIndex = 1;
            this.mobPicBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // mobNameLbl
            // 
            this.mobNameLbl.Location = new System.Drawing.Point(186, 26);
            this.mobNameLbl.Name = "mobNameLbl";
            this.mobNameLbl.Size = new System.Drawing.Size(84, 17);
            this.mobNameLbl.TabIndex = 3;
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(128, 54);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(74, 18);
            this.label.TabIndex = 4;
            this.label.Text = "Description:";
            // 
            // mobInfoLbl
            // 
            this.mobInfoLbl.Location = new System.Drawing.Point(128, 81);
            this.mobInfoLbl.Name = "mobInfoLbl";
            this.mobInfoLbl.Size = new System.Drawing.Size(142, 55);
            this.mobInfoLbl.TabIndex = 5;
            // 
            // HatchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 183);
            this.Controls.Add(this.mobInfoLbl);
            this.Controls.Add(this.label);
            this.Controls.Add(this.mobNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mobPicBox);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HatchResult";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Egg Hatched!!";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.mobPicBox)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label mobInfoLbl;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mobNameLbl;
        private System.Windows.Forms.Label label;

        private System.Windows.Forms.PictureBox mobPicBox;

        private System.Windows.Forms.Button close;

        #endregion
    }
}