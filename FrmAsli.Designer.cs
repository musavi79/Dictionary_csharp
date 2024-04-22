namespace Farhang_Loqat
{
    partial class FrmAsli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsli));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnKhorooj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cSDicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wordsDataSet = new Farhang_Loqat.WordsDataSet();
            this.txtResultt = new System.Windows.Forms.TextBox();
            this.englishPersianWordDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dictionaryDataSet = new Farhang_Loqat.DictionaryDataSet();
            this.txtSearchh = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDarj = new System.Windows.Forms.Button();
            this.btnJoostejo = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cSDicTableAdapter = new Farhang_Loqat.WordsDataSetTableAdapters.CSDicTableAdapter();
            this.englishPersianWordDatabaseTableAdapter = new Farhang_Loqat.DictionaryDataSetTableAdapters.EnglishPersianWordDatabaseTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cSDicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishPersianWordDatabaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 641);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.btnKhorooj);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.txtResultt);
            this.tabPage1.Controls.Add(this.txtSearchh);
            this.tabPage1.Controls.Add(this.txtResult);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(944, 591);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "مترجم لغات";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("A Thuluth", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(5, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "=";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // btnKhorooj
            // 
            this.btnKhorooj.Font = new System.Drawing.Font("A Thuluth", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnKhorooj.Image = ((System.Drawing.Image)(resources.GetObject("btnKhorooj.Image")));
            this.btnKhorooj.Location = new System.Drawing.Point(50, 5);
            this.btnKhorooj.Name = "btnKhorooj";
            this.btnKhorooj.Size = new System.Drawing.Size(36, 41);
            this.btnKhorooj.TabIndex = 8;
            this.btnKhorooj.Text = "×";
            this.btnKhorooj.UseVisualStyleBackColor = true;
            this.btnKhorooj.Click += new System.EventHandler(this.btnKhorooj_Click);
            this.btnKhorooj.MouseHover += new System.EventHandler(this.btnKhorooj_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("A Thuluth", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(392, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "فارسی به انگلیسی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("A Thuluth", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(392, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "انگلیسی به فارسی";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listBox1.DataSource = this.cSDicBindingSource;
            this.listBox1.DisplayMember = "english";
            this.listBox1.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(9, 183);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(927, 144);
            this.listBox1.TabIndex = 5;
            // 
            // cSDicBindingSource
            // 
            this.cSDicBindingSource.DataMember = "CSDic";
            this.cSDicBindingSource.DataSource = this.wordsDataSet;
            // 
            // wordsDataSet
            // 
            this.wordsDataSet.DataSetName = "WordsDataSet";
            this.wordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtResultt
            // 
            this.txtResultt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtResultt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.englishPersianWordDatabaseBindingSource, "EnglishWord", true));
            this.txtResultt.Location = new System.Drawing.Point(8, 125);
            this.txtResultt.Multiline = true;
            this.txtResultt.Name = "txtResultt";
            this.txtResultt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtResultt.Size = new System.Drawing.Size(378, 37);
            this.txtResultt.TabIndex = 4;
            this.txtResultt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // englishPersianWordDatabaseBindingSource
            // 
            this.englishPersianWordDatabaseBindingSource.DataMember = "EnglishPersianWordDatabase";
            this.englishPersianWordDatabaseBindingSource.DataSource = this.dictionaryDataSet;
            // 
            // dictionaryDataSet
            // 
            this.dictionaryDataSet.DataSetName = "DictionaryDataSet";
            this.dictionaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSearchh
            // 
            this.txtSearchh.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtSearchh.Location = new System.Drawing.Point(558, 125);
            this.txtSearchh.Multiline = true;
            this.txtSearchh.Name = "txtSearchh";
            this.txtSearchh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchh.Size = new System.Drawing.Size(378, 37);
            this.txtSearchh.TabIndex = 3;
            this.txtSearchh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearchh.TextChanged += new System.EventHandler(this.txtSearchh_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtResult.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cSDicBindingSource, "farsi", true));
            this.txtResult.Location = new System.Drawing.Point(8, 60);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtResult.Size = new System.Drawing.Size(378, 37);
            this.txtResult.TabIndex = 2;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtSearch.Location = new System.Drawing.Point(558, 60);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(378, 37);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.btnDarj);
            this.tabPage2.Controls.Add(this.btnJoostejo);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(944, 591);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "مترجم تصویری";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.richTextBox2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.richTextBox2.Location = new System.Drawing.Point(226, 186);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(476, 118);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.richTextBox1.Location = new System.Drawing.Point(226, 115);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(476, 54);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(454, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 56);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnDarj
            // 
            this.btnDarj.Font = new System.Drawing.Font("A Thuluth", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDarj.Image = ((System.Drawing.Image)(resources.GetObject("btnDarj.Image")));
            this.btnDarj.Location = new System.Drawing.Point(226, 52);
            this.btnDarj.Name = "btnDarj";
            this.btnDarj.Size = new System.Drawing.Size(222, 56);
            this.btnDarj.TabIndex = 3;
            this.btnDarj.Text = "درج تصویر";
            this.btnDarj.UseVisualStyleBackColor = true;
            this.btnDarj.Click += new System.EventHandler(this.btnDarj_Click);
            // 
            // btnJoostejo
            // 
            this.btnJoostejo.Font = new System.Drawing.Font("A Thuluth", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnJoostejo.Image = ((System.Drawing.Image)(resources.GetObject("btnJoostejo.Image")));
            this.btnJoostejo.Location = new System.Drawing.Point(480, 52);
            this.btnJoostejo.Name = "btnJoostejo";
            this.btnJoostejo.Size = new System.Drawing.Size(222, 56);
            this.btnJoostejo.TabIndex = 1;
            this.btnJoostejo.Text = "جستجو";
            this.btnJoostejo.UseVisualStyleBackColor = true;
            this.btnJoostejo.Click += new System.EventHandler(this.btnJoostejo_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Controls.Add(this.textBox10);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.textBox8);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 46);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(944, 591);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "لغات روز";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox9.Location = new System.Drawing.Point(389, 542);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox9.Size = new System.Drawing.Size(206, 41);
            this.textBox9.TabIndex = 12;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox10.Location = new System.Drawing.Point(310, 490);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox10.Size = new System.Drawing.Size(356, 37);
            this.textBox10.TabIndex = 11;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox7.Location = new System.Drawing.Point(98, 145);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox7.Size = new System.Drawing.Size(167, 37);
            this.textBox7.TabIndex = 10;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox8.Location = new System.Drawing.Point(63, 89);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox8.Size = new System.Drawing.Size(167, 37);
            this.textBox8.TabIndex = 9;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox5.Location = new System.Drawing.Point(281, 430);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox5.Size = new System.Drawing.Size(167, 37);
            this.textBox5.TabIndex = 8;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox6.Location = new System.Drawing.Point(246, 374);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox6.Size = new System.Drawing.Size(167, 37);
            this.textBox6.TabIndex = 7;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox3.Location = new System.Drawing.Point(526, 430);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox3.Size = new System.Drawing.Size(167, 37);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox4.Location = new System.Drawing.Point(556, 374);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox4.Size = new System.Drawing.Size(167, 37);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox2.Location = new System.Drawing.Point(698, 145);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(167, 37);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox1.Location = new System.Drawing.Point(728, 89);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(167, 37);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("A Thuluth", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(295, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(371, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "جهت نمایش لغات کلیک بفرمایید";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cSDicTableAdapter
            // 
            this.cSDicTableAdapter.ClearBeforeFill = true;
            // 
            // englishPersianWordDatabaseTableAdapter
            // 
            this.englishPersianWordDatabaseTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAsli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(952, 641);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("A Thuluth", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmAsli";
            this.Text = "فرهنگ لغت شکری";
            this.Load += new System.EventHandler(this.FrmAsli_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cSDicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.englishPersianWordDatabaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dictionaryDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.Button btnJoostejo;
        public System.Windows.Forms.Button btnDarj;
        private WordsDataSet wordsDataSet;
        private System.Windows.Forms.BindingSource cSDicBindingSource;
        private WordsDataSetTableAdapters.CSDicTableAdapter cSDicTableAdapter;
        private DictionaryDataSet dictionaryDataSet;
        private System.Windows.Forms.BindingSource englishPersianWordDatabaseBindingSource;
        private DictionaryDataSetTableAdapters.EnglishPersianWordDatabaseTableAdapter englishPersianWordDatabaseTableAdapter;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtResultt;
        private System.Windows.Forms.TextBox txtSearchh;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnKhorooj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}