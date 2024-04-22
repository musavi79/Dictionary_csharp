using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farhang_Loqat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //vorood be menu khorooj
        private void btnKhorooj_Click(object sender, EventArgs e)
        {
            FrmClose kh = new FrmClose();
            kh.ShowDialog();
            this.Close();
           
        }
       //vorood be menu asli barname
        private void btnVorood_Click(object sender, EventArgs e)
        {
            FrmAsli fasli = new FrmAsli();
            fasli.ShowDialog();
        }
    }
}
