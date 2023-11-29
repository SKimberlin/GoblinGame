namespace GoblinMode
{
    partial class ShopForm
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
            PlayerInventory = new ComboBox();
            ShopInventory = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // PlayerInventory
            // 
            PlayerInventory.FormattingEnabled = true;
            PlayerInventory.Location = new Point(12, 12);
            PlayerInventory.Name = "PlayerInventory";
            PlayerInventory.Size = new Size(400, 33);
            PlayerInventory.TabIndex = 0;
            // 
            // ShopInventory
            // 
            ShopInventory.FormattingEnabled = true;
            ShopInventory.Location = new Point(418, 12);
            ShopInventory.Name = "ShopInventory";
            ShopInventory.Size = new Size(400, 33);
            ShopInventory.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 388);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 2;
            button1.Text = "Sell";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(668, 388);
            button2.Name = "button2";
            button2.Size = new Size(150, 50);
            button2.TabIndex = 3;
            button2.Text = "Buy";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(339, 388);
            button3.Name = "button3";
            button3.Size = new Size(200, 50);
            button3.TabIndex = 4;
            button3.Text = "Go Back To Town";
            button3.UseVisualStyleBackColor = true;
            button3.Click += LeaveShop;
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ShopInventory);
            Controls.Add(PlayerInventory);
            Name = "ShopForm";
            Text = "ShopForm";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox PlayerInventory;
        private ComboBox ShopInventory;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}