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
    public partial class Chap20_MiddleTest_03 : Form
    {
        int[] iValues = new int[3];
        int iCnt = 0;
        public Chap20_MiddleTest_03()
        {
            InitializeComponent();
        }

        private void btnMakeRandom_Click(object sender, EventArgs e)
        {
            ++iCnt;
            Random rNumber = new Random();
            if (iCnt % 3 == 1)
            {
                iValues[0] = rNumber.Next(0, 100);
                txtNum1.Text = iValues[0].ToString();
            }
            else if(iCnt % 3 == 2)
            {
                iValues[1] = rNumber.Next(0, 100);
                txtNum2.Text = iValues[1].ToString();
            }
            else if(iCnt % 3 == 0)
            {
                iValues[2] = rNumber.Next(0, 100);
                txtNum3.Text = iValues[2].ToString();
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int iValue1 = Convert.ToInt32(txtNum1.Text);
            int iValue2 = Convert.ToInt32(txtNum2.Text);
            int iValue3 = Convert.ToInt32(txtNum3.Text);
            int iSum = iValue1 + iValue2 + iValue3;
            if (iSum < 100)
            {
                MessageBox.Show($"최댓값: {iValues.Max()}, 최솟값: {iValues.Min()}");
            }
            else if ((iSum >= 100) && (iSum < 200))
            {
                MessageBox.Show($"최솟값과 최댓값의 합: {iValues.Max() + iValues.Min()}");
            }
            else if(iSum >= 200)
            {
                MessageBox.Show("세 수의 합이 200이 넘습니다.");
            }
        }
    }
}
