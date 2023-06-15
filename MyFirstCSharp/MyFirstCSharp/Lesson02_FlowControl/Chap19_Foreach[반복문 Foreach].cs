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
    public partial class Chap19_Foreach : Form
    {
        // Foreach
        // - 열거형 데이터 자료구조에서 데이터를 추출할 때 사용
        // 열거형 자료구조 : 데이터 자료가 동일한 경우 하나의 열거형 데이터로 집합할 수 있는 자료구조
        //                  - 배열, 문자열, 리스트...등등
        // - 조건의 조건의 끝을 지정해주는 반복문(for, while)과는 달리
        //   자료형 구조가 포함하고 있는 데이터의 수에 따라 반복하므로 반드시 종료가 되는 반복문

        public Chap19_Foreach()
        {
            InitializeComponent();
        }

        private void btnStringForeach_Click(object sender, EventArgs e)
        {
            // Title 라벨에 등록되어있는 문자열의 문자를 하나씩 추출한다.

            // 1. 입력한 문자 정보 받아오기
            // Length : 배열에 있는 데이터의 개수
            // txtInputWord.Text가 문자열(문자의 배열)이라서 Length를 사용할 수 있다.
            if (txtInputWord.Text.Length > 1)
            {
                MessageBox.Show("두 글자 이상은 처리할 수 없습니다.");
                return;
            }

            // 글자 하나, 문자를 변수
            char cValue = Convert.ToChar(txtInputWord.Text);

            // 라벨의 Title 글귀를 담을 변수
            string sTitle = lblTitle.Text;

            //      ( 단위 데이터 자료구조 in 집합 자료구조)
            bool bFindFlag = false; // 같은 값을 찾았을때 True

            foreach (char c in sTitle)
            {
                if (cValue == c)
                {
                    bFindFlag = true;
                }
            }
            string sMessage = string.Empty;
            if (bFindFlag)
            {
                sMessage = $"{cValue} 문자는 포함되어 있습니다.";
            }
            else
            {
                sMessage = $"{cValue} 문자는 포함되어 있지 않습니다.";
            }
            MessageBox.Show(sMessage);
        }

        private void btnArrayForeach_Click(object sender, EventArgs e)
        {
            // 숫자형 배열에서 추출하는 로직
            int[] iValues = { 1, 2, 3, 4, 5, 6 };

            // Foreach가 반복하는 횟수
            int iCount = 0;
            
            foreach(int iValue in iValues)
            {
                MessageBox.Show($"배열의 {iCount}번째 주소에 있는 값은 {iValues[iCount]}입니다.");
                iCount++;
            }

            MessageBox.Show($"배열의 모든 데이터 수는 {iCount}개 입니다."); // 배열의 총 개수
            MessageBox.Show($"배열의 마지막 index 정보는 {iCount - 1}입니다");      // 배열의 index
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 컨테이너 안에 있는 텍스트 박스 일괄 초기화하기

            // 그룹박스에 포함되어 있는 컨트롤(도구)를 하나씩 추출하여
            // 텍스트 박스일 경우, 텍스트 속성의 내용을 지우는 로직을 구현
            // Winform 에서는 도구의 클래스를 (Control, Component)라고 부른다.

            // 그룹 박스의 컨트롤들을 하나씩 추출하여 컨트롤 클래스 MyControl로 받아낸다.
            foreach(Control MyControl in grpControls.Controls)
            {
                // is : 해당 클래스인지, 해당 클래스를 상속받았는지에 대한 려부 판단 후 결과를 반환함!

                // Control은 부모클래스 TextBox가 자식
                // TextBox가 Control을 상속받았는지???
                // 만약 MyControl이 TextBox 유형이면...
                if (MyControl is TextBox)
                {
                    MyControl.Text = ""; // 일괄적으로 텍스트박스 문자열을 초기화!
                }
            }
        }
    }
}
