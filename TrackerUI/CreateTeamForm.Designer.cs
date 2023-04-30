namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.playersLabel = new System.Windows.Forms.Label();
            this.removePlayerButton = new System.Windows.Forms.Button();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.selectPlayerValue = new System.Windows.Forms.ComboBox();
            this.orLabel = new System.Windows.Forms.Label();
            this.addPlayerGroupBox = new System.Windows.Forms.GroupBox();
            this.createPlayerButton = new System.Windows.Forms.Button();
            this.phoneValue = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addPlayerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(213, 50);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Create Team";
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamNameLabel.Location = new System.Drawing.Point(23, 86);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(88, 37);
            this.teamNameLabel.TabIndex = 3;
            this.teamNameLabel.Text = "Name";
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(117, 89);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(324, 35);
            this.teamNameValue.TabIndex = 4;
            // 
            // playersLabel
            // 
            this.playersLabel.AutoSize = true;
            this.playersLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playersLabel.Location = new System.Drawing.Point(23, 168);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(100, 37);
            this.playersLabel.TabIndex = 13;
            this.playersLabel.Text = "Players";
            this.playersLabel.Click += new System.EventHandler(this.teamsAddedLabel_Click);
            // 
            // removePlayerButton
            // 
            this.removePlayerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removePlayerButton.Location = new System.Drawing.Point(800, 545);
            this.removePlayerButton.Name = "removePlayerButton";
            this.removePlayerButton.Size = new System.Drawing.Size(81, 46);
            this.removePlayerButton.TabIndex = 18;
            this.removePlayerButton.Text = "trash";
            this.removePlayerButton.UseVisualStyleBackColor = true;
            // 
            // playersListBox
            // 
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.ItemHeight = 30;
            this.playersListBox.Location = new System.Drawing.Point(23, 545);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(766, 184);
            this.playersListBox.TabIndex = 17;
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.selectLabel.Location = new System.Drawing.Point(23, 226);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(94, 37);
            this.selectLabel.TabIndex = 15;
            this.selectLabel.Text = "Select ";
            // 
            // selectPlayerValue
            // 
            this.selectPlayerValue.FormattingEnabled = true;
            this.selectPlayerValue.Location = new System.Drawing.Point(123, 229);
            this.selectPlayerValue.Name = "selectPlayerValue";
            this.selectPlayerValue.Size = new System.Drawing.Size(344, 38);
            this.selectPlayerValue.TabIndex = 14;
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.orLabel.Location = new System.Drawing.Point(487, 226);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(42, 37);
            this.orLabel.TabIndex = 19;
            this.orLabel.Text = "or";
            // 
            // addPlayerGroupBox
            // 
            this.addPlayerGroupBox.Controls.Add(this.createPlayerButton);
            this.addPlayerGroupBox.Controls.Add(this.phoneValue);
            this.addPlayerGroupBox.Controls.Add(this.phoneLabel);
            this.addPlayerGroupBox.Controls.Add(this.emailValue);
            this.addPlayerGroupBox.Controls.Add(this.emailLabel);
            this.addPlayerGroupBox.Controls.Add(this.lastNameValue);
            this.addPlayerGroupBox.Controls.Add(this.lastNameLabel);
            this.addPlayerGroupBox.Controls.Add(this.firstNameValue);
            this.addPlayerGroupBox.Controls.Add(this.firstNameLabel);
            this.addPlayerGroupBox.Location = new System.Drawing.Point(23, 296);
            this.addPlayerGroupBox.Name = "addPlayerGroupBox";
            this.addPlayerGroupBox.Size = new System.Drawing.Size(766, 221);
            this.addPlayerGroupBox.TabIndex = 20;
            this.addPlayerGroupBox.TabStop = false;
            this.addPlayerGroupBox.Text = "Add New Player";
            // 
            // createPlayerButton
            // 
            this.createPlayerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createPlayerButton.Location = new System.Drawing.Point(619, 169);
            this.createPlayerButton.Name = "createPlayerButton";
            this.createPlayerButton.Size = new System.Drawing.Size(141, 46);
            this.createPlayerButton.TabIndex = 21;
            this.createPlayerButton.Text = "create";
            this.createPlayerButton.UseVisualStyleBackColor = true;
            // 
            // phoneValue
            // 
            this.phoneValue.BackColor = System.Drawing.Color.White;
            this.phoneValue.Location = new System.Drawing.Point(482, 101);
            this.phoneValue.Name = "phoneValue";
            this.phoneValue.Size = new System.Drawing.Size(284, 35);
            this.phoneValue.TabIndex = 11;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.Location = new System.Drawing.Point(404, 103);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(72, 30);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "Phone";
            // 
            // emailValue
            // 
            this.emailValue.BackColor = System.Drawing.Color.White;
            this.emailValue.Location = new System.Drawing.Point(83, 103);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(293, 35);
            this.emailValue.TabIndex = 9;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(14, 106);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(63, 30);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            this.lastNameValue.BackColor = System.Drawing.Color.White;
            this.lastNameValue.Location = new System.Drawing.Point(523, 49);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(243, 35);
            this.lastNameValue.TabIndex = 7;
            this.lastNameValue.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.Location = new System.Drawing.Point(404, 52);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(112, 30);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";
            this.lastNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstNameValue
            // 
            this.firstNameValue.BackColor = System.Drawing.Color.White;
            this.firstNameValue.Location = new System.Drawing.Point(133, 49);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(243, 35);
            this.firstNameValue.TabIndex = 5;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.Location = new System.Drawing.Point(14, 52);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(113, 30);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First Name";
            // 
            // createTeamButton
            // 
            this.createTeamButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTeamButton.Location = new System.Drawing.Point(608, 782);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(273, 46);
            this.createTeamButton.TabIndex = 21;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 840);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.addPlayerGroupBox);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.removePlayerButton);
            this.Controls.Add(this.playersListBox);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.selectPlayerValue);
            this.Controls.Add(this.playersLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team Form";
            this.addPlayerGroupBox.ResumeLayout(false);
            this.addPlayerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Label teamNameLabel;
        private TextBox teamNameValue;
        private Label playersLabel;
        private Button removePlayerButton;
        private ListBox playersListBox;
        private Label selectLabel;
        private ComboBox selectPlayerValue;
        private Label orLabel;
        private GroupBox addPlayerGroupBox;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private TextBox phoneValue;
        private Label phoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private Button createTeamButton;
        private Button createPlayerButton;
    }
}