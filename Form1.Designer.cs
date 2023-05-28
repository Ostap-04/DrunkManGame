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
            this.SuspendLayout();
            // 
            // btnDistribute
            // 
            this.btnDistribute.Location = new System.Drawing.Point(24, 40);
            this.btnDistribute.Name = "btnDistribute";
            this.btnDistribute.Size = new System.Drawing.Size(115, 23);
            this.btnDistribute.TabIndex = 0;
            this.btnDistribute.Text = "Роздати карти";
            this.btnDistribute.UseVisualStyleBackColor = true;
            this.btnDistribute.Click += new System.EventHandler(this.btnDistribute_Click);
            // 
            // TimerDistirbute
            // 
            this.TimerDistirbute.Interval = 500;
            this.TimerDistirbute.Tick += new System.EventHandler(this.TimerDistirbute_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDistribute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDistribute;
        private System.Windows.Forms.Timer TimerDistirbute;
    }
}

