namespace DrunkManGame
{
    partial class Form1
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
            this.btnDistribute = new System.Windows.Forms.Button();
            this.TimerDistirbute = new System.Windows.Forms.Timer(this.components);
            this.playerNameLabel1 = new System.Windows.Forms.Label();
            this.gameTitle = new System.Windows.Forms.Label();
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
            this.gameSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predictionVal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDistribute
            // 
            this.btnDistribute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDistribute.Location = new System.Drawing.Point(1128, 639);
            this.btnDistribute.Margin = new System.Windows.Forms.Padding(4);
            this.btnDistribute.Name = "btnDistribute";
            this.btnDistribute.Size = new System.Drawing.Size(144, 50);
            this.btnDistribute.TabIndex = 0;
            this.btnDistribute.Text = "Роздати карти";
            this.btnDistribute.UseVisualStyleBackColor = true;
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
            this.playerNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerNameLabel1.Location = new System.Drawing.Point(6, 44);
            this.playerNameLabel1.Name = "playerNameLabel1";
            this.playerNameLabel1.Size = new System.Drawing.Size(211, 22);
            this.playerNameLabel1.TabIndex = 1;
            this.playerNameLabel1.Text = "Введіть ім\'я 1-го гравця";
            // 
            // gameTitle
            // 
            this.gameTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gameTitle.AutoSize = true;
            this.gameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameTitle.Location = new System.Drawing.Point(560, 39);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(196, 32);
            this.gameTitle.TabIndex = 2;
            this.gameTitle.Text = "Гра в п\'яницю";
            // 
            // gamerNameInput1
            // 
            this.gamerNameInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamerNameInput1.Location = new System.Drawing.Point(279, 41);
            this.gamerNameInput1.Name = "gamerNameInput1";
            this.gamerNameInput1.Size = new System.Drawing.Size(186, 28);
            this.gamerNameInput1.TabIndex = 3;
            // 
            // playerNameLabel2
            // 
            this.playerNameLabel2.AutoSize = true;
            this.playerNameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playerNameLabel2.Location = new System.Drawing.Point(6, 94);
            this.playerNameLabel2.Name = "playerNameLabel2";
            this.playerNameLabel2.Size = new System.Drawing.Size(211, 22);
            this.playerNameLabel2.TabIndex = 4;
            this.playerNameLabel2.Text = "Введіть ім\'я 2-го гравця";
            // 
            // gamerNameInput2
            // 
            this.gamerNameInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gamerNameInput2.Location = new System.Drawing.Point(279, 91);
            this.gamerNameInput2.Name = "gamerNameInput2";
            this.gamerNameInput2.Size = new System.Drawing.Size(186, 28);
            this.gamerNameInput2.TabIndex = 5;
            // 
            // start
            // 
            this.start.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(102, 576);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(144, 50);
            this.start.TabIndex = 7;
            this.start.Text = "Почати";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // gameSettings
            // 
            this.gameSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameSettings.Controls.Add(this.cards52);
            this.gameSettings.Controls.Add(this.cards36);
            this.gameSettings.Controls.Add(this.cardsNumber);
            this.gameSettings.Controls.Add(this.predictionVal);
            this.gameSettings.Controls.Add(this.stepsPredictLabel);
            this.gameSettings.Controls.Add(this.gamerNameInput2);
            this.gameSettings.Controls.Add(this.playerNameLabel2);
            this.gameSettings.Controls.Add(this.gamerNameInput1);
            this.gameSettings.Controls.Add(this.playerNameLabel1);
            this.gameSettings.Location = new System.Drawing.Point(159, 170);
            this.gameSettings.Name = "gameSettings";
            this.gameSettings.Size = new System.Drawing.Size(473, 359);
            this.gameSettings.TabIndex = 9;
            this.gameSettings.TabStop = false;
            this.gameSettings.Text = "playerData";
            // 
            // cards52
            // 
            this.cards52.AutoSize = true;
            this.cards52.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cards52.Location = new System.Drawing.Point(279, 175);
            this.cards52.Name = "cards52";
            this.cards52.Size = new System.Drawing.Size(51, 26);
            this.cards52.TabIndex = 16;
            this.cards52.TabStop = true;
            this.cards52.Text = "52";
            this.cards52.UseVisualStyleBackColor = true;
            // 
            // cards36
            // 
            this.cards36.AutoSize = true;
            this.cards36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cards36.Location = new System.Drawing.Point(279, 149);
            this.cards36.Name = "cards36";
            this.cards36.Size = new System.Drawing.Size(51, 26);
            this.cards36.TabIndex = 15;
            this.cards36.TabStop = true;
            this.cards36.Text = "36";
            this.cards36.UseVisualStyleBackColor = true;
            // 
            // cardsNumber
            // 
            this.cardsNumber.AutoSize = true;
            this.cardsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardsNumber.Location = new System.Drawing.Point(6, 164);
            this.cardsNumber.Name = "cardsNumber";
            this.cardsNumber.Size = new System.Drawing.Size(166, 22);
            this.cardsNumber.TabIndex = 14;
            this.cardsNumber.Text = "Введіть кі-сть карт";
            // 
            // predictionVal
            // 
            this.predictionVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.predictionVal.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.predictionVal.Location = new System.Drawing.Point(279, 239);
            this.predictionVal.Maximum = new decimal(new int[] {
            3000000,
            0,
            0,
            0});
            this.predictionVal.Name = "predictionVal";
            this.predictionVal.Size = new System.Drawing.Size(186, 28);
            this.predictionVal.TabIndex = 13;
            // 
            // stepsPredictLabel
            // 
            this.stepsPredictLabel.AutoSize = true;
            this.stepsPredictLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepsPredictLabel.Location = new System.Drawing.Point(6, 245);
            this.stepsPredictLabel.Name = "stepsPredictLabel";
            this.stepsPredictLabel.Size = new System.Drawing.Size(242, 22);
            this.stepsPredictLabel.TabIndex = 12;
            this.stepsPredictLabel.Text = "Передбачувана кі-сть ходів";
            // 
            // rules
            // 
            this.rules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rules.Location = new System.Drawing.Point(672, 170);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(469, 323);
            this.rules.TabIndex = 10;
            this.rules.Text = "";
            // 
            // step
            // 
            this.step.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.step.Location = new System.Drawing.Point(1128, 639);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(144, 50);
            this.step.TabIndex = 11;
            this.step.Text = "Крок";
            this.step.UseVisualStyleBackColor = true;
            this.step.Visible = false;
            this.step.Click += new System.EventHandler(this.step_Click);
            // 
            // nickname1
            // 
            this.nickname1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nickname1.AutoSize = true;
            this.nickname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nickname1.Location = new System.Drawing.Point(294, 47);
            this.nickname1.Name = "nickname1";
            this.nickname1.Size = new System.Drawing.Size(80, 22);
            this.nickname1.TabIndex = 15;
            this.nickname1.Text = "Гравець";
            this.nickname1.Visible = false;
            // 
            // nickname2
            // 
            this.nickname2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nickname2.AutoSize = true;
            this.nickname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nickname2.Location = new System.Drawing.Point(295, 673);
            this.nickname2.Name = "nickname2";
            this.nickname2.Size = new System.Drawing.Size(80, 22);
            this.nickname2.TabIndex = 16;
            this.nickname2.Text = "Гравець";
            this.nickname2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 716);
            this.Controls.Add(this.nickname2);
            this.Controls.Add(this.nickname1);
            this.Controls.Add(this.step);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.gameSettings);
            this.Controls.Add(this.start);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.btnDistribute);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gameSettings.ResumeLayout(false);
            this.gameSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predictionVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDistribute;
        private System.Windows.Forms.Timer TimerDistirbute;
        private System.Windows.Forms.Label playerNameLabel1;
        private System.Windows.Forms.Label gameTitle;
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
    }
}

