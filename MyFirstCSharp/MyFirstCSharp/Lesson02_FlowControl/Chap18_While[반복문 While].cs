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
    public partial class Chap18_While : Form
    {
        public Chap18_While()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            // 1부터 100까지의 합을 While문으로 표현

            // 결과를 담을 외부 변수
            int iResult = 0;

            // 조건 (1부터 100까지 증가시킬 변수)
            int iCount = 0;

            // 조건을 만족하는 동안 계속 반복
            // For 문법 : 종료되는 조건이 반드시 포함.
            // While 문법 : 종료 조건이 포함되지 않아도 된다.
            while (iCount < 100)
            {
                iCount++;
                if (iCount >= 20 && iCount <= 30)
                {
                    // 20부터 30까지의 값은 누적하지 않는다.
                    continue;
                }
                iResult += iCount;

                if (iResult > 1000)
                {
                    // 누적 합산의 결과 값이 1000을 초과할 경우 반복문(While) 종료
                    break;                
                }
            }
            MessageBox.Show(iResult.ToString());
        }

        private void btnWhileNoExit_Click(object sender, EventArgs e)
        {
            // 무한루프
            // 주식 매매 프로그램 또는 서버의 신호를 대기하여 받아와야 하는 프로그램
            // 의 경우, 불규칙적으로 들어오는 데이터를 항상 수신 대기해야 하므로
            // 무한루프를 구현해두고 수신을 대기하는 프로그래밍을 할 수 있다.

            // 무한루프의 구성할 경우, bool을 사용하여 처리한다.

            int iCnt = 1;
            int iResult = 0;

            bool bOnOff = true;

            while (bOnOff)
            {
                iCnt++;
                iResult += iCnt;
            }

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            // Do While
            // 반복문을 실행하지만 무조건 최초 1회는 실행될 수 있도록 하는 반복문

            // do문을 처음 실행 후 while문의 조건을 만족시킬 경우
            // do문을 계속해서 반복한다. (무조건 1회는 실행)

            int iCount = 1000;
            int iResult = 0;
            do
            {
                // 최초 1회 실행 및 조건 만족 시 반복실행
                iResult += iCount;
                iCount--;
            }
            while (iCount < 100);
        }
    }
}
