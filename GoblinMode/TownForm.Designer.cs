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
            button1 = new Button();
            NPCSelect = new ComboBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(8, 7);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 180);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TownNameBox
            // 
            TownNameBox.AutoSize = true;
            TownNameBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TownNameBox.Location = new Point(363, 7);
            TownNameBox.Margin = new Padding(2, 0, 2, 0);
            TownNameBox.Name = "TownNameBox";
            TownNameBox.Size = new Size(82, 29);
            TownNameBox.TabIndex = 17;
            TownNameBox.Text = "Name";
            // 
            // button1
            // 
            button1.Location = new Point(414, 229);
            button1.Name = "button1";
            button1.Size = new Size(134, 29);
            button1.TabIndex = 18;
            button1.Text = "Go To Map";
            button1.UseVisualStyleBackColor = true;
            button1.Click += GoToMap;
            // 
            // NPCSelect
            // 
            NPCSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            NPCSelect.FormattingEnabled = true;
            NPCSelect.Location = new Point(12, 229);
            NPCSelect.Name = "NPCSelect";
            NPCSelect.Size = new Size(185, 23);
            NPCSelect.TabIndex = 19;
            // 
            // button2
            // 
            button2.Location = new Point(203, 228);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 20;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SelectNPC;
            // 
            // TownForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(button2);
            Controls.Add(NPCSelect);
            Controls.Add(button1);
            Controls.Add(TownNameBox);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "TownForm";
            Text = "TownForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label TownNameBox;
        private Button button1;
        private ComboBox NPCSelect;
        private Button button2;
    }
}