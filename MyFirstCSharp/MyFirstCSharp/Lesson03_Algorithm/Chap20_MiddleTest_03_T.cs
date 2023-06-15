using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// namespace / project / 클래스 라이브러리 / dll / API / 어셈블리 라고 불린다.
namespace MyFirstCSharp
{
    public partial class Chap20_MiddleTest_03_T : Form
    {
        // 클래스의 전역변수, 필드멤버, 인스턴스 변수
        // 이 변수들은 생성자보다 먼저 메모리에 생성된다.
        int iClickCount; // 기본값은 0


        public Chap20_MiddleTest_03_T() // 생성자
        {
            InitializeComponent();
        }

        private void btnMakeRandom_Click(object sender, EventArgs e)
        {
            ++iClickCount;

            Random rNumber = new Random();
            int iRanNumber = rNumber.Next(100);

            // 난수 생성 버튼을 클릭한 횟수에 따른 표기!
            if (iClickCount == 1)
            {
                txtNum1.Text = iRanNumber.ToString();
            }
            else if(iClickCount == 2)
            {
                txtNum2.Text = iRanNumber.ToString();
            }
            else
            {
                txtNum3.Text = iRanNumber.ToString();
                iClickCount = 0;
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 세 수를 담을 배열 생성
            int[] iValues = new int[3];
            int.TryParse(txtNum1.Text, out iValues[0]);
            int.TryParse(txtNum2.Text, out iValues[1]);
            int.TryParse(txtNum3.Text, out iValues[2]);

            Array.Sort(iValues); // 오름차순으로 정렬 -> 0인덱스 : 최솟값 / 2인덱스 : 최댓값

            // 배열에 있는 값을 모두 더하기
            int iSumValue = 0;
            foreach (int iValue in iValues)
            {
                iSumValue += iValue;
            }

            string sMessage = string.Empty;
            if (iSumValue < 100)
            {
                sMessage = $"세 수의 합이 100미만이면 최솟값: {iValues[0]} / 최댓값: {iValues[2]}" +
                            $"곱은 :{iValues[0] * iValues[2]} ";
            }
            else if(iSumValue >=100 && iSumValue < 200)
            {
                sMessage = $"세 수의 합이 100이상 200미만이면 최솟값: {iValues[0]} / 최댓값: {iValues[2]}" +
                            $"곱은 :{iValues[0] * iValues[2]} ";
            }
            else
            {
                sMessage = "세 수의 합이 200을 넘습니다.";
            }
            MessageBox.Show(sMessage);

            // 텍스트박스 일괄 클리어
            // this: 지금 현재 로직이 구현되고 있는 클래스를 지칭

            // 지금 화면(클래스)에 있는 모든 컨트롤을 추출
            foreach (Control con in this.Controls)
            {
                if (con is TextBox) // 클래스에 있는 컨트롤이 텍스트박스라면
                {
                    // 현재 화면에 있는 모든 텍스트 박스를 초기화
                    con.Text = "";
                }
            }
            iClickCount = 0;
        }
    }
}
