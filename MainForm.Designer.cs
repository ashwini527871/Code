namespace TextFileAnalysis
{
    partial class MainForm
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
            this.dlg_SelectFile = new System.Windows.Forms.OpenFileDialog();
            this.btn_ChooseFile = new System.Windows.Forms.Button();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.txt_Word = new System.Windows.Forms.TextBox();
            this.lbl_Text = new System.Windows.Forms.Label();
            this.lbl_File = new System.Windows.Forms.Label();
            this.btn_Analyze = new System.Windows.Forms.Button();
            this.lbl_SearchedCount = new System.Windows.Forms.Label();
            this.lbl_TotalWords = new System.Windows.Forms.Label();
            this.lbl_Percent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dlg_SelectFile
            // 
            this.dlg_SelectFile.Filter = "Text Files|*.txt";
           
            // 
            // btn_ChooseFile
            // 
            this.btn_ChooseFile.Location = new System.Drawing.Point(572, 40);
            this.btn_ChooseFile.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ChooseFile.Name = "btn_ChooseFile";
            this.btn_ChooseFile.Size = new System.Drawing.Size(94, 28);
            this.btn_ChooseFile.TabIndex = 0;
            this.btn_ChooseFile.Text = "Choose File";
            this.btn_ChooseFile.UseVisualStyleBackColor = true;
            this.btn_ChooseFile.Click += new System.EventHandler(this.btn_ChooseFile_Click);
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Location = new System.Drawing.Point(358, 43);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.Size = new System.Drawing.Size(179, 23);
            this.txt_FilePath.TabIndex = 1;
            // 
            // txt_Word
            // 
            this.txt_Word.Location = new System.Drawing.Point(358, 85);
            this.txt_Word.Name = "txt_Word";
            this.txt_Word.Size = new System.Drawing.Size(179, 23);
            this.txt_Word.TabIndex = 2;
            // 
            // lbl_Text
            // 
            this.lbl_Text.AutoSize = true;
            this.lbl_Text.Location = new System.Drawing.Point(191, 88);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(161, 17);
            this.lbl_Text.TabIndex = 3;
            this.lbl_Text.Text = "Enter the text to analyze";
            // 
            // lbl_File
            // 
            this.lbl_File.AutoSize = true;
            this.lbl_File.Location = new System.Drawing.Point(191, 49);
            this.lbl_File.Name = "lbl_File";
            this.lbl_File.Size = new System.Drawing.Size(117, 17);
            this.lbl_File.TabIndex = 4;
            this.lbl_File.Text = "Selected file path";
            // 
            // btn_Analyze
            // 
            this.btn_Analyze.Location = new System.Drawing.Point(572, 82);
            this.btn_Analyze.Name = "btn_Analyze";
            this.btn_Analyze.Size = new System.Drawing.Size(94, 28);
            this.btn_Analyze.TabIndex = 5;
            this.btn_Analyze.Text = "Analyze";
            this.btn_Analyze.UseVisualStyleBackColor = true;
            this.btn_Analyze.Click += new System.EventHandler(this.btn_Analyze_Click);
            // 
            // lbl_SearchedCount
            // 
            this.lbl_SearchedCount.AutoSize = true;
            this.lbl_SearchedCount.Location = new System.Drawing.Point(212, 175);
            this.lbl_SearchedCount.Name = "lbl_SearchedCount";
            this.lbl_SearchedCount.Size = new System.Drawing.Size(0, 17);
            this.lbl_SearchedCount.TabIndex = 6;
            // 
            // lbl_TotalWords
            // 
            this.lbl_TotalWords.AutoSize = true;
            this.lbl_TotalWords.Location = new System.Drawing.Point(212, 201);
            this.lbl_TotalWords.Name = "lbl_TotalWords";
            this.lbl_TotalWords.Size = new System.Drawing.Size(0, 17);
            this.lbl_TotalWords.TabIndex = 7;
            // 
            // lbl_Percent
            // 
            this.lbl_Percent.AutoSize = true;
            this.lbl_Percent.Location = new System.Drawing.Point(212, 227);
            this.lbl_Percent.Name = "lbl_Percent";
            this.lbl_Percent.Size = new System.Drawing.Size(0, 17);
            this.lbl_Percent.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 401);
            this.Controls.Add(this.lbl_Percent);
            this.Controls.Add(this.lbl_TotalWords);
            this.Controls.Add(this.lbl_SearchedCount);
            this.Controls.Add(this.btn_Analyze);
            this.Controls.Add(this.lbl_File);
            this.Controls.Add(this.lbl_Text);
            this.Controls.Add(this.txt_Word);
            this.Controls.Add(this.txt_FilePath);
            this.Controls.Add(this.btn_ChooseFile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlg_SelectFile;
        private System.Windows.Forms.Button btn_ChooseFile;
        private System.Windows.Forms.TextBox txt_FilePath;
        private System.Windows.Forms.TextBox txt_Word;
        private System.Windows.Forms.Label lbl_Text;
        private System.Windows.Forms.Label lbl_File;
        private System.Windows.Forms.Button btn_Analyze;
        private System.Windows.Forms.Label lbl_SearchedCount;
        private System.Windows.Forms.Label lbl_TotalWords;
        private System.Windows.Forms.Label lbl_Percent;
    }
}