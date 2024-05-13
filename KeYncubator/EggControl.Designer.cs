using System.ComponentModel;

namespace KeYncubator
{
    partial class EggControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureEgg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.remainingKeysLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEgg)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEgg
            // 
            this.pictureEgg.Location = new System.Drawing.Point(30, 19);
            this.pictureEgg.Name = "pictureEgg";
            this.pictureEgg.Size = new System.Drawing.Size(73, 81);
            this.pictureEgg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEgg.TabIndex = 0;
            this.pictureEgg.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remaining Key(s)";
            // 
            // remainingKeysLabel
            // 
            this.remainingKeysLabel.Location = new System.Drawing.Point(21, 120);
            this.remainingKeysLabel.Name = "remainingKeysLabel";
            this.remainingKeysLabel.Size = new System.Drawing.Size(91, 15);
            this.remainingKeysLabel.TabIndex = 2;
            this.remainingKeysLabel.Text = "0";
            this.remainingKeysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EggControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.remainingKeysLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureEgg);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "EggControl";
            this.Size = new System.Drawing.Size(132, 145);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEgg)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label remainingKeysLabel;

        private System.Windows.Forms.PictureBox pictureEgg;

        #endregion
    }
}