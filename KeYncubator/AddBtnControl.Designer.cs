using System.ComponentModel;

namespace KeYncubator
{
    partial class AddBtnControl
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
            this.addEggButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEggButton
            // 
            this.addEggButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addEggButton.FlatAppearance.BorderSize = 0;
            this.addEggButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEggButton.Location = new System.Drawing.Point(0, 0);
            this.addEggButton.Name = "addEggButton";
            this.addEggButton.Size = new System.Drawing.Size(138, 203);
            this.addEggButton.TabIndex = 0;
            this.addEggButton.Text = "Create egg";
            this.addEggButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addEggButton.UseVisualStyleBackColor = true;
            this.addEggButton.Click += new System.EventHandler(this.addEggButton_Click);
            // 
            // AddBtnControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addEggButton);
            this.Name = "AddBtnControl";
            this.Size = new System.Drawing.Size(138, 203);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button addEggButton;

        #endregion
    }
}