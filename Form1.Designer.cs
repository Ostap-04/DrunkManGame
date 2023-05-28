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
            this.playerData = new System.Windows.Forms.GroupBox();
            this.rules = new System.Windows.Forms.RichTextBox();
            this.step = new System.Windows.Forms.Button();
            this.stepsPredictLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.prediction = new System.Windows.Forms.GroupBox();
            this.nickname1 = new System.Windows.Forms.Label();
            this.nickname2 = new System.Windows.Forms.Label();
            this.playerData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.prediction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDistribute
            // 
            this.btnDistribute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDistribute.Location = new System.Drawing.Point(890, 477);
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
            this.playerNameLabel1.Location = new System.Drawing.Point(29, 47);
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
            this.gameTitle.Location = new System.Drawing.Point(441, 39);
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
            this.playerNameLabel2.Location = new System.Drawing.Point(29, 94);
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
            this.start.Location = new System.Drawing.Point(447, 475);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(144, 50);
            this.start.TabIndex = 7;
            this.start.Text = "Почати";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // playerData
            // 
            this.playerData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerData.Controls.Add(this.gamerNameInput2);
            this.playerData.Controls.Add(this.playerNameLabel2);
            this.playerData.Controls.Add(this.gamerNameInput1);
            this.playerData.Controls.Add(this.playerNameLabel1);
            this.playerData.Location = new System.Drawing.Point(30, 160);
            this.playerData.Name = "playerData";
            this.playerData.Size = new System.Drawing.Size(473, 151);
            this.playerData.TabIndex = 9;
            this.playerData.TabStop = false;
            this.playerData.Text = "playerData";
            // 
            // rules
            // 
            this.rules.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rules.Location = new System.Drawing.Point(553, 89);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(469, 323);
            this.rules.TabIndex = 10;
            this.rules.Text = "";
            // 
            // step
            // 
            this.step.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.step.Location = new System.Drawing.Point(890, 477);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(144, 50);
            this.step.TabIndex = 11;
            this.step.Text = "Крок";
            this.step.UseVisualStyleBackColor = true;
            this.step.Visible = false;
            this.step.Click += new System.EventHandler(this.step_Click);
            // 
            // stepsPredictLabel
            // 
            this.stepsPredictLabel.AutoSize = true;
            this.stepsPredictLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepsPredictLabel.Location = new System.Drawing.Point(6, 47);
            this.stepsPredictLabel.Name = "stepsPredictLabel";
            this.stepsPredictLabel.Size = new System.Drawing.Size(242, 22);
            this.stepsPredictLabel.TabIndex = 12;
            this.stepsPredictLabel.Text = "Передбачувана кі-сть ходів";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(279, 47);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(186, 28);
            this.numericUpDown1.TabIndex = 13;
            // 
            // prediction
            // 
            this.prediction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prediction.Controls.Add(this.stepsPredictLabel);
            this.prediction.Controls.Add(this.numericUpDown1);
            this.prediction.Location = new System.Drawing.Point(30, 339);
            this.prediction.Name = "prediction";
            this.prediction.Size = new System.Drawing.Size(473, 100);
            this.prediction.TabIndex = 14;
            this.prediction.TabStop = false;
            // 
            // nickname1
            // 
            this.nickname1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nickname1.AutoSize = true;
            this.nickname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nickname1.Location = new System.Drawing.Point(175, 47);
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
            this.nickname2.Location = new System.Drawing.Point(176, 511);
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
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.nickname2);
            this.Controls.Add(this.nickname1);
            this.Controls.Add(this.prediction);
            this.Controls.Add(this.step);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.playerData);
            this.Controls.Add(this.start);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.btnDistribute);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.playerData.ResumeLayout(false);
            this.playerData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.prediction.ResumeLayout(false);
            this.prediction.PerformLayout();
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
        private System.Windows.Forms.GroupBox playerData;
        private System.Windows.Forms.RichTextBox rules;
        private System.Windows.Forms.Button step;
        private System.Windows.Forms.Label stepsPredictLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox prediction;
        private System.Windows.Forms.Label nickname1;
        private System.Windows.Forms.Label nickname2;
    }
}

