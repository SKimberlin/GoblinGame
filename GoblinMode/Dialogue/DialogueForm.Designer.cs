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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)PlayerPortrait).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NPCPortrait).BeginInit();
            SuspendLayout();
            // 
            // PlayerPortrait
            // 
            PlayerPortrait.Location = new Point(11, 187);
            PlayerPortrait.Name = "PlayerPortrait";
            PlayerPortrait.Size = new Size(191, 240);
            PlayerPortrait.SizeMode = PictureBoxSizeMode.Zoom;
            PlayerPortrait.TabIndex = 32;
            PlayerPortrait.TabStop = false;
            // 
            // NPCPortrait
            // 
            NPCPortrait.Location = new Point(549, 12);
            NPCPortrait.Name = "NPCPortrait";
            NPCPortrait.Size = new Size(191, 240);
            NPCPortrait.SizeMode = PictureBoxSizeMode.Zoom;
            NPCPortrait.TabIndex = 33;
            NPCPortrait.TabStop = false;
            // 
            // PlayerNameBox
            // 
            PlayerNameBox.AutoSize = true;
            PlayerNameBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            PlayerNameBox.Location = new Point(210, 393);
            PlayerNameBox.Name = "PlayerNameBox";
            PlayerNameBox.Size = new Size(117, 40);
            PlayerNameBox.TabIndex = 34;
            PlayerNameBox.Text = "Name";
            // 
            // NPCNameBox
            // 
            NPCNameBox.AutoSize = true;
            NPCNameBox.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            NPCNameBox.Location = new Point(541, 12);
            NPCNameBox.Name = "NPCNameBox";
            NPCNameBox.Size = new Size(0, 40);
            NPCNameBox.TabIndex = 35;
            // 
            // DialogueBox
            // 
            DialogueBox.AutoSize = true;
            DialogueBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DialogueBox.Location = new Point(541, 47);
            DialogueBox.Name = "DialogueBox";
            DialogueBox.Size = new Size(0, 25);
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
            ResponseButton.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            ResponseButton.Location = new Point(484, 397);
            ResponseButton.Name = "ResponseButton";
            ResponseButton.Size = new Size(256, 36);
            ResponseButton.TabIndex = 38;
            ResponseButton.Text = "Submit Response";
            ResponseButton.UseVisualStyleBackColor = true;
            ResponseButton.Click += SubmitResponse;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(190, 40);
            button1.TabIndex = 39;
            button1.Text = "Leave";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DialogueForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 438);
            ControlBox = false;
            Controls.Add(button1);
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
        private Button button1;
    }
}