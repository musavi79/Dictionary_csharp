using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patagames.Ocr;
using Google.API.Translate;
using Google_API_Translate;

namespace Farhang_Loqat
{
    public partial class FrmAsli : Form
    {
        public FrmAsli()
        {
            InitializeComponent();
        }
        FrmAccept fa = new FrmAccept();
        FrmError fe = new FrmError();
        //class tool tip---ejad matn saye
        ToolTip tt = new ToolTip();
        private void FrmAsli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dictionaryDataSet.EnglishPersianWordDatabase' table. You can move, or remove it, as needed.
            this.englishPersianWordDatabaseTableAdapter.Fill(this.dictionaryDataSet.EnglishPersianWordDatabase);
            // TODO: This line of code loads data into the 'wordsDataSet.CSDic' table. You can move, or remove it, as needed.
            this.cSDicTableAdapter.Fill(this.wordsDataSet.CSDic);
            // TODO: This line of code loads data into the 'wordsDataSet.FatoEn' table. You can move, or remove it, as needed.


        }
        //english to persian
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                cSDicTableAdapter.FillByEnglish(wordsDataSet.CSDic, txtSearch.Text.Trim());
            }
            else
            {
                cSDicTableAdapter.Fill(wordsDataSet.CSDic);
            }

        }
      //persian to english
        private void txtSearchh_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchh.Text.Length > 0)
            {
              englishPersianWordDatabaseTableAdapter.FillByPersian(dictionaryDataSet.EnglishPersianWordDatabase, txtSearchh.Text.Trim());
            }
            else
            {
                englishPersianWordDatabaseTableAdapter.Fill(dictionaryDataSet.EnglishPersianWordDatabase);
            }
        }
        //display random data from database
        Random r = new Random();
        int lastSelectedIndex = -1;
        DataTable dt = new DataTable();
        void RandomRecord()
        {
            int noRows = wordsDataSet.Tables[0].Rows.Count;
            int index = r.Next(noRows);

            while (index == lastSelectedIndex && noRows > 1)
            {
                index = r.Next(noRows);
            }

            lastSelectedIndex = index;

            textBox1.Text = wordsDataSet.Tables[0].Rows[index]["english"].ToString();
            textBox2.Text = wordsDataSet.Tables[0].Rows[index]["farsi"].ToString();
            index = r.Next(noRows);
            textBox4.Text = wordsDataSet.Tables[0].Rows[index]["english"].ToString();
            textBox3.Text = wordsDataSet.Tables[0].Rows[index]["farsi"].ToString();
            index = r.Next(noRows);
            textBox10.Text = wordsDataSet.Tables[0].Rows[index]["english"].ToString();
            textBox9.Text = wordsDataSet.Tables[0].Rows[index]["farsi"].ToString();
            index = r.Next(noRows);
            textBox6.Text = wordsDataSet.Tables[0].Rows[index]["english"].ToString();
            textBox5.Text = wordsDataSet.Tables[0].Rows[index]["farsi"].ToString();
            index = r.Next(noRows);
            textBox8.Text = wordsDataSet.Tables[0].Rows[index]["english"].ToString();
            textBox7.Text = wordsDataSet.Tables[0].Rows[index]["farsi"].ToString();


        }
        //button namayesh loqat tasadofi
        private void button1_Click(object sender, EventArgs e)
        {
            RandomRecord();
        }
        //button koochak kardn safhe
        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            
        }
        //button khorooj
        private void btnKhorooj_Click(object sender, EventArgs e)
        {
            FrmClose FC = new FrmClose();
            FC.ShowDialog();
        }
        //darj aks
        OpenFileDialog op = new OpenFileDialog();
        private void btnDarj_Click(object sender, EventArgs e)
        {
              
            op.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp *.png)|*.jpg; *.jpeg; *.gif; *.bmp *.png";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(op.FileName);
                fa.ShowDialog();

            }
            else
            {
                fe.ShowDialog();
            }
            using (var oboc = OcrApi.Create())
            {
                oboc.Init(Patagames.Ocr.Enums.Languages.English);

                string pt = oboc.GetTextFromImage(op.FileName);
                richTextBox1.Text = pt;
            }
        }
        //namayesh mtn komaji
        private void btnKhorooj_MouseHover(object sender, EventArgs e)
        {
          
            tt.SetToolTip(this.btnKhorooj, "خروج از برنامه");

        }
        //matn saye komaki

        private void button2_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(this.button2, "کوچک کردن صفحه");
        }
        //tabdil aks be matn
        public void tarjome()
        {
            Language LanguageFrom = Language.English;
            Language LanguageTo = Language.Persian;

            richTextBox2.Text = Translator.Translate(richTextBox1.Text, LanguageFrom, LanguageTo);


        }
        private void btnJoostejo_Click(object sender, EventArgs e)
        {
           /* using(var oboc = OcrApi.Create())
            {
                oboc.Init(Patagames.Ocr.Enums.Languages.English);

                string pt = oboc.GetTextFromImage(op.FileName);
                txtNatije.Text = pt;
            }*/
            this.Enabled = false;
            tarjome();
            this.Enabled = true;
            
        }

        
        // string tto = "";

    }
}
