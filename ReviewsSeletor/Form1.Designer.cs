namespace ReviewsSeletor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtfpath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            // 
            // txtfpath
            // 
            this.txtfpath.Location = new System.Drawing.Point(197, 139);
            this.txtfpath.Name = "txtfpath";
            this.txtfpath.Size = new System.Drawing.Size(920, 38);
            this.txtfpath.TabIndex = 1;
            this.txtfpath.Text = "C:\\Users\\Admin\\Desktop\\dataset2.csv";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1166, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(312, 265);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(205, 38);
            this.txtMin.TabIndex = 3;
            this.txtMin.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minimum words";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(822, 265);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(205, 38);
            this.txtMax.TabIndex = 3;
            this.txtMax.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(568, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maximum words";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1166, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 48);
            this.button2.TabIndex = 5;
            this.button2.Text = "Generate ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 1044);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfpath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Review Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfpath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

