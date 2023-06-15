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
    public partial class Chap21_Collection_Test : Form
    {
        public Chap21_Collection_Test()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;

            for (int i = 0; i < sTitle.Length; i++)
            {
                int iCount = 0;

                for (int j = 0; j < sTitle.Length; j++)
                {
                    if (sTitle[i] == sTitle[j])
                    {
                        iCount++;
                    }
                }

                if (iCount == 1)
                {
                    MessageBox.Show(sTitle[i].ToString());
                    break;
                }
            }
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;

            for (int i = 0; i < sTitle.Length; i++)
            {
                int iCount = 0;

                for (int j = 0; j < sTitle.Length; j++)
                {
                    if (sTitle[i] == sTitle[j])
                    {
                        iCount++;
                    }
                }

                if (iCount == 1)
                {
                    MessageBox.Show(sTitle[i].ToString());
                    break;
                }
            }
        }

        private void btnDicForeach_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;

            Dictionary<char, int> dic = new Dictionary<char, int>();

            for (int i = 0; i < sTitle.Length; i++)
            {
                if (dic.ContainsKey(sTitle[i]))
                {
                    dic[sTitle[i]]++;
                }
                else
                {
                    dic.Add(sTitle[i], 1);
                }
            }

            foreach (char c in dic.Keys)
            {
                if (dic[c] == 1)
                {
                    MessageBox.Show(c.ToString());
                }
            }
        }
    }
}
