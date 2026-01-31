namespace Toggler
{
    partial class Win
    {
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Win));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(19, 52);
            button1.Name = "button1";
            button1.Size = new Size(116, 32);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(150, 52);
            button2.Name = "button2";
            button2.Size = new Size(116, 32);
            button2.TabIndex = 1;
            button2.Text = "Load";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ImageAlign = ContentAlignment.BottomRight;
            button3.Location = new Point(19, 121);
            button3.Name = "button3";
            button3.Size = new Size(116, 32);
            button3.TabIndex = 2;
            button3.Text = "Toggle 1 (Off)";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.ImageAlign = ContentAlignment.BottomRight;
            button4.Location = new Point(19, 171);
            button4.Name = "button4";
            button4.Size = new Size(116, 32);
            button4.TabIndex = 3;
            button4.Text = "Toggle 2 (Off)";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(328, 121);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Independent 1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Click += checkBox1_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(328, 179);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(127, 24);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Independent 2";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Click += checkBox2_Click;
            // 
            // Win
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Win";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Toggler";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
