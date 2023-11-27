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
            PlayerPortrait.Location = new Point(8, 112);
            PlayerPortrait.Margin = new Padding(2);
            PlayerPortrait.Name = "PlayerPortrait";
            PlayerPortrait.Size = new Size(134, 144);
            PlayerPortrait.TabIndex = 32;
            PlayerPortrait.TabStop = false;
            // 
            // NPCPortrait
            // 
            NPCPortrait.Location = new Point(384, 7);
            NPCPortrait.Margin = new Padding(2);
            NPCPortrait.Name = "NPCPortrait";
            NPCPortrait.Size = new Size(134, 144);
            NPCPortrait.SizeMode = PictureBoxSizeMode.Zoom;
            NPCPortrait.TabIndex = 33;
            NPCPortrait.TabStop = false;
            // 
            // PlayerNameBox
            // 
            PlayerNameBox.AutoSize = true;
            PlayerNameBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            PlayerNameBox.Location = new Point(147, 236);
            PlayerNameBox.Margin = new Padding(2, 0, 2, 0);
            PlayerNameBox.Name = "PlayerNameBox";
            PlayerNameBox.Size = new Size(82, 29);
            PlayerNameBox.TabIndex = 34;
            PlayerNameBox.Text = "Name";
            // 
            // NPCNameBox
            // 
            NPCNameBox.AutoSize = true;
            NPCNameBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NPCNameBox.Location = new Point(379, 7);
            NPCNameBox.Margin = new Padding(2, 0, 2, 0);
            NPCNameBox.Name = "NPCNameBox";
            NPCNameBox.Size = new Size(0, 29);
            NPCNameBox.TabIndex = 35;
            // 
            // DialogueBox
            // 
            DialogueBox.AutoSize = true;
            DialogueBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DialogueBox.Location = new Point(379, 28);
            DialogueBox.Margin = new Padding(2, 0, 2, 0);
            DialogueBox.Name = "DialogueBox";
            DialogueBox.Size = new Size(0, 29);
            DialogueBox.TabIndex = 36;
            // 
            // PlayerResponseBox
            // 
            PlayerResponseBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PlayerResponseBox.FormattingEnabled = true;
            PlayerResponseBox.Location = new Point(147, 214);
            PlayerResponseBox.Margin = new Padding(2);
            PlayerResponseBox.Name = "PlayerResponseBox";
            PlayerResponseBox.Size = new Size(372, 23);
            PlayerResponseBox.TabIndex = 37;
            // 
            // ResponseButton
            // 
            ResponseButton.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            ResponseButton.Location = new Point(339, 238);
            ResponseButton.Margin = new Padding(2);
            ResponseButton.Name = "ResponseButton";
            ResponseButton.Size = new Size(179, 19);
            ResponseButton.TabIndex = 38;
            ResponseButton.Text = "Submit Response";
            ResponseButton.UseVisualStyleBackColor = true;
            ResponseButton.Click += SubmitResponse;
            // 
            // DialogueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 263);
            Controls.Add(ResponseButton);
            Controls.Add(PlayerResponseBox);
            Controls.Add(DialogueBox);
            Controls.Add(NPCNameBox);
            Controls.Add(PlayerNameBox);
            Controls.Add(NPCPortrait);
            Controls.Add(PlayerPortrait);
            Margin = new Padding(2);
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