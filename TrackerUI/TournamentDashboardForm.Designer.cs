namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.selectTournamentLabel = new System.Windows.Forms.Label();
            this.selectTournamentValue = new System.Windows.Forms.ComboBox();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(385, 50);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "Tournament Dashboard";
            // 
            // selectTournamentLabel
            // 
            this.selectTournamentLabel.AutoSize = true;
            this.selectTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTournamentLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectTournamentLabel.Location = new System.Drawing.Point(32, 103);
            this.selectTournamentLabel.Name = "selectTournamentLabel";
            this.selectTournamentLabel.Size = new System.Drawing.Size(235, 37);
            this.selectTournamentLabel.TabIndex = 11;
            this.selectTournamentLabel.Text = "Select Tournament";
            // 
            // selectTournamentValue
            // 
            this.selectTournamentValue.FormattingEnabled = true;
            this.selectTournamentValue.Location = new System.Drawing.Point(41, 164);
            this.selectTournamentValue.Name = "selectTournamentValue";
            this.selectTournamentValue.Size = new System.Drawing.Size(433, 38);
            this.selectTournamentValue.TabIndex = 15;
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadTournamentButton.Location = new System.Drawing.Point(519, 159);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(141, 46);
            this.loadTournamentButton.TabIndex = 22;
            this.loadTournamentButton.Text = "Load";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTournamentButton.Location = new System.Drawing.Point(387, 258);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(273, 46);
            this.createTournamentButton.TabIndex = 23;
            this.createTournamentButton.Text = "Create New Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 344);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.selectTournamentValue);
            this.Controls.Add(this.selectTournamentLabel);
            this.Controls.Add(this.headerLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Label selectTournamentLabel;
        private ComboBox selectTournamentValue;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}