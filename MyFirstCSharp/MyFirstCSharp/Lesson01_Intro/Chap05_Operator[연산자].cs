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
    public partial class Chap05_Operator : Form
    {
        // 연산자
        // 프로그램에서 변수나 값의 연산을 위해 사용되는 부호

        public Chap05_Operator()
        {
            InitializeComponent();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            // 대입 연산자

            int iValue; // 첫 번째 데이터를 담는 변수
            iValue = 10; // = 를 통하여 10이라는 리터럴을 iValue 변수에 대입
            MessageBox.Show(Convert.ToString(iValue));
        }

        private void btnSumEqual_Click(object sender, EventArgs e)
        {
            // += : 리터럴을 외쪽 변수에 있는 값과 합한 후 결과를 다시 왼쪽 변수에 대입한다.
            int iValue = 10;
            // iValue = iValue + 10;

            // 누적 증가 연산자를 사용하면 위와 같은 결과를 얻을 수 있음!
            iValue += 10;

            MessageBox.Show(Convert.ToString(iValue));
        }

        private void btnMinEqual_Click(object sender, EventArgs e)
        {
            // 누적 감소 연산자 : -=
            // 리터럴 값을 왼쪽 변수에 차감하여 자기자신(변수)에 담는다.

            int iValue = 10;
            iValue -= 5;

            MessageBox.Show(Convert.ToString(iValue));
        }

        private void btnMulEqual_Click(object sender, EventArgs e)
        {
            // 누적 곱 연산자 : *=
            int iValue = 10;
            iValue *= 10;

            MessageBox.Show(Convert.ToString(iValue));
        }

        private void btnDivEqual_Click(object sender, EventArgs e)
        {
            // 누적 나눗셈 연산자 : /= 자기자신 변수에 나누기의 몫을 대입한다.
            // 결과값은 몫이 나온다.
            int iValue = 10;
            iValue /= 3;
            MessageBox.Show(Convert.ToString(iValue));
        }

        private void btnPerEqual_Click(object sender, EventArgs e)
        {
            // % 연산자의 결과는 나머지 값이 나온다.
            // %= 나머지의 값을 자기자신의 변수에 대입한다.
            int iValue = 10;
            iValue %= 3;
            MessageBox.Show(Convert.ToString(iValue));
        }

        private void btnSS_Click(object sender, EventArgs e)
        {
            // 전위 or 후위 증가 연산자
            // 왼쪽 변수에 1씩 더한다.
            int iValue = 10;
            iValue++; // 후위 증가연산
            // 후위 증가연산 : 코드가 실행되고 난 다음에 자기자신에게 1 증가된 값이 대입된다.
            MessageBox.Show(Convert.ToString(iValue));
            MessageBox.Show(Convert.ToString(iValue++));
            MessageBox.Show(Convert.ToString(++iValue));

            ++iValue; // 전위 증가연산
            // 전위 증가연산 : 코드가 실행될 때, 자기자신에게 1 증가된 값이 대입된다.
            // 전위 증가연산(실시간 증가 연산 처리 기능)을 사용하는 것을 권장함.
            MessageBox.Show(Convert.ToString(iValue)); 
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            // 전위 감소 연산자, 후위 감소 연산자
            int iValue = 10;
            iValue--;
            MessageBox.Show(Convert.ToString(iValue));
            MessageBox.Show(Convert.ToString(--iValue));
            MessageBox.Show(Convert.ToString(iValue--));
        }
    }
}
