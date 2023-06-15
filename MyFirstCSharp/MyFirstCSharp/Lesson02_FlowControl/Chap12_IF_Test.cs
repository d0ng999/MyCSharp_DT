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
    public partial class Chap12_IF_Test : Form
    {
        int iCount = 0;

        public Chap12_IF_Test()
        {
            InitializeComponent();
        }

        private void btnTF_Click(object sender, EventArgs e)
        {
            int iValue = 0;
            bool bFlag = false;
            bFlag = int.TryParse(txtNum.Text, out iValue);
            ++iCount;
            txtCount.Text = Convert.ToString(iCount);

            if (bFlag)
            {
                txtMulAdd.Text = (iValue % 8 == 0) ? Convert.ToString(iValue * 8) : "";
                if ((iValue % 2 == 0) && (iValue % 5 == 0))
                {
                    MessageBox.Show("2, 5의 공배수입니다.");
                }
                else
                {
                    MessageBox.Show("2, 5의 공배수가 아닙니다.");
                }
            }
            else
            {
                return;
            }
        }
    }
}
