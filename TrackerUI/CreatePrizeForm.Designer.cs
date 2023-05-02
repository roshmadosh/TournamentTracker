namespace TrackerUI
{
    partial class CreatePrizeForm
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
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.prizePercentageValue = new System.Windows.Forms.TextBox();
            this.orLabel = new System.Windows.Forms.Label();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.percentLabel = new System.Windows.Forms.Label();
            this.dollarLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(209, 50);
            this.headerLabel.TabIndex = 3;
            this.headerLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.Location = new System.Drawing.Point(227, 113);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(100, 35);
            this.placeNumberValue.TabIndex = 11;
            this.placeNumberValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNumberLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.placeNumberLabel.Location = new System.Drawing.Point(38, 111);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(183, 37);
            this.placeNumberLabel.TabIndex = 10;
            this.placeNumberLabel.Text = "Place Number";
            // 
            // placeNameValue
            // 
            this.placeNameValue.Location = new System.Drawing.Point(227, 206);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(270, 35);
            this.placeNameValue.TabIndex = 13;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.placeNameLabel.Location = new System.Drawing.Point(38, 204);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(157, 37);
            this.placeNameLabel.TabIndex = 12;
            this.placeNameLabel.Text = "Place Name";
            // 
            // prizeAmountValue
            // 
            this.prizeAmountValue.Location = new System.Drawing.Point(361, 296);
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Size = new System.Drawing.Size(136, 35);
            this.prizeAmountValue.TabIndex = 15;
            this.prizeAmountValue.Text = "0.00";
            this.prizeAmountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // prizePercentageValue
            // 
            this.prizePercentageValue.Location = new System.Drawing.Point(397, 345);
            this.prizePercentageValue.Name = "prizePercentageValue";
            this.prizePercentageValue.Size = new System.Drawing.Size(100, 35);
            this.prizePercentageValue.TabIndex = 17;
            this.prizePercentageValue.Text = "0";
            this.prizePercentageValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.orLabel.Location = new System.Drawing.Point(306, 342);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(42, 37);
            this.orLabel.TabIndex = 20;
            this.orLabel.Text = "or";
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizeAmountLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prizeAmountLabel.Location = new System.Drawing.Point(38, 293);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(176, 37);
            this.prizeAmountLabel.TabIndex = 21;
            this.prizeAmountLabel.Text = "Prize Amount";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createPrizeButton.Location = new System.Drawing.Point(608, 403);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(273, 46);
            this.createPrizeButton.TabIndex = 22;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percentLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.percentLabel.Location = new System.Drawing.Point(503, 343);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(39, 37);
            this.percentLabel.TabIndex = 23;
            this.percentLabel.Text = "%";
            // 
            // dollarLabel
            // 
            this.dollarLabel.AutoSize = true;
            this.dollarLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dollarLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.dollarLabel.Location = new System.Drawing.Point(316, 293);
            this.dollarLabel.Name = "dollarLabel";
            this.dollarLabel.Size = new System.Drawing.Size(32, 37);
            this.dollarLabel.TabIndex = 24;
            this.dollarLabel.Text = "$";
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 461);
            this.Controls.Add(this.dollarLabel);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizePercentageValue);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize Form";
            this.Load += new System.EventHandler(this.CreatePrizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private TextBox prizePercentageValue;
        private Label orLabel;
        private Label prizeAmountLabel;
        private Button createPrizeButton;
        private Label percentLabel;
        private Label dollarLabel;
    }
}