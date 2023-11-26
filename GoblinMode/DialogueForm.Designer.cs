namespace GoblinMode
{
    partial class DialogueForm
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
            PlayerPortrait = new PictureBox();
            NPCPortrait = new PictureBox();
            PlayerNameBox = new Label();
            NPCNameBox = new Label();
            DialogueBox = new Label();
            PlayerResponseBox = new ComboBox();
            ResponseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PlayerPortrait).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NPCPortrait).BeginInit();
            SuspendLayout();
            // 
            // PlayerPortrait
            // 
            PlayerPortrait.Location = new Point(12, 187);
            PlayerPortrait.Name = "PlayerPortrait";
            PlayerPortrait.Size = new Size(192, 240);
            PlayerPortrait.TabIndex = 32;
            PlayerPortrait.TabStop = false;
            // 
            // NPCPortrait
            // 
            NPCPortrait.Location = new Point(548, 12);
            NPCPortrait.Name = "NPCPortrait";
            NPCPortrait.Size = new Size(192, 240);
            NPCPortrait.SizeMode = PictureBoxSizeMode.Zoom;
            NPCPortrait.TabIndex = 33;
            NPCPortrait.TabStop = false;
            // 
            // PlayerNameBox
            // 
            PlayerNameBox.AutoSize = true;
            PlayerNameBox.Font = new Font("Ace Attorney", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            PlayerNameBox.Location = new Point(210, 393);
            PlayerNameBox.Name = "PlayerNameBox";
            PlayerNameBox.Size = new Size(92, 34);
            PlayerNameBox.TabIndex = 34;
            PlayerNameBox.Text = "Name";
            // 
            // NPCNameBox
            // 
            NPCNameBox.AutoSize = true;
            NPCNameBox.Font = new Font("Ace Attorney", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NPCNameBox.Location = new Point(542, 12);
            NPCNameBox.Name = "NPCNameBox";
            NPCNameBox.Size = new Size(0, 34);
            NPCNameBox.TabIndex = 35;
            // 
            // DialogueBox
            // 
            DialogueBox.AutoSize = true;
            DialogueBox.Font = new Font("Ace Attorney", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DialogueBox.Location = new Point(542, 46);
            DialogueBox.Name = "DialogueBox";
            DialogueBox.Size = new Size(0, 34);
            DialogueBox.TabIndex = 36;
            // 
            // PlayerResponseBox
            // 
            PlayerResponseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PlayerResponseBox.FormattingEnabled = true;
            PlayerResponseBox.Location = new Point(210, 357);
            PlayerResponseBox.Name = "PlayerResponseBox";
            PlayerResponseBox.Size = new Size(530, 33);
            PlayerResponseBox.TabIndex = 37;
            // 
            // ResponseButton
            // 
            ResponseButton.Font = new Font("Ace Attorney", 14F, FontStyle.Bold, GraphicsUnit.Point);
            ResponseButton.Location = new Point(484, 396);
            ResponseButton.Name = "ResponseButton";
            ResponseButton.Size = new Size(256, 32);
            ResponseButton.TabIndex = 38;
            ResponseButton.Text = "Submit Response";
            ResponseButton.UseVisualStyleBackColor = true;
            ResponseButton.Click += SubmitResponse;
            // 
            // DialogueForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 439);
            Controls.Add(ResponseButton);
            Controls.Add(PlayerResponseBox);
            Controls.Add(DialogueBox);
            Controls.Add(NPCNameBox);
            Controls.Add(PlayerNameBox);
            Controls.Add(NPCPortrait);
            Controls.Add(PlayerPortrait);
            Name = "DialogueForm";
            Text = "DialogueForm";
            ((System.ComponentModel.ISupportInitialize)PlayerPortrait).EndInit();
            ((System.ComponentModel.ISupportInitialize)NPCPortrait).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PlayerPortrait;
        private PictureBox NPCPortrait;
        private Label PlayerNameBox;
        private Label NPCNameBox;
        private Label DialogueBox;
        private ComboBox PlayerResponseBox;
        private Button ResponseButton;
    }
}