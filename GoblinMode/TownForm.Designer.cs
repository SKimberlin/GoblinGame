﻿namespace GoblinMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TownForm));
            button3 = new Button();
            EnemyBox = new ComboBox();
            label1 = new Label();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(370, 388);
            button3.Name = "button3";
            button3.Size = new Size(200, 50);
            button3.TabIndex = 2;
            button3.Text = "Fight Opponent";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Fight;
            // 
            // EnemyBox
            // 
            EnemyBox.DropDownStyle = ComboBoxStyle.DropDownList;
            EnemyBox.FormattingEnabled = true;
            EnemyBox.Location = new Point(12, 398);
            EnemyBox.Name = "EnemyBox";
            EnemyBox.Size = new Size(352, 33);
            EnemyBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(561, 12);
            label1.Name = "label1";
            label1.Size = new Size(240, 48);
            label1.TabIndex = 4;
            label1.Text = "Quahogoblin";
            // 
            // button4
            // 
            button4.Location = new Point(638, 266);
            button4.Name = "button4";
            button4.Size = new Size(150, 50);
            button4.TabIndex = 5;
            button4.Text = "Get Help";
            button4.UseVisualStyleBackColor = true;
            button4.Click += GetHelp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(543, 305);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button6
            // 
            button6.Location = new Point(588, 388);
            button6.Name = "button6";
            button6.Size = new Size(200, 50);
            button6.TabIndex = 8;
            button6.Text = "Refresh Opponents";
            button6.UseVisualStyleBackColor = true;
            button6.Click += RefreshOpponents;
            // 
            // button7
            // 
            button7.Location = new Point(638, 322);
            button7.Name = "button7";
            button7.Size = new Size(150, 50);
            button7.TabIndex = 9;
            button7.Text = "Rest";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Rest;
            // 
            // TownForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(EnemyBox);
            Controls.Add(button3);
            Name = "TownForm";
            Text = "TownForm";
            Shown += TownForm_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private ComboBox EnemyBox;
        private Label label1;
        private Button button4;
        private PictureBox pictureBox1;
        private Button button6;
        private Button button7;
    }
}