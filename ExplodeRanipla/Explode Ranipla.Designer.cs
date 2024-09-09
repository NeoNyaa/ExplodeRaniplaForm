namespace ExplodeRanipla
{
    partial class ExplodeRaniplaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.CheckItOutButton = new System.Windows.Forms.Button();
            this.ExplodeRaniplaButton = new System.Windows.Forms.Button();
            this.InfoIcon = new System.Windows.Forms.PictureBox();
            this.GETSPECIALDEALSONNUTRITION = new System.Windows.Forms.Label();
            this.GiveRaniplaAGlassOfWarmMilkAndACookieButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InfoIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckItOutButton
            // 
            this.CheckItOutButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CheckItOutButton.Location = new System.Drawing.Point(137, 59);
            this.CheckItOutButton.Name = "CheckItOutButton";
            this.CheckItOutButton.Size = new System.Drawing.Size(75, 23);
            this.CheckItOutButton.TabIndex = 0;
            this.CheckItOutButton.Text = "Check it out!";
            this.CheckItOutButton.UseVisualStyleBackColor = true;
            this.CheckItOutButton.Click += new System.EventHandler(this.checkItOutButton);
            // 
            // ExplodeRaniplaButton
            // 
            this.ExplodeRaniplaButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ExplodeRaniplaButton.Location = new System.Drawing.Point(218, 59);
            this.ExplodeRaniplaButton.Name = "ExplodeRaniplaButton";
            this.ExplodeRaniplaButton.Size = new System.Drawing.Size(92, 23);
            this.ExplodeRaniplaButton.TabIndex = 1;
            this.ExplodeRaniplaButton.Text = "Explode Ranipla";
            this.ExplodeRaniplaButton.UseVisualStyleBackColor = true;
            this.ExplodeRaniplaButton.Click += new System.EventHandler(this.exitApplicationButton);
            // 
            // InfoIcon
            // 
            this.InfoIcon.Image = global::ExplodeRanipla.Properties.Resources.Icon42;
            this.InfoIcon.Location = new System.Drawing.Point(12, 12);
            this.InfoIcon.Name = "InfoIcon";
            this.InfoIcon.Size = new System.Drawing.Size(48, 48);
            this.InfoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.InfoIcon.TabIndex = 2;
            this.InfoIcon.TabStop = false;
            // 
            // GETSPECIALDEALSONNUTRITION
            // 
            this.GETSPECIALDEALSONNUTRITION.AutoSize = true;
            this.GETSPECIALDEALSONNUTRITION.Location = new System.Drawing.Point(69, 28);
            this.GETSPECIALDEALSONNUTRITION.Name = "GETSPECIALDEALSONNUTRITION";
            this.GETSPECIALDEALSONNUTRITION.Size = new System.Drawing.Size(205, 13);
            this.GETSPECIALDEALSONNUTRITION.TabIndex = 3;
            this.GETSPECIALDEALSONNUTRITION.Text = "GET SPECIAL DEALS ON [NUTRITION]!";
            // 
            // GiveRaniplaAGlassOfWarmMilkAndACookieButton
            // 
            this.GiveRaniplaAGlassOfWarmMilkAndACookieButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GiveRaniplaAGlassOfWarmMilkAndACookieButton.Location = new System.Drawing.Point(72, 88);
            this.GiveRaniplaAGlassOfWarmMilkAndACookieButton.Name = "GiveRaniplaAGlassOfWarmMilkAndACookieButton";
            this.GiveRaniplaAGlassOfWarmMilkAndACookieButton.Size = new System.Drawing.Size(238, 23);
            this.GiveRaniplaAGlassOfWarmMilkAndACookieButton.TabIndex = 4;
            this.GiveRaniplaAGlassOfWarmMilkAndACookieButton.Text = "Give Ranipla a glass of warm milk and a cookie";
            this.GiveRaniplaAGlassOfWarmMilkAndACookieButton.UseVisualStyleBackColor = true;
            this.GiveRaniplaAGlassOfWarmMilkAndACookieButton.Click += new System.EventHandler(this.exitApplicationButton);
            // 
            // ExplodeRaniplaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 121);
            this.Controls.Add(this.GiveRaniplaAGlassOfWarmMilkAndACookieButton);
            this.Controls.Add(this.GETSPECIALDEALSONNUTRITION);
            this.Controls.Add(this.InfoIcon);
            this.Controls.Add(this.ExplodeRaniplaButton);
            this.Controls.Add(this.CheckItOutButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExplodeRaniplaForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sandr0 says:";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.InfoIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckItOutButton;
        private System.Windows.Forms.Button ExplodeRaniplaButton;
        private System.Windows.Forms.PictureBox InfoIcon;
        private System.Windows.Forms.Label GETSPECIALDEALSONNUTRITION;
        private System.Windows.Forms.Button GiveRaniplaAGlassOfWarmMilkAndACookieButton;
    }
}

