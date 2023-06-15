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
    public partial class Chap20_MiddleTest_05 : Form
    {
        public Chap20_MiddleTest_05()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 외부변수를 이용한 문자열 찾기 Count 계산
            string sTitle = lblTitle.Text;

            // 기준 문자열 (0 index 로부터 한칸씩 옆으로 이동해 비교할 문자)
            string sBaseString = string.Empty;

            // 결과 Index(첫 번째 ? index + 세번째 ? index
            int iResultIndex = 0;

            // ?를 찾은 횟수
            int iFindCount = 0;

            // i는 기준값의 index 문자열
            for (int i = 0; i < sTitle.Length; i++)
            {
                // i번째 인덱스 값의 문자를 1글자 잘라서 대입(할당)해준다.
                sBaseString = sTitle.Substring(i, 1);

                if (sBaseString == "?")
                {
                    // ?를 찾았을때, 1번째인지 혹은 3번째인지
                    // 해당 ?의 인덱스를 누적 대입하는 로직
                    ++iFindCount; // ?찾은 횟수

                    if (iFindCount == 2) continue;

                    // 찾은 인덱스를 누적
                    iResultIndex += i;

                    if (iFindCount == 3) break; // 반복문 종료
                }
            }
            // 반복문 종료 후 iResultIndex에는 1번째 ?와 3번째 ?의 
            // 인덱스 합이 누적되어 있다.

            // 결과의 누적 인덱스에 있는 곳으로부터 3자리 xxx치환
            string sFindString = sTitle.Substring(iResultIndex, 3);
            txtResult.Text = sTitle.Replace(sFindString, "xxx");            
        }
    }
}
