namespace SentimentAnalyzer
{
    partial class frmDSGenerator
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtfPath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.RichTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.txtMainComment = new System.Windows.Forms.RichTextBox();
            this.chLast = new System.Windows.Forms.CheckBox();
            this.chkImportant = new System.Windows.Forms.CheckBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tval3 = new System.Windows.Forms.TextBox();
            this.tval2 = new System.Windows.Forms.TextBox();
            this.tval1 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TrackBar();
            this.tb2 = new System.Windows.Forms.TrackBar();
            this.tb1 = new System.Windows.Forms.TrackBar();
            this.lbl1 = new System.Windows.Forms.Label();
            this.rdGreet = new System.Windows.Forms.CheckBox();
            this.rdApprec = new System.Windows.Forms.CheckBox();
            this.rdCommit = new System.Windows.Forms.CheckBox();
            this.rdWell = new System.Windows.Forms.CheckBox();
            this.rdUnspec = new System.Windows.Forms.CheckBox();
            this.rdConReq = new System.Windows.Forms.CheckBox();
            this.rdAsk = new System.Windows.Forms.CheckBox();
            this.rdSol = new System.Windows.Forms.CheckBox();
            this.rdRecReq = new System.Windows.Forms.CheckBox();
            this.rdApol = new System.Windows.Forms.CheckBox();
            this.rdSuggReq = new System.Windows.Forms.CheckBox();
            this.sent = new System.Windows.Forms.GroupBox();
            this.rdUpdReq = new System.Windows.Forms.CheckBox();
            this.rdAppInfo = new System.Windows.Forms.CheckBox();
            this.rdCurrRel = new System.Windows.Forms.CheckBox();
            this.rdUserEng = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb1)).BeginInit();
            this.sent.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfPath
            // 
            this.txtfPath.Location = new System.Drawing.Point(31, 12);
            this.txtfPath.Margin = new System.Windows.Forms.Padding(1);
            this.txtfPath.Name = "txtfPath";
            this.txtfPath.Size = new System.Drawing.Size(444, 22);
            this.txtfPath.TabIndex = 1;
            this.txtfPath.Text = "C:\\Users\\Admin\\Desktop\\dataset2.csv";
            this.txtfPath.TextChanged += new System.EventHandler(this.txtfPath_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(556, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Load  Comment";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(809, 454);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 49);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(481, 158);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 49);
            this.button5.TabIndex = 8;
            this.button5.Text = "Skip Comment";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblComment
            // 
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComment.Location = new System.Drawing.Point(31, 42);
            this.lblComment.Margin = new System.Windows.Forms.Padding(4);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(444, 317);
            this.lblComment.TabIndex = 9;
            this.lblComment.Text = "";
            this.lblComment.TextChanged += new System.EventHandler(this.lblComment_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(809, 386);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 47);
            this.button6.TabIndex = 10;
            this.button6.Text = "Skip Sentence";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtMainComment
            // 
            this.txtMainComment.Location = new System.Drawing.Point(640, 53);
            this.txtMainComment.Margin = new System.Windows.Forms.Padding(4);
            this.txtMainComment.Name = "txtMainComment";
            this.txtMainComment.Size = new System.Drawing.Size(297, 306);
            this.txtMainComment.TabIndex = 12;
            this.txtMainComment.Text = "";
            // 
            // chLast
            // 
            this.chLast.AutoSize = true;
            this.chLast.Location = new System.Drawing.Point(713, 15);
            this.chLast.Margin = new System.Windows.Forms.Padding(4);
            this.chLast.Name = "chLast";
            this.chLast.Size = new System.Drawing.Size(155, 21);
            this.chLast.TabIndex = 13;
            this.chLast.Text = "Start From Previous";
            this.chLast.UseVisualStyleBackColor = true;
            // 
            // chkImportant
            // 
            this.chkImportant.AutoSize = true;
            this.chkImportant.Location = new System.Drawing.Point(481, 235);
            this.chkImportant.Margin = new System.Windows.Forms.Padding(4);
            this.chkImportant.Name = "chkImportant";
            this.chkImportant.Size = new System.Drawing.Size(89, 21);
            this.chkImportant.TabIndex = 14;
            this.chkImportant.Text = "Important";
            this.chkImportant.UseVisualStyleBackColor = true;
            this.chkImportant.CheckedChanged += new System.EventHandler(this.chkImportant_CheckedChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(16, 74);
            this.lbl2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(46, 17);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "label1";
            this.lbl2.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(16, 132);
            this.lbl3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(46, 17);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "label1";
            this.lbl3.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tval3);
            this.groupBox1.Controls.Add(this.tval2);
            this.groupBox1.Controls.Add(this.tval1);
            this.groupBox1.Controls.Add(this.tb3);
            this.groupBox1.Controls.Add(this.tb2);
            this.groupBox1.Controls.Add(this.tb1);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Location = new System.Drawing.Point(13, 560);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(812, 193);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // tval3
            // 
            this.tval3.Location = new System.Drawing.Point(683, 132);
            this.tval3.Margin = new System.Windows.Forms.Padding(1);
            this.tval3.Name = "tval3";
            this.tval3.Size = new System.Drawing.Size(67, 22);
            this.tval3.TabIndex = 2;
            this.tval3.Text = "0";
            this.tval3.Visible = false;
            // 
            // tval2
            // 
            this.tval2.Location = new System.Drawing.Point(683, 74);
            this.tval2.Margin = new System.Windows.Forms.Padding(1);
            this.tval2.Name = "tval2";
            this.tval2.Size = new System.Drawing.Size(67, 22);
            this.tval2.TabIndex = 2;
            this.tval2.Text = "0";
            this.tval2.Visible = false;
            // 
            // tval1
            // 
            this.tval1.Location = new System.Drawing.Point(683, 27);
            this.tval1.Margin = new System.Windows.Forms.Padding(1);
            this.tval1.Name = "tval1";
            this.tval1.Size = new System.Drawing.Size(67, 22);
            this.tval1.TabIndex = 2;
            this.tval1.Text = "100";
            this.tval1.Visible = false;
            // 
            // tb3
            // 
            this.tb3.LargeChange = 10;
            this.tb3.Location = new System.Drawing.Point(244, 132);
            this.tb3.Margin = new System.Windows.Forms.Padding(1);
            this.tb3.Maximum = 100;
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(299, 56);
            this.tb3.SmallChange = 10;
            this.tb3.TabIndex = 1;
            this.tb3.TickFrequency = 10;
            this.tb3.Value = 100;
            this.tb3.Visible = false;
            this.tb3.Scroll += new System.EventHandler(this.tb3_Scroll);
            this.tb3.ValueChanged += new System.EventHandler(this.tb3_ValueChanged);
            // 
            // tb2
            // 
            this.tb2.LargeChange = 10;
            this.tb2.Location = new System.Drawing.Point(244, 74);
            this.tb2.Margin = new System.Windows.Forms.Padding(1);
            this.tb2.Maximum = 100;
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(299, 56);
            this.tb2.SmallChange = 10;
            this.tb2.TabIndex = 1;
            this.tb2.TickFrequency = 10;
            this.tb2.Value = 100;
            this.tb2.Visible = false;
            this.tb2.Scroll += new System.EventHandler(this.tb2_Scroll);
            this.tb2.ValueChanged += new System.EventHandler(this.tb2_ValueChanged);
            // 
            // tb1
            // 
            this.tb1.LargeChange = 10;
            this.tb1.Location = new System.Drawing.Point(244, 27);
            this.tb1.Margin = new System.Windows.Forms.Padding(1);
            this.tb1.Maximum = 100;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(299, 56);
            this.tb1.SmallChange = 10;
            this.tb1.TabIndex = 1;
            this.tb1.TickFrequency = 10;
            this.tb1.Value = 100;
            this.tb1.Visible = false;
            this.tb1.Scroll += new System.EventHandler(this.tb1_Scroll);
            this.tb1.ValueChanged += new System.EventHandler(this.tb1_ValueChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(16, 27);
            this.lbl1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(46, 17);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "label1";
            this.lbl1.Visible = false;
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // rdGreet
            // 
            this.rdGreet.AutoSize = true;
            this.rdGreet.Location = new System.Drawing.Point(19, 28);
            this.rdGreet.Margin = new System.Windows.Forms.Padding(1);
            this.rdGreet.Name = "rdGreet";
            this.rdGreet.Size = new System.Drawing.Size(85, 21);
            this.rdGreet.TabIndex = 0;
            this.rdGreet.Text = "Greeting";
            this.rdGreet.UseVisualStyleBackColor = true;
            this.rdGreet.CheckedChanged += new System.EventHandler(this.rdQuestion_CheckedChanged);
            // 
            // rdApprec
            // 
            this.rdApprec.AutoSize = true;
            this.rdApprec.Location = new System.Drawing.Point(123, 28);
            this.rdApprec.Margin = new System.Windows.Forms.Padding(1);
            this.rdApprec.Name = "rdApprec";
            this.rdApprec.Size = new System.Drawing.Size(109, 21);
            this.rdApprec.TabIndex = 0;
            this.rdApprec.Text = "Appreciation";
            this.rdApprec.UseVisualStyleBackColor = true;
            this.rdApprec.CheckedChanged += new System.EventHandler(this.rdQuestion_CheckedChanged);
            // 
            // rdCommit
            // 
            this.rdCommit.AutoSize = true;
            this.rdCommit.Location = new System.Drawing.Point(245, 28);
            this.rdCommit.Margin = new System.Windows.Forms.Padding(1);
            this.rdCommit.Name = "rdCommit";
            this.rdCommit.Size = new System.Drawing.Size(107, 21);
            this.rdCommit.TabIndex = 0;
            this.rdCommit.Text = "Commitment";
            this.rdCommit.UseVisualStyleBackColor = true;
            this.rdCommit.CheckedChanged += new System.EventHandler(this.rdQuestion_CheckedChanged);
            // 
            // rdWell
            // 
            this.rdWell.AutoSize = true;
            this.rdWell.Location = new System.Drawing.Point(245, 83);
            this.rdWell.Margin = new System.Windows.Forms.Padding(1);
            this.rdWell.Name = "rdWell";
            this.rdWell.Size = new System.Drawing.Size(103, 21);
            this.rdWell.TabIndex = 0;
            this.rdWell.Text = "Well wishes";
            this.rdWell.UseVisualStyleBackColor = true;
            this.rdWell.CheckedChanged += new System.EventHandler(this.rdQuestion_CheckedChanged);
            // 
            // rdUnspec
            // 
            this.rdUnspec.AutoSize = true;
            this.rdUnspec.Location = new System.Drawing.Point(666, 28);
            this.rdUnspec.Margin = new System.Windows.Forms.Padding(1);
            this.rdUnspec.Name = "rdUnspec";
            this.rdUnspec.Size = new System.Drawing.Size(104, 21);
            this.rdUnspec.TabIndex = 0;
            this.rdUnspec.Text = "Unspecified";
            this.rdUnspec.UseVisualStyleBackColor = true;
            this.rdUnspec.CheckedChanged += new System.EventHandler(this.rdQuestion_CheckedChanged);
            // 
            // rdConReq
            // 
            this.rdConReq.AutoSize = true;
            this.rdConReq.Location = new System.Drawing.Point(229, 126);
            this.rdConReq.Margin = new System.Windows.Forms.Padding(1);
            this.rdConReq.Name = "rdConReq";
            this.rdConReq.Size = new System.Drawing.Size(135, 21);
            this.rdConReq.TabIndex = 0;
            this.rdConReq.Text = "Contact Request";
            this.rdConReq.UseVisualStyleBackColor = true;
            this.rdConReq.CheckedChanged += new System.EventHandler(this.rdQuestion_CheckedChanged);
            // 
            // rdAsk
            // 
            this.rdAsk.AutoSize = true;
            this.rdAsk.Location = new System.Drawing.Point(527, 28);
            this.rdAsk.Margin = new System.Windows.Forms.Padding(1);
            this.rdAsk.Name = "rdAsk";
            this.rdAsk.Size = new System.Drawing.Size(128, 21);
            this.rdAsk.TabIndex = 0;
            this.rdAsk.Text = "Rating Request";
            this.rdAsk.UseVisualStyleBackColor = true;
            this.rdAsk.CheckedChanged += new System.EventHandler(this.rdQuestion_CheckedChanged);
            // 
            // rdSol
            // 
            this.rdSol.AutoSize = true;
            this.rdSol.Location = new System.Drawing.Point(491, 83);
            this.rdSol.Margin = new System.Windows.Forms.Padding(1);
            this.rdSol.Name = "rdSol";
            this.rdSol.Size = new System.Drawing.Size(91, 21);
            this.rdSol.TabIndex = 0;
            this.rdSol.Text = "Guidance";
            this.rdSol.UseVisualStyleBackColor = true;
            this.rdSol.CheckedChanged += new System.EventHandler(this.rdQuestion_CheckedChanged);
            // 
            // rdRecReq
            // 
            this.rdRecReq.AutoSize = true;
            this.rdRecReq.Location = new System.Drawing.Point(20, 83);
            this.rdRecReq.Margin = new System.Windows.Forms.Padding(1);
            this.rdRecReq.Name = "rdRecReq";
            this.rdRecReq.Size = new System.Drawing.Size(197, 21);
            this.rdRecReq.TabIndex = 0;
            this.rdRecReq.Text = "Recommendation Request";
            this.rdRecReq.UseVisualStyleBackColor = true;
            this.rdRecReq.CheckedChanged += new System.EventHandler(this.rdQuestion_CheckedChanged);
            // 
            // rdApol
            // 
            this.rdApol.AutoSize = true;
            this.rdApol.Location = new System.Drawing.Point(382, 83);
            this.rdApol.Margin = new System.Windows.Forms.Padding(1);
            this.rdApol.Name = "rdApol";
            this.rdApol.Size = new System.Drawing.Size(81, 21);
            this.rdApol.TabIndex = 0;
            this.rdApol.Text = "Apology";
            this.rdApol.UseVisualStyleBackColor = true;
            this.rdApol.CheckedChanged += new System.EventHandler(this.rdQuestion_CheckedChanged);
            // 
            // rdSuggReq
            // 
            this.rdSuggReq.AutoSize = true;
            this.rdSuggReq.Location = new System.Drawing.Point(354, 28);
            this.rdSuggReq.Margin = new System.Windows.Forms.Padding(1);
            this.rdSuggReq.Name = "rdSuggReq";
            this.rdSuggReq.Size = new System.Drawing.Size(158, 21);
            this.rdSuggReq.TabIndex = 0;
            this.rdSuggReq.Text = "Suggestion Request";
            this.rdSuggReq.UseVisualStyleBackColor = true;
            this.rdSuggReq.CheckedChanged += new System.EventHandler(this.rdQuestion_CheckedChanged);
            // 
            // sent
            // 
            this.sent.Controls.Add(this.rdSuggReq);
            this.sent.Controls.Add(this.rdUpdReq);
            this.sent.Controls.Add(this.rdApol);
            this.sent.Controls.Add(this.rdRecReq);
            this.sent.Controls.Add(this.rdAppInfo);
            this.sent.Controls.Add(this.rdSol);
            this.sent.Controls.Add(this.rdAsk);
            this.sent.Controls.Add(this.rdUserEng);
            this.sent.Controls.Add(this.rdCurrRel);
            this.sent.Controls.Add(this.rdConReq);
            this.sent.Controls.Add(this.rdUnspec);
            this.sent.Controls.Add(this.rdWell);
            this.sent.Controls.Add(this.rdCommit);
            this.sent.Controls.Add(this.rdApprec);
            this.sent.Controls.Add(this.rdGreet);
            this.sent.Location = new System.Drawing.Point(12, 386);
            this.sent.Margin = new System.Windows.Forms.Padding(1);
            this.sent.Name = "sent";
            this.sent.Padding = new System.Windows.Forms.Padding(1);
            this.sent.Size = new System.Drawing.Size(792, 159);
            this.sent.TabIndex = 4;
            this.sent.TabStop = false;
            this.sent.Text = "Sentiment";
            this.sent.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdUpdReq
            // 
            this.rdUpdReq.AutoSize = true;
            this.rdUpdReq.Location = new System.Drawing.Point(19, 126);
            this.rdUpdReq.Margin = new System.Windows.Forms.Padding(1);
            this.rdUpdReq.Name = "rdUpdReq";
            this.rdUpdReq.Size = new System.Drawing.Size(182, 21);
            this.rdUpdReq.TabIndex = 0;
            this.rdUpdReq.Text = "Update Review Request";
            this.rdUpdReq.UseVisualStyleBackColor = true;
            this.rdUpdReq.CheckedChanged += new System.EventHandler(this.rdQuestion_CheckedChanged);
            // 
            // rdAppInfo
            // 
            this.rdAppInfo.AutoSize = true;
            this.rdAppInfo.Location = new System.Drawing.Point(588, 83);
            this.rdAppInfo.Margin = new System.Windows.Forms.Padding(1);
            this.rdAppInfo.Name = "rdAppInfo";
            this.rdAppInfo.Size = new System.Drawing.Size(129, 21);
            this.rdAppInfo.TabIndex = 0;
            this.rdAppInfo.Text = "App Information";
            this.rdAppInfo.UseVisualStyleBackColor = true;
            this.rdAppInfo.CheckedChanged += new System.EventHandler(this.rdQuestion_CheckedChanged);
            // 
            // rdCurrRel
            // 
            this.rdCurrRel.AutoSize = true;
            this.rdCurrRel.Location = new System.Drawing.Point(382, 126);
            this.rdCurrRel.Margin = new System.Windows.Forms.Padding(1);
            this.rdCurrRel.Name = "rdCurrRel";
            this.rdCurrRel.Size = new System.Drawing.Size(154, 21);
            this.rdCurrRel.TabIndex = 0;
            this.rdCurrRel.Text = "Current Release Fix";
            this.rdCurrRel.UseVisualStyleBackColor = true;
            this.rdCurrRel.CheckedChanged += new System.EventHandler(this.rdQuestion_CheckedChanged);
            // 
            // rdUserEng
            // 
            this.rdUserEng.AutoSize = true;
            this.rdUserEng.Location = new System.Drawing.Point(566, 126);
            this.rdUserEng.Margin = new System.Windows.Forms.Padding(1);
            this.rdUserEng.Name = "rdUserEng";
            this.rdUserEng.Size = new System.Drawing.Size(144, 21);
            this.rdUserEng.TabIndex = 0;
            this.rdUserEng.Text = "User Engagement";
            this.rdUserEng.UseVisualStyleBackColor = true;
            this.rdUserEng.CheckedChanged += new System.EventHandler(this.rdQuestion_CheckedChanged);
            // 
            // frmDSGenerator
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 771);
            this.Controls.Add(this.chkImportant);
            this.Controls.Add(this.chLast);
            this.Controls.Add(this.txtMainComment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.sent);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtfPath);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "frmDSGenerator";
            this.Text = "Sentiment Loader";
            this.Load += new System.EventHandler(this.frmDSGenerator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb1)).EndInit();
            this.sent.ResumeLayout(false);
            this.sent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtfPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox lblComment;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox txtMainComment;
        private System.Windows.Forms.CheckBox chLast;
        private System.Windows.Forms.CheckBox chkImportant;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tval3;
        private System.Windows.Forms.TextBox tval2;
        private System.Windows.Forms.TextBox tval1;
        private System.Windows.Forms.TrackBar tb3;
        private System.Windows.Forms.TrackBar tb2;
        private System.Windows.Forms.TrackBar tb1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.CheckBox rdGreet;
        private System.Windows.Forms.CheckBox rdApprec;
        private System.Windows.Forms.CheckBox rdCommit;
        private System.Windows.Forms.CheckBox rdWell;
        private System.Windows.Forms.CheckBox rdUnspec;
        private System.Windows.Forms.CheckBox rdConReq;
        private System.Windows.Forms.CheckBox rdAsk;
        private System.Windows.Forms.CheckBox rdSol;
        private System.Windows.Forms.CheckBox rdRecReq;
        private System.Windows.Forms.CheckBox rdApol;
        private System.Windows.Forms.CheckBox rdSuggReq;
        private System.Windows.Forms.GroupBox sent;
        private System.Windows.Forms.CheckBox rdAppInfo;
        private System.Windows.Forms.CheckBox rdUpdReq;
        private System.Windows.Forms.CheckBox rdUserEng;
        private System.Windows.Forms.CheckBox rdCurrRel;
    }
}

