namespace GoblinMode
{
    partial class TownForm
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
            pictureBox1 = new PictureBox();
            TownNameBox = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 300);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TownNameBox
            // 
            TownNameBox.AutoSize = true;
            TownNameBox.Font = new Font("Ace Attorney", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TownNameBox.Location = new Point(518, 12);
            TownNameBox.Name = "TownNameBox";
            TownNameBox.Size = new Size(92, 34);
            TownNameBox.TabIndex = 17;
            TownNameBox.Text = "Name";
            // 
            // TownForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TownNameBox);
            Controls.Add(pictureBox1);
            Name = "TownForm";
            Text = "TownForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label TownNameBox;
    }
}