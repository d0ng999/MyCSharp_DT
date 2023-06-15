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
    public partial class Chap16_Loop_For_Test : Form
    {
        public Chap16_Loop_For_Test()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int iStart = 0;
            int iEnd = 0;
            int iEvenResult = 0;
            int iOddResult = 0;
            bool bStart = false;
            bool bEnd = false;
            bStart = int.TryParse(txtStart.Text, out iStart);
            bEnd = int.TryParse(txtEnd.Text, out iEnd);
            StringBuilder sTextEven = new StringBuilder();
            StringBuilder sTextOdd = new StringBuilder();

            if (bStart && bEnd)
            {
                if (iStart >= iEnd)
                {
                    MessageBox.Show("시작 입력값이 종료 입력값보다 작습니다..");
                    return;
                }
                for (int i = iStart; i <= iEnd; i++)
                {
                    if (i == 0)
                    {
                        continue;
                    }
                    else if (i % 2 == 0)
                    {
                        sTextEven.Append(i + " ");
                        iEvenResult += i;
                    }
                    else
                    {
                        sTextOdd.Append(i + " ");
                        iOddResult += i;
                    }
                }
                txtEvenResult.Text = "짝수 : " + sTextEven.ToString();
                txtOddResult.Text = "홀수 : " + sTextOdd.ToString();
                MessageBox.Show($"짝수의 합 : {iEvenResult}, 홀수의 합 : {iOddResult}");
            }
            else
            {
                MessageBox.Show("입력 값에 숫자를 넣어주세요");
            }
        }
    }
}
