namespace dragonHunter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.option2Button = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // option2Button
            // 
            this.option2Button.Location = new System.Drawing.Point(345, 173);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(85, 51);
            this.option2Button.TabIndex = 0;
            this.option2Button.Text = "Start";
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(12, 25);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(758, 41);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "Welcome to Dragon Hunter";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option1Button
            // 
            this.option1Button.Location = new System.Drawing.Point(207, 179);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(96, 45);
            this.option1Button.TabIndex = 2;
            this.option1Button.Text = "button1";
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.Location = new System.Drawing.Point(473, 179);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(99, 45);
            this.option3Button.TabIndex = 3;
            this.option3Button.Text = "button2";
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::dragonHunter.Properties.Resources.knight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.option2Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dragon Hunter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option3Button;
    }
}

