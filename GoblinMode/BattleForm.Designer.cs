﻿namespace GoblinMode
{
    partial class BattleForm
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
            NPCNameBox = new Label();
            PlayerNameBox = new Label();
            NPCPortrait = new PictureBox();
            PlayerPortrait = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            PlayerCurrentHealth = new Label();
            NPCCurrentHealth = new Label();
            PlayerMaxHealth = new Label();
            label1 = new Label();
            NPCMaxHealth = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)NPCPortrait).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayerPortrait).BeginInit();
            SuspendLayout();
            // 
            // NPCNameBox
            // 
            NPCNameBox.AutoSize = true;
            NPCNameBox.Font = new Font("Ace Attorney", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NPCNameBox.Location = new Point(566, 17);
            NPCNameBox.Name = "NPCNameBox";
            NPCNameBox.Size = new Size(157, 34);
            NPCNameBox.TabIndex = 42;
            NPCNameBox.Text = "NPCNAME";
            // 
            // PlayerNameBox
            // 
            PlayerNameBox.AutoSize = true;
            PlayerNameBox.Font = new Font("Ace Attorney", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            PlayerNameBox.Location = new Point(234, 398);
            PlayerNameBox.Name = "PlayerNameBox";
            PlayerNameBox.Size = new Size(92, 34);
            PlayerNameBox.TabIndex = 41;
            PlayerNameBox.Text = "Name";
            // 
            // NPCPortrait
            // 
            NPCPortrait.Location = new Point(572, 17);
            NPCPortrait.Name = "NPCPortrait";
            NPCPortrait.Size = new Size(192, 240);
            NPCPortrait.SizeMode = PictureBoxSizeMode.Zoom;
            NPCPortrait.TabIndex = 40;
            NPCPortrait.TabStop = false;
            // 
            // PlayerPortrait
            // 
            PlayerPortrait.Location = new Point(36, 192);
            PlayerPortrait.Name = "PlayerPortrait";
            PlayerPortrait.Size = new Size(192, 240);
            PlayerPortrait.SizeMode = PictureBoxSizeMode.Zoom;
            PlayerPortrait.TabIndex = 39;
            PlayerPortrait.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Ace Attorney", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(234, 313);
            button1.Name = "button1";
            button1.Size = new Size(256, 32);
            button1.TabIndex = 43;
            button1.Text = "Attack";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Attack;
            // 
            // button2
            // 
            button2.Font = new Font("Ace Attorney", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(496, 351);
            button2.Name = "button2";
            button2.Size = new Size(256, 32);
            button2.TabIndex = 44;
            button2.Text = "Run";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Run;
            // 
            // button4
            // 
            button4.Font = new Font("Ace Attorney", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(234, 351);
            button4.Name = "button4";
            button4.Size = new Size(256, 32);
            button4.TabIndex = 46;
            button4.Text = "Block";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Block;
            // 
            // PlayerCurrentHealth
            // 
            PlayerCurrentHealth.AutoSize = true;
            PlayerCurrentHealth.Font = new Font("Ace Attorney", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PlayerCurrentHealth.Location = new Point(36, 155);
            PlayerCurrentHealth.Name = "PlayerCurrentHealth";
            PlayerCurrentHealth.Size = new Size(57, 34);
            PlayerCurrentHealth.TabIndex = 47;
            PlayerCurrentHealth.Text = "500";
            // 
            // NPCCurrentHealth
            // 
            NPCCurrentHealth.AutoSize = true;
            NPCCurrentHealth.Font = new Font("Ace Attorney", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NPCCurrentHealth.Location = new Point(572, 260);
            NPCCurrentHealth.Name = "NPCCurrentHealth";
            NPCCurrentHealth.Size = new Size(57, 34);
            NPCCurrentHealth.TabIndex = 48;
            NPCCurrentHealth.Text = "500";
            // 
            // PlayerMaxHealth
            // 
            PlayerMaxHealth.AutoSize = true;
            PlayerMaxHealth.Font = new Font("Ace Attorney", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PlayerMaxHealth.Location = new Point(171, 155);
            PlayerMaxHealth.Name = "PlayerMaxHealth";
            PlayerMaxHealth.Size = new Size(57, 34);
            PlayerMaxHealth.TabIndex = 49;
            PlayerMaxHealth.Text = "500";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ace Attorney", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(117, 155);
            label1.Name = "label1";
            label1.Size = new Size(29, 34);
            label1.TabIndex = 50;
            label1.Text = "/";
            // 
            // NPCMaxHealth
            // 
            NPCMaxHealth.AutoSize = true;
            NPCMaxHealth.Font = new Font("Ace Attorney", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NPCMaxHealth.Location = new Point(707, 260);
            NPCMaxHealth.Name = "NPCMaxHealth";
            NPCMaxHealth.Size = new Size(57, 34);
            NPCMaxHealth.TabIndex = 51;
            NPCMaxHealth.Text = "500";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ace Attorney", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(653, 260);
            label2.Name = "label2";
            label2.Size = new Size(29, 34);
            label2.TabIndex = 52;
            label2.Text = "/";
            // 
            // BattleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(NPCMaxHealth);
            Controls.Add(label1);
            Controls.Add(PlayerMaxHealth);
            Controls.Add(NPCCurrentHealth);
            Controls.Add(PlayerCurrentHealth);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(NPCNameBox);
            Controls.Add(PlayerNameBox);
            Controls.Add(NPCPortrait);
            Controls.Add(PlayerPortrait);
            Name = "BattleForm";
            Text = "BattleForm";
            ((System.ComponentModel.ISupportInitialize)NPCPortrait).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayerPortrait).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NPCNameBox;
        private Label PlayerNameBox;
        private PictureBox NPCPortrait;
        private PictureBox PlayerPortrait;
        private Button button1;
        private Button button2;
        private Button button4;
        private Label PlayerCurrentHealth;
        private Label NPCCurrentHealth;
        private Label PlayerMaxHealth;
        private Label label1;
        private Label NPCMaxHealth;
        private Label label2;
    }
}