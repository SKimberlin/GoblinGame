namespace GoblinMode
{
    partial class MapForm
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            CurrentTown = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 400);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CurrentTown
            // 
            CurrentTown.DropDownStyle = ComboBoxStyle.DropDownList;
            CurrentTown.FormattingEnabled = true;
            CurrentTown.Location = new Point(517, 389);
            CurrentTown.Margin = new Padding(2);
            CurrentTown.Name = "CurrentTown";
            CurrentTown.Size = new Size(256, 23);
            CurrentTown.TabIndex = 38;
            // 
            // button1
            // 
            button1.Location = new Point(517, 425);
            button1.Name = "button1";
            button1.Size = new Size(255, 23);
            button1.TabIndex = 39;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GoToTown;
            // 
            // MapForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(button1);
            Controls.Add(CurrentTown);
            Controls.Add(pictureBox1);
            Name = "MapForm";
            Text = "MapForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox CurrentTown;
        private Button button1;
    }
}