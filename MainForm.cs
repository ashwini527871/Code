using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileAnalysis
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_ChooseFile_Click(object sender, EventArgs e)
        {
            try
            {
                dlg_SelectFile.ShowDialog();
                txt_FilePath.Text = dlg_SelectFile.FileName;
                txt_FilePath.ReadOnly = true;
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_Analyze_Click(object sender, EventArgs e)
        {
            if (txt_FilePath.Text == "" || txt_Word.Text == "")
            {
                MessageBox.Show("Please select a text file and enter a word to check", "Alert", 
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            ReadFile readFile = new ReadFile();
            string filetext = readFile.GetFileText(txt_FilePath.Text);

            string[] wordsinfile;
            int count = readFile.CountWord(filetext, txt_Word.Text, out wordsinfile);
            int totalwords = wordsinfile.Count();
            float percent = count * 100 / totalwords;

            lbl_SearchedCount.Text = string.Format("Number of occurance of given word '{0}' is {1} ", txt_Word.Text, count);
            lbl_TotalWords.Text = string.Format("Total words in file : {0}", totalwords);
            lbl_Percent.Text = string.Format("Percentage of searched word: {0}", percent);
        }

        
    }
}
