namespace DekartSystPoint1
{
    partial class DeckartSyst
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
            this.btCalc = new System.Windows.Forms.Button();
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.pbgr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbgr)).BeginInit();
            this.SuspendLayout();
            // 
            // btCalc
            // 
            this.btCalc.BackColor = System.Drawing.Color.GreenYellow;
            this.btCalc.Location = new System.Drawing.Point(307, 48);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(157, 42);
            this.btCalc.TabIndex = 0;
            this.btCalc.Text = "Де ж точка?";
            this.btCalc.UseVisualStyleBackColor = false;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(85, 29);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(71, 16);
            this.lbX.TabIndex = 1;
            this.lbX.Text = "Введіть X:";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(591, 29);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(72, 16);
            this.lbY.TabIndex = 2;
            this.lbY.Text = "Введіть Y:";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(88, 48);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 22);
            this.tbX.TabIndex = 3;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(594, 48);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 22);
            this.tbY.TabIndex = 4;
            // 
            // pbgr
            // 
            this.pbgr.BackColor = System.Drawing.Color.Honeydew;
            this.pbgr.Location = new System.Drawing.Point(152, 106);
            this.pbgr.Name = "pbgr";
            this.pbgr.Size = new System.Drawing.Size(474, 332);
            this.pbgr.TabIndex = 5;
            this.pbgr.TabStop = false;
            this.pbgr.Paint += new System.Windows.Forms.PaintEventHandler(this.pbgr_Paint);
            // 
            // DeckartSyst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbgr);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.btCalc);
            this.Name = "DeckartSyst";
            this.Text = "Декартова система координат";
            this.Load += new System.EventHandler(this.DeckartSyst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbgr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.PictureBox pbgr;
    }
}

