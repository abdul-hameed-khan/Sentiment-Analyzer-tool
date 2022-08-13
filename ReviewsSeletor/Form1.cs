using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace ReviewsSeletor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int min = int.Parse(txtMin.Text);
            int max = int.Parse(txtMax.Text);
            int selected = 0;
            StringBuilder newfile = new StringBuilder();
            string [] comments = File.ReadAllLines(txtfpath.Text);
            List<string> lst = new List<string>();
            foreach (string s in comments)
            {
                string wholecomment = s;
                string[] parts = wholecomment.Split(new char[] { ',' });
              
                if (parts.Length >= 4)
                {
                    string review = parts[4];
                    

                string[] words = review.Split(new char[] { ' ' });
                    if (words.Length >= min && words.Length <= max)
                    {
                        newfile.Append(s);
                        newfile.Append("\n");
                        selected++;
                        lst.Add(s);

                    }
                }
            }
            MessageBox.Show("Total Selected reviews : " + selected.ToString());
            string[] lines = lst.ToArray();
            File.WriteAllLines("ChosenReviews1.csv",lines);
            System.Diagnostics.Process.Start("ChosenReviews1.csv");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                txtfpath.Text = od.FileName;
            }
        }
    }
}
