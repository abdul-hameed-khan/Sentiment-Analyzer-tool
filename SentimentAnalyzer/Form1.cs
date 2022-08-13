using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace SentimentAnalyzer
{
    public partial class frmDSGenerator : Form
    {
        public frmDSGenerator()
        {
            InitializeComponent();
        }
        String[] comments;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                txtfPath.Text = od.FileName;
                comments = File.ReadAllLines(txtfPath.Text);
                commSave = true;
                loaded = true;
                if (chLast.Checked)
                    cid = int.Parse(File.ReadAllText("lastsaved.txt"));
                else
                    cid = 0;

            }

        }
        int cid = 0;
        string[] sentences;
        bool loaded = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (!loaded)
            {

                comments = File.ReadAllLines(txtfPath.Text);
                loaded = true;
                if (chLast.Checked)
                    cid = int.Parse(File.ReadAllText("lastsaved.txt"));
                else
                    cid = 0;

            }
            loadNextComment();
        }

        private void loadNextComment()
        {
            try
            {
                checkedFuns();
                btnSave.Text = "Save Comment";
                commSave = true;
                string wholecomment = comments[cid];
                WholeText = wholecomment;

                string[] parts = wholecomment.Split(new char[] { ','});
                lblComment.Text = parts[9] = parts[9].Replace("^", "^");
                
               sentences = lblComment.Text.Split(new char[] { '.' });
                sentenceno = 0;
                txtMainComment.Text = lblComment.Text;
               
                lblComment.Text = parts[9];
            }
            catch (Exception ex)
            {
                cid++;
               // loadNextComment();
            }
        }
        string WholeText;
        bool commSave;
        private void showSentences()
        {
            if (!commSave)
            {
                btnSave.Text = "Save Sentence";
                checkedFuns();
                if (sentenceno >= sentences.Length)
                {
                    sentenceno = 0;
                    cid++;
                    loadNextComment();

                }
                else if (sentences.Length > 1 && btnSave.Text!="Save Comment")
                {
                    lblComment.Text = sentences[sentenceno];
                    sentenceno++;
                    if (lblComment.Text.Trim().Length < 1)
                    {
                        showSentences();
                    }
                }
                else
                {
                    sentenceno = 0;
                    cid++;
                    loadNextComment();
                }
            }
        }



        int sentenceno = 0;



        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                 int multiple = 0;
                 string label = "";
                 if (rdApprec.Checked)
                 {
                     label = "Appreciation";
                     multiple++;
                 }
                 else if (rdGreet.Checked)
                 {
                     label = "Greeting";
                     multiple++;
                 }
                 else if (rdCommit.Checked)
                 {
                     label = "Commitment";
                     multiple++;
                 }
                 else if (rdSol.Checked)
                 {
                     label = "Guidance";
                     multiple++;
                 }
                else if (rdUpdReq.Checked)
                {
                    label = "Update Review Request";
                    multiple++;
                }
                else if (rdWell.Checked)
                 {
                     label = "Well Wishes";
                     multiple++;
                 }
                else if (rdUnspec.Checked)
                {
                    label = "Unspecified";
                    multiple++;
                }
                else if (rdAsk.Checked)
                {
                    label = "Rating Request";
                    multiple++;
                }
                else if (rdConReq.Checked)
                 {
                     label = "Contact Request";
                     multiple++;
                 }
                 else if (rdRecReq.Checked)
                 {
                     label = "Recommendation Request";
                     multiple++;
                 }
                 else if (rdApol.Checked)
                 {
                     label = "Apology";
                     multiple++;
                 }
                else if (rdAppInfo.Checked)
                {
                    label = "App Information";
                    multiple++;
                }
                else if (rdSuggReq.Checked)
                {
                    label = "Suggestion Request";
                    multiple++;
                }
                else if (rdCurrRel.Checked)
                {
                    label = "Current Release Fix";
                    multiple++;
                }
                else if (rdUserEng.Checked)
                {
                    label = "User Engagement";
                    multiple++;
                }

                //else if (rdOther.Checked)
                // {
                //     label = txtOther.Text;
                //     multiple++;
                // }
                if (lblComment.Text.Contains("!@"))
                 {
                     lblComment.Text = lblComment.Text.Replace("!@", "");
                 }
                 string str = lblComment.Text + "!@" + label;
                 //if (rdGreet.Checked || rdApprec.Checked)
                 //{
                 //    str += "!@" + txtOther.Text;
                 //}
                 if (commSave)
                 {
                     str += "!@comment";
                     //commSave = false;
                 }
                 if (multiple > 1)
                 {
                     str += "!@comment" + multiple.ToString();
                 }


                bool senti = false;

                //if (rdOther.Checked)
                //{
                //    TextandSentiment += "^^^^" + txtOther.Text;
                //}
                //if (rdGreet.Checked)
                //{
                //    TextandSentiment += "||@||Greeting";
                //    senti = true;
                //}
                //if (rdApprec.Checked)
                //{
                //    TextandSentiment += "||@||Appreciation";
                //    senti = true;
                //}
                //if (rdCustomer.Checked)
                //{
                //    TextandSentiment += "||@||Customer Support";
                //    senti = true;
                //}
                //if (tExtent.Visible)
                //{
                //    TextandSentiment += "####" + txtExtent.Text;
                //}
                if (checkedList.Count < 1 && senti==false)
                     return;
                //string str;
                if (chkImportant.Checked)
                {
                     str = WholeText + "#$#$#$#$#$" + lblComment.Text + "!!@!!" + TextandSentiment+"\n";
                    File.AppendAllText("ResearchImportant.txt", str);
                    chkImportant.Checked = false;
                }
                //if (chkRoman.Checked)
                //{
                //     str = WholeText + "#$#$#$#$#$" + lblComment.Text + "!!@!!" + TextandSentiment + "\n";
                //    File.AppendAllText("Roman.txt", str);
                //    chkRoman.Checked = false;
                //}
              

                TextandSentiment += "\n";
                if (commSave)
                {
                    
                    commSave = false;
                   str = WholeText.Replace("^", "^") + TextandSentiment;
                    
                    File.AppendAllText("CommentsDS.csv", str);
                    File.WriteAllText("lastsaved.txt", cid.ToString());
                }
                else
                {
                     str = lblComment.Text+ TextandSentiment;
                    File.AppendAllText("SentencesDS.csv", str);
                    
                }
                clearchecks();
               //For comments Only
               // sentenceno = 0;
               // cid++;
               // loadNextComment();
                //////For sentences 
                showSentences();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void clearchecks()
        {
            foreach (Control c in sent.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked)
                    {

                        cb.Checked = false;
                    }

                }
            }

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            clearchecks();
            sentenceno = 0;
            cid++;
            loadNextComment();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSentences();
        }

        private void tb1_Scroll(object sender, EventArgs e)
        {
            try
            {
                tval1.Text = tb1.Value.ToString();
                if (totalchecked == 2)
                {
                    tb2.Value = 100 - tb1.Value;
                }
                if (totalchecked > 2)
                {
                    tb2.Value = ((100 - tb1.Value) / 2);
                    tb3.Value = ((100 - tb1.Value) / 2);
                }
                clearSliders();

            }
            catch { }
        }
        int totalchecked = 0;
        int checkedOptions = 0;
        List<string> checkedList = new List<string>();
        private void rdQuestion_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                CheckBox ch = (CheckBox)sender;
               // MessageBox.Show(ch.Text + ", " +ch.Name);
                //if ((ch.Text == "Greeting" || ch.Text == "Appreciation" || ch.Text=="Customer Support"))
                //{
                //    if (ch.Checked)
                //    {
                //        lblExtent.Text = ch.Text;
                //        lblExtent.Visible = tExtent.Visible = txtExtent.Visible = true;
                //    }

                //    else
                //    {
                //        lblExtent.Visible = tExtent.Visible = txtExtent.Visible = false;
                //    }

                //    return;
                //}
                
                if (ch.Checked == true)
                {
                    checkedList.Add(ch.Text);
                    totalchecked++;
                    if (totalchecked==2)
                    {
                        tb2.Value = 100 - tb1.Value;
                    }
                    if (totalchecked > 2)
                    {
                        tb3.Value = 100 - tb1.Value - tb2.Value;
                    }
                    clearSliders();

                }
                else
                {
                   
                    checkedList.Remove(ch.Text);
                    totalchecked--;
                    /*if (totalchecked == 2)
                    {
                        tb2.Value = 100 - tb1.Value;
                    }
                    else if (totalchecked > 2)
                    {
                        tb3.Value = 100 - tb1.Value - tb2.Value;
                    }
                    else if (totalchecked==1) 
                    {
                        tb1.Value = 100;
                    }*/
                    clearSliders();

                }
            }
        }
        string TextandSentiment;

        private void checkedFuns()
        {
            checkedOptions = 0;
            checkedList.Clear();
            totalchecked = 0;
            TextandSentiment = "";
        }
        private void clearSliders()
        {
        //    try
            {
              
                
                if (totalchecked > 1)
                {
                    lbl1.Text = checkedList[0];
                    lbl2.Text = checkedList[1];
                    
                    TextandSentiment = "!!@!!" + lbl1.Text+ "$$@$$" + tval1.Text;
                    TextandSentiment+= "!!@!!" + lbl2.Text+ "$$@$$" + tval2.Text;
                    lbl1.Visible = tb1.Visible = tval1.Visible = true;
                    lbl2.Visible = tb2.Visible = tval2.Visible = true;
                    if (totalchecked > 2)
                    {
                        lbl3.Visible = tb3.Visible = tval3.Visible = true;
                        lbl3.Text = checkedList[2];
                        TextandSentiment = "!!@!!" + checkedList[0];
                        TextandSentiment = "!!@!!" + lbl1.Text + "$$@$$" + tval1.Text;
                        TextandSentiment += "!!@!!" + lbl2.Text + "$$@$$" + tval2.Text;
                        TextandSentiment += "!!@!!" + lbl3.Text + "$$@$$" + tval3.Text;

                        for (int i = 3; i < checkedList.Count; i++)
                        {
                            TextandSentiment += "!!@!!" + checkedList[i];
                        }
                        //TextandSentiment += "$$@$$" + tval1.Text + "$$@$$" + tval2.Text + "$$@$$" + tval3.Text;

                    }

                    else
                    {
                        lbl3.Visible = tb3.Visible = tval3.Visible = false;
                        
                    }
                }
                else
                {
                    lbl1.Visible = tb1.Visible = tval1.Visible = false;
                    lbl2.Visible = tb2.Visible = tval2.Visible = false;
                    if (checkedList.Count > 0)
                        TextandSentiment = "!!@!!" + checkedList[0] + "$$@$$100";


                }

            }
            /*catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }*/
        }

        private void tb2_Scroll(object sender, EventArgs e)
        {
            try
            {
                tval2.Text = tb2.Value.ToString();
                if (totalchecked == 2)
                {
                   
                    tb1.Value = 100 - tb2.Value;

                }
                if (totalchecked > 2)
                {
                    int t3v = ((100 - tb1.Value) - tb2.Value);
                    if (t3v < 0)
                        t3v = 0;
                    tb3.Value = t3v;
                    int t = tb1.Value + tb2.Value + tb3.Value;
                    if (t > 100)
                    {
                        tb2.Value = 100 - tb1.Value - tb3.Value;
                        tval2.Text = tb2.Value.ToString();
                        return;
                    }
                }
                clearSliders();
            }
            catch { }
        }

        private void tb3_Scroll(object sender, EventArgs e)
        {
            try
            {
                tval3.Text = tb3.Value.ToString();
                

                    if (totalchecked > 2)
                    {

                        int t2v = ((100 - tb1.Value) - tb3.Value);
                        if (t2v < 0)
                            t2v = 0;
                        tb2.Value = t2v;
                        int t = tb1.Value + tb2.Value + tb3.Value;
                        if (t > 100)
                        {
                            tb3.Value = 100 - tb1.Value - tb2.Value;
                            tval3.Text = tb3.Value.ToString();
                            return;
                        }
                    }
                clearSliders();
            }
          
            catch { }
        }

        //private void tbe_Scroll(object sender, EventArgs e)
        //{
        //    txtExtent.Text = tExtent.Value.ToString();
        //}

        private void frmDSGenerator_Load(object sender, EventArgs e)
        {
            if (File.Exists("lastsaved.txt"))
            {
                if (chLast.Checked)
                    cid = int.Parse(File.ReadAllText("lastsaved.txt"));
                else
                    cid = 0;
            }
        }

        private void tb1_ValueChanged(object sender, EventArgs e)
        {
            tval1.Text = tb1.Value.ToString();
        }

        private void tb2_ValueChanged(object sender, EventArgs e)
        {
            tval2.Text = tb2.Value.ToString();
        }

        private void tb3_ValueChanged(object sender, EventArgs e)
        {
            tval3.Text = tb3.Value.ToString();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkImportant_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtfPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblComment_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
    }
