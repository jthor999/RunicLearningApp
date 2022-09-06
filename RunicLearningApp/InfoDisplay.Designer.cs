namespace RunicLearningApp
{
    partial class InfoDisplay
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
            this.runedescript = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RuneInfoDisplay = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RuneInfoDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // runedescript
            // 
            this.runedescript.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runedescript.AutoSize = true;
            this.runedescript.BackColor = System.Drawing.Color.Transparent;
            this.runedescript.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runedescript.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.runedescript.Location = new System.Drawing.Point(241, 47);
            this.runedescript.MaximumSize = new System.Drawing.Size(300, 0);
            this.runedescript.Name = "runedescript";
            this.runedescript.Size = new System.Drawing.Size(298, 126);
            this.runedescript.TabIndex = 3;
            this.runedescript.Text = "the eldart futhrark rune is an ancient\r\n rune set used by\r\n the ancestors of toda" +
    "ys\r\n germanic and nordic folk";
            this.runedescript.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 402);
            this.button1.MaximumSize = new System.Drawing.Size(158, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Return Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RuneInfoDisplay
            // 
            this.RuneInfoDisplay.BackColor = System.Drawing.Color.Transparent;
            this.RuneInfoDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RuneInfoDisplay.Location = new System.Drawing.Point(12, 12);
            this.RuneInfoDisplay.MaximumSize = new System.Drawing.Size(144, 168);
            this.RuneInfoDisplay.MinimumSize = new System.Drawing.Size(144, 168);
            this.RuneInfoDisplay.Name = "RuneInfoDisplay";
            this.RuneInfoDisplay.Size = new System.Drawing.Size(144, 168);
            this.RuneInfoDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RuneInfoDisplay.TabIndex = 2;
            this.RuneInfoDisplay.TabStop = false;
            this.RuneInfoDisplay.Click += new System.EventHandler(this.RuneInfoDisplay_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(671, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 37);
            this.button2.TabIndex = 28;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InfoDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::RunicLearningApp.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.runedescript);
            this.Controls.Add(this.RuneInfoDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InfoDisplay_FormClosed);
            this.Shown += new System.EventHandler(this.InfoDisplay_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.RuneInfoDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox RuneInfoDisplay;
        private System.Windows.Forms.Label runedescript;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}