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
    public partial class Chap12_IF_Test_T : Form
    {
        // 버튼 클릭의 누적 횟수를 담는 변수
        // (클래스 Chap12_IF_Test_T가 호출(인스턴스화, 객체화)될 때 최초 1회(0으로)생성)
        int iButtonClick = 0; // 클래스 필드 멤버 (클래스 전역 변수)

        public Chap12_IF_Test_T()
        {
            InitializeComponent();
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            // 버튼을 총 클릭한 횟수(정수)
            ++iButtonClick; // 이는 전위 증가연산자이다.
            txtBtnClickCount.Text = iButtonClick.ToString();

            // 1. 변수 설정
            string sValue = txtInputValue.Text; // 입력받을 값
            int iValue = 0;                     // 입력받은 값은 값이 정수로 변환될 변수
            bool bCheck = false;                // 입력받은 값이 정수로 변환 가능여부를 확인

            // 2. 입력한 문자가 숫자로 바뀔수 있는지 검증.(Validation)
            bCheck = int.TryParse(sValue, out iValue);
            if (!bCheck)
            {
                MessageBox.Show("숫자만 입력하세요");
                return; // Validation 체크 후 오류 발생 검출 시 로직을 호출하는 곳으로 반환(종료);
            }

            string sMessage = string.Empty; // "" - 분기에 따른 메세지 변수
            // 3. 2와 5의 공배수인지 판단.
            if ((iValue % 2 == 0) && (iValue % 5 == 0))
            {
                sMessage = "2와 5의 공배수입니다.";
            }
            else
            {
                sMessage = "2와 5의 공배수가 아닙니다.";
            }

            MessageBox.Show(sMessage);

            // 4. 8의 배수인지 확인
            if (iValue % 8 == 0)
            {
                // 입력한 값과 8을 곱하여 8의 배수를 텍스트박스에 표현
                txtEMultiValue.Text = Convert.ToString(iValue * 8);
            }
            else
            {
                txtEMultiValue.Text = "";
            }
        }
    }
}
