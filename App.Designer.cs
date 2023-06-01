namespace DrunkManGame
{
    partial class App
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.btnDistribute = new System.Windows.Forms.Button();
            this.TimerDistirbute = new System.Windows.Forms.Timer(this.components);
            this.playerNameLabel1 = new System.Windows.Forms.Label();
            this.gamerNameInput1 = new System.Windows.Forms.TextBox();
            this.playerNameLabel2 = new System.Windows.Forms.Label();
            this.gamerNameInput2 = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.gameSettings = new System.Windows.Forms.GroupBox();
            this.cards52 = new System.Windows.Forms.RadioButton();
            this.cards36 = new System.Windows.Forms.RadioButton();
            this.cardsNumber = new System.Windows.Forms.Label();
            this.predictionVal = new System.Windows.Forms.NumericUpDown();
            this.stepsPredictLabel = new System.Windows.Forms.Label();
            this.rules = new System.Windows.Forms.RichTextBox();
            this.step = new System.Windows.Forms.Button();
            this.nickname1 = new System.Windows.Forms.Label();
            this.nickname2 = new System.Windows.Forms.Label();
            this.gameTitle = new System.Windows.Forms.PictureBox();
            this.rulesText = new System.Windows.Forms.Label();
            this.gameSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predictionVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDistribute
            // 
            this.btnDistribute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDistribute.BackColor = System.Drawing.Color.Transparent;
            this.btnDistribute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistribute.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDistribute.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnDistribute.Location = new System.Drawing.Point(1088, 639);
            this.btnDistribute.Margin = new System.Windows.Forms.Padding(4);
            this.btnDistribute.Name = "btnDistribute";
            this.btnDistribute.Size = new System.Drawing.Size(184, 50);
            this.btnDistribute.TabIndex = 0;
            this.btnDistribute.Text = "Роздати карти";
            this.btnDistribute.UseVisualStyleBackColor = false;
            this.btnDistribute.Visible = false;
            this.btnDistribute.Click += new System.EventHandler(this.btnDistribute_Click);
            // 
            // TimerDistirbute
            // 
            this.TimerDistirbute.Tick += new System.EventHandler(this.TimerDistirbute_Tick);
            // 
            // playerNameLabel1
            // 
            this.playerNameLabel1.AutoSize = true;
            this.playerNameLabel1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel1.ForeColor = System.Drawing.Color.Cornsilk;
            this.playerNameLabel1.Location = new System.Drawing.Point(5, 41);
            this.playerNameLabel1.Name = "playerNameLabel1";
            this.playerNameLabel1.Size = new System.Drawing.Size(285, 30);
            this.playerNameLabel1.TabIndex = 1;
            this.playerNameLabel1.Text = "Введіть ім\'я 1-го гравця";
            // 
            // gamerNameInput1
            // 
            this.gamerNameInput1.BackColor = System.Drawing.Color.Cornsilk;
            this.gamerNameInput1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F);
            this.gamerNameInput1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gamerNameInput1.Location = new System.Drawing.Point(375, 43);
            this.gamerNameInput1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gamerNameInput1.Name = "gamerNameInput1";
            this.gamerNameInput1.Size = new System.Drawing.Size(185, 37);
            this.gamerNameInput1.TabIndex = 0;
            // 
            // playerNameLabel2
            // 
            this.playerNameLabel2.AutoSize = true;
            this.playerNameLabel2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel2.ForeColor = System.Drawing.Color.Cornsilk;
            this.playerNameLabel2.Location = new System.Drawing.Point(5, 94);
            this.playerNameLabel2.Name = "playerNameLabel2";
            this.playerNameLabel2.Size = new System.Drawing.Size(286, 30);
            this.playerNameLabel2.TabIndex = 4;
            this.playerNameLabel2.Text = "Введіть ім\'я 2-го гравця";
            // 
            // gamerNameInput2
            // 
            this.gamerNameInput2.BackColor = System.Drawing.Color.Cornsilk;
            this.gamerNameInput2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F);
            this.gamerNameInput2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gamerNameInput2.Location = new System.Drawing.Point(375, 94);
            this.gamerNameInput2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gamerNameInput2.Name = "gamerNameInput2";
            this.gamerNameInput2.Size = new System.Drawing.Size(185, 37);
            this.gamerNameInput2.TabIndex = 1;
            // 
            // start
            // 
            this.start.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.start.BackColor = System.Drawing.Color.Brown;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.Snow;
            this.start.Location = new System.Drawing.Point(575, 586);
            this.start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(191, 50);
            this.start.TabIndex = 6;
            this.start.Text = "Почати";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // gameSettings
            // 
            this.gameSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameSettings.BackColor = System.Drawing.Color.Transparent;
            this.gameSettings.Controls.Add(this.cards52);
            this.gameSettings.Controls.Add(this.cards36);
            this.gameSettings.Controls.Add(this.cardsNumber);
            this.gameSettings.Controls.Add(this.predictionVal);
            this.gameSettings.Controls.Add(this.stepsPredictLabel);
            this.gameSettings.Controls.Add(this.gamerNameInput2);
            this.gameSettings.Controls.Add(this.playerNameLabel2);
            this.gameSettings.Controls.Add(this.gamerNameInput1);
            this.gameSettings.Controls.Add(this.playerNameLabel1);
            this.gameSettings.Location = new System.Drawing.Point(44, 170);
            this.gameSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameSettings.Name = "gameSettings";
            this.gameSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameSettings.Size = new System.Drawing.Size(588, 359);
            this.gameSettings.TabIndex = 9;
            this.gameSettings.TabStop = false;
            // 
            // cards52
            // 
            this.cards52.AutoSize = true;
            this.cards52.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cards52.ForeColor = System.Drawing.Color.Cornsilk;
            this.cards52.Location = new System.Drawing.Point(375, 193);
            this.cards52.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cards52.Name = "cards52";
            this.cards52.Size = new System.Drawing.Size(59, 32);
            this.cards52.TabIndex = 3;
            this.cards52.TabStop = true;
            this.cards52.Text = "52";
            this.cards52.UseVisualStyleBackColor = true;
            this.cards52.CheckedChanged += new System.EventHandler(this.cards52_CheckedChanged);
            // 
            // cards36
            // 
            this.cards36.AutoSize = true;
            this.cards36.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cards36.ForeColor = System.Drawing.Color.Cornsilk;
            this.cards36.Location = new System.Drawing.Point(375, 145);
            this.cards36.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cards36.Name = "cards36";
            this.cards36.Size = new System.Drawing.Size(59, 32);
            this.cards36.TabIndex = 2;
            this.cards36.TabStop = true;
            this.cards36.Text = "36";
            this.cards36.UseVisualStyleBackColor = true;
            this.cards36.CheckedChanged += new System.EventHandler(this.cards36_CheckedChanged);
            // 
            // cardsNumber
            // 
            this.cardsNumber.AutoSize = true;
            this.cardsNumber.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardsNumber.ForeColor = System.Drawing.Color.Cornsilk;
            this.cardsNumber.Location = new System.Drawing.Point(5, 160);
            this.cardsNumber.Name = "cardsNumber";
            this.cardsNumber.Size = new System.Drawing.Size(227, 30);
            this.cardsNumber.TabIndex = 14;
            this.cardsNumber.Text = "Введіть кі-сть карт";
            // 
            // predictionVal
            // 
            this.predictionVal.BackColor = System.Drawing.Color.Cornsilk;
            this.predictionVal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictionVal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.predictionVal.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.predictionVal.Location = new System.Drawing.Point(375, 245);
            this.predictionVal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.predictionVal.Maximum = new decimal(new int[] {
            3000000,
            0,
            0,
            0});
            this.predictionVal.Name = "predictionVal";
            this.predictionVal.Size = new System.Drawing.Size(187, 35);
            this.predictionVal.TabIndex = 4;
            // 
            // stepsPredictLabel
            // 
            this.stepsPredictLabel.AutoSize = true;
            this.stepsPredictLabel.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepsPredictLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.stepsPredictLabel.Location = new System.Drawing.Point(5, 245);
            this.stepsPredictLabel.Name = "stepsPredictLabel";
            this.stepsPredictLabel.Size = new System.Drawing.Size(325, 30);
            this.stepsPredictLabel.TabIndex = 12;
            this.stepsPredictLabel.Text = "Передбачувана кі-сть ходів";
            // 
            // rules
            // 
            this.rules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rules.BackColor = System.Drawing.Color.Cornsilk;
            this.rules.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rules.ForeColor = System.Drawing.Color.SaddleBrown;
            this.rules.Location = new System.Drawing.Point(744, 244);
            this.rules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(436, 200);
            this.rules.TabIndex = 5;
            this.rules.Text = "";
            // 
            // step
            // 
            this.step.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.step.BackColor = System.Drawing.Color.Transparent;
            this.step.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.step.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step.ForeColor = System.Drawing.Color.Cornsilk;
            this.step.Location = new System.Drawing.Point(1088, 639);
            this.step.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(184, 50);
            this.step.TabIndex = 11;
            this.step.Text = "Крок";
            this.step.UseVisualStyleBackColor = false;
            this.step.Visible = false;
            this.step.Click += new System.EventHandler(this.step_Click);
            // 
            // nickname1
            // 
            this.nickname1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nickname1.AutoSize = true;
            this.nickname1.BackColor = System.Drawing.Color.Transparent;
            this.nickname1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.nickname1.ForeColor = System.Drawing.Color.Cornsilk;
            this.nickname1.Location = new System.Drawing.Point(275, 43);
            this.nickname1.Name = "nickname1";
            this.nickname1.Size = new System.Drawing.Size(111, 28);
            this.nickname1.TabIndex = 15;
            this.nickname1.Text = "Гравець";
            this.nickname1.Visible = false;
            // 
            // nickname2
            // 
            this.nickname2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nickname2.AutoSize = true;
            this.nickname2.BackColor = System.Drawing.Color.Transparent;
            this.nickname2.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.nickname2.ForeColor = System.Drawing.Color.Cornsilk;
            this.nickname2.Location = new System.Drawing.Point(275, 666);
            this.nickname2.Name = "nickname2";
            this.nickname2.Size = new System.Drawing.Size(111, 28);
            this.nickname2.TabIndex = 16;
            this.nickname2.Text = "Гравець";
            this.nickname2.Visible = false;
            // 
            // gameTitle
            // 
            this.gameTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gameTitle.BackColor = System.Drawing.Color.Transparent;
            this.gameTitle.Image = ((System.Drawing.Image)(resources.GetObject("gameTitle.Image")));
            this.gameTitle.Location = new System.Drawing.Point(375, 43);
            this.gameTitle.Margin = new System.Windows.Forms.Padding(4);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(604, 59);
            this.gameTitle.TabIndex = 17;
            this.gameTitle.TabStop = false;
            // 
            // rulesText
            // 
            this.rulesText.AutoSize = true;
            this.rulesText.BackColor = System.Drawing.Color.Transparent;
            this.rulesText.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesText.ForeColor = System.Drawing.Color.Cornsilk;
            this.rulesText.Location = new System.Drawing.Point(888, 194);
            this.rulesText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rulesText.Name = "rulesText";
            this.rulesText.Size = new System.Drawing.Size(164, 33);
            this.rulesText.TabIndex = 18;
            this.rulesText.Text = "ПРАВИЛА ";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1305, 716);
            this.Controls.Add(this.rulesText);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.nickname2);
            this.Controls.Add(this.nickname1);
            this.Controls.Add(this.step);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.gameSettings);
            this.Controls.Add(this.start);
            this.Controls.Add(this.btnDistribute);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "App";
            this.Text = "Моделювання кaрткової  гри \"П\'яниця\"";
            this.gameSettings.ResumeLayout(false);
            this.gameSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predictionVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDistribute;
        private System.Windows.Forms.Timer TimerDistirbute;
        private System.Windows.Forms.Label playerNameLabel1;
        private System.Windows.Forms.TextBox gamerNameInput1;
        private System.Windows.Forms.Label playerNameLabel2;
        private System.Windows.Forms.TextBox gamerNameInput2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.GroupBox gameSettings;
        private System.Windows.Forms.RichTextBox rules;
        private System.Windows.Forms.Button step;
        private System.Windows.Forms.Label stepsPredictLabel;
        private System.Windows.Forms.NumericUpDown predictionVal;
        private System.Windows.Forms.Label nickname1;
        private System.Windows.Forms.Label nickname2;
        private System.Windows.Forms.RadioButton cards52;
        private System.Windows.Forms.RadioButton cards36;
        private System.Windows.Forms.Label cardsNumber;
        private System.Windows.Forms.PictureBox gameTitle;
        private System.Windows.Forms.Label rulesText;
    }
}

