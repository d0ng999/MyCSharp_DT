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
    public partial class Chap20_MiddleTest_06 : Form
    {
        public Chap20_MiddleTest_06()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Random rNumber = new Random();
            int iStartMoney = rNumber.Next(10000, 500001);
            int iEndMoney = iStartMoney;

            int iMinValue = rNumber.Next(100, 3001);
            int iCount = rNumber.Next(1, 21);

            for (int i = 0; i <= iCount; ++i)
            {
                iEndMoney -= iMinValue * i;
            }
            
            if (iEndMoney < 0)
            {
                MessageBox.Show($"{iStartMoney}원이 있을때 이용요금 {iMinValue}원인 놀이기구를 {iCount}번 타면 {Math.Abs(iEndMoney)}원이 모자랍니다.");
            }
            else
            {
                MessageBox.Show($"{iStartMoney}원이 있을때 이용요금 {iMinValue}원인 놀이기구를 {iCount}번 타면 {iEndMoney}원이 남습니다.");
            }
        }
    }
}
