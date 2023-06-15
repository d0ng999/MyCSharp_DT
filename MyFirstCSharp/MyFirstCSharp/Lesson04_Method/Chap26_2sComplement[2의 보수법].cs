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
    public partial class Chap26_2sComplement : Form
    {
        public Chap26_2sComplement()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            /*
             *  앞의 Fibonacci 수열에서 49를 입력 시,
             *  int 자료형 리스트의 값 1134904170 + 183611903 = -132375223 인 이유
             *  
             *  int 자료형은 4Byte의 메모리 공간이 할당. 4Byte = 8Bit * 4
             *  1Byte = 8Bit 
             *  
             *  Bit는 0 또는 1의 상태를 담을 수 있는 메모리의 가장 작은 단위
             */

            int iValue1 = 1134904170;
            int iValue2 = 183611903;
            int iResult = iValue1 + iValue2; // 2971215073
            MessageBox.Show(iResult.ToString());

            // int는 4바이트를 담을 수 있는 자료형(32Bit)
            // 4Byte = 4294967295 ( 2 ** 32 )
            // 32Bit로 표현할 수 있는 최대 정수 - 음수를 포함하지 않는 최대 정수

            // 양수만 담을 수 있는 32Bit 정수 자료형
            uint uiValue = 4294967295;
            uiValue = uint.MaxValue; // 32 Bit 양수 자료 최댓값
            uiValue = uint.MinValue; // 32 Bit 양수 자료 최솟값 : 0

            // 하지만 int 는 양과 음의 수로 표현하므로, 최댓값과 최솟값의 범위가 이동 
            iResult = int.MaxValue; // 32 Bit 양수 포함 자료 최댓값 : 2147483647
            iResult = int.MinValue; // 32 Bit 음수 포함 자료 최솟값 : -2147483648

            uiValue = 2147483647 + 2147483648;

            // int 자료형 구조는 똑같이 4294967295의 범위를 담을 수 있는데,
            // 다만 - 부터 시작하여 절반을 나눠 가지므로
            // -2147483648 ~ 2147483647가 4294967295의 범위가 된다.

            // uint(양수만 관리하는 자료형)에서 
            // 0을 2진수로 표현 - 0000 0000 0000 0000 0000 0000 0000 0000 : 0이 32개

            // int의 경우, 가장 앞자리 bit의 0과 1을 음수와 양수로 사용한다.
            // int의 경우 최솟값은 -2147483648
            // 2진수로 표현
            // 1000 0000 0000 0000 0000 0000 0000 0000 : -2147483648
            // 1000 0000 0000 0000 0000 0000 0000 0001 : -2147483647
            // 1000 0000 0000 0000 0000 0000 0000 0010 : -2147483646
            // 1000 0000 0000 0000 0000 0000 0000 0011 : -2147483645

            // 1134903170 + 1836311903 = 2971215073
            // 이진법으로 변형
            // 1011 0001 0001 1001 0010 0100 1110 0001

            // 823,731,425 - 2,147,483,648 = -1,323,752,223

            // int 의 경우 최솟값에서 증가한 정수의 수로 확인하므로,
            // 최솟값에서 823731425만큼 증가했다고 판단

            // 양수와 음수를 표현하는 2의 보수법
            // 부호가 있는 숫자 자료형에서 2진수 데이터를 음수로 변환하는 알고리즘

            // ex) int의 최댓값인 2147483647 을 2의 보수법 알고리즘으로
            // int가 인식하는 음수 2진수로 만들어보자.
            // 0111 1111 1111 1111 1111 1111 1111 1111 = 2147483647

            // 1) 1은 0으로, 0은 1로 반전
            // 1000 0000 0000 0000 0000 0000 0000 0000 = -2147483648
            // 2) 마지막 수를 1 더하기
            // 1000 0000 0000 0000 0000 0000 0000 0001 = -2147483647

        }
    }
}
