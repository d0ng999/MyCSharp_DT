using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap09_StringManage_Test : Form
    {
        public Chap09_StringManage_Test()
        {
            InitializeComponent();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            lblText.Text = lblText.Text.Replace("OOO", "홍동현");
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            MessageBox.Show("인덱스 값은 " + lblText.Text.IndexOf("S/W"));
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            string sTitle = lblText.Text;
            MessageBox.Show($"첫 번째 단어는 {sTitle[0]}이고, 마지막 단어는 {sTitle[sTitle.Length - 1]}");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sTitle = lblText.Text;
            sTitle = sTitle.Insert(0, "-DT-");
            sTitle = sTitle.Insert(sTitle.Length-1, "-DT-");
            lblText.Text = sTitle;
            MessageBox.Show(lblText.Text);
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            string sTitle = lblText.Text;
            string sSub = sTitle.Substring(Convert.ToInt32(sTitle.IndexOf("DIGI")), 14).ToLower();
            string sValue = sTitle.Replace("DIGITALTRANING", sSub);
            lblText.Text = sValue;
            MessageBox.Show(lblText.Text);
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            string sTitle = lblText.Text;
            string sValue = sTitle.Replace(" ", "");
            lblText.Text = sValue;
            MessageBox.Show(lblText.Text); 
        }
    }
}
