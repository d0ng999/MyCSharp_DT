using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace MyFirstCSharp
{
    public partial class Chap25_Rec : Form
    {
        public Chap25_Rec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bFlag = false;
            int iValue = 0;
            bFlag = int.TryParse(txtResult.Text, out iValue);

            if (!bFlag)
            {
                MessageBox.Show("숫자를 입력해주세요");
                return;
            }

            int iStart = 0;
            int iEnd = 1;
            int iResult = 0;

            if (iValue > 2)
            {
                for (int i = 1; i < iValue; i++)
                {
                    iStart = iEnd;
                    iEnd = iResult;
                    iResult = iStart + iEnd;
                }
                MessageBox.Show($"{iValue}번째 피보나치 값은 {iResult}");
            }
            else
            {
                MessageBox.Show($"{iValue}번째 피보나치 값은 {iValue - 1}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                // 리스트를 통한 피보나치 수열의 값 구하기
                int iLoopCount = 0;

                // 리스트의 초기 값 0과 1 등록(피보나치 수열에서 전전 값과, 전 값이 등록되어 보관될 용도)
                List<int> iValues = new List<int>() { 0, 1 };

                // out int iResult 를 생성하면서 out 값까지 받아버리기
                bool bCheck = int.TryParse(txtResult.Text, out int iTurn);

                if (!bCheck)
                {
                    return;
                }

                // 입력한 숫자 : iTurn
                if (iTurn > 2) // 입력한 차수가 3이상일 때
                {
                    // i : iValues에 등록될 index
                    for (int i = 2; i < iTurn; i++)
                    {
                        iValues.Add(iValues[i - 2] + iValues[i - 1]);
                        ++iLoopCount;
                    }
                    ++iLoopCount;
                    MessageBox.Show($"피보나치 수열 {iTurn}번째의 값은 {iValues[iValues.Count - 1]}입니다." +
                        $"총 반복횟수 : {iLoopCount}");
                }
                else
                    MessageBox.Show($"피보나치 수열 {iTurn}번째의 값은 {iValues[iTurn - 1]}입니다." +
                        $"총 반복횟수 : {iLoopCount}");

            }
        }
    }
}
