namespace GoblinMode
{
    partial class InventoryForm
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
            WeaponBox = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            WeaponNameLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            WeaponDamageLabel = new Label();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            HealingItemBox = new ComboBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // WeaponBox
            // 
            WeaponBox.FormattingEnabled = true;
            WeaponBox.Location = new Point(308, 13);
            WeaponBox.Name = "WeaponBox";
            WeaponBox.Size = new Size(480, 33);
            WeaponBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(190, 13);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "View Weapon";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ViewWeapon;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 234);
            label1.Name = "label1";
            label1.Size = new Size(226, 38);
            label1.TabIndex = 2;
            label1.Text = "Current Weapon:";
            // 
            // WeaponNameLabel
            // 
            WeaponNameLabel.AutoSize = true;
            WeaponNameLabel.Location = new Point(101, 281);
            WeaponNameLabel.Name = "WeaponNameLabel";
            WeaponNameLabel.Size = new Size(130, 25);
            WeaponNameLabel.TabIndex = 3;
            WeaponNameLabel.Text = "Weapon Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 281);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 4;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 306);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 5;
            label3.Text = "Damage:";
            // 
            // WeaponDamageLabel
            // 
            WeaponDamageLabel.AutoSize = true;
            WeaponDamageLabel.Location = new Point(101, 306);
            WeaponDamageLabel.Name = "WeaponDamageLabel";
            WeaponDamageLabel.Size = new Size(130, 25);
            WeaponDamageLabel.TabIndex = 7;
            WeaponDamageLabel.Text = "Weapon Name";
            // 
            // button2
            // 
            button2.Location = new Point(676, 52);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 8;
            button2.Text = "Equip";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(676, 240);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 9;
            button3.Text = "Use";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(190, 52);
            label4.Name = "label4";
            label4.Size = new Size(125, 38);
            label4.TabIndex = 10;
            label4.Text = "Weapon:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(321, 65);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 11;
            label5.Text = "Name:";
            // 
            // HealingItemBox
            // 
            HealingItemBox.FormattingEnabled = true;
            HealingItemBox.Location = new Point(308, 201);
            HealingItemBox.Name = "HealingItemBox";
            HealingItemBox.Size = new Size(480, 33);
            HealingItemBox.TabIndex = 12;
            // 
            // button4
            // 
            button4.Location = new Point(190, 201);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 13;
            button4.Text = "View Weapon";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ViewHealingItem;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(HealingItemBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(WeaponDamageLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(WeaponNameLabel);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(WeaponBox);
            Name = "InventoryForm";
            Text = "InventoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox WeaponBox;
        private Button button1;
        private Label label1;
        private Label WeaponNameLabel;
        private Label label2;
        private Label label3;
        private Label WeaponDamageLabel;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private ComboBox HealingItemBox;
        private Button button4;
    }
}