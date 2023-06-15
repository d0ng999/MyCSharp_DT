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
    public partial class Chap20_MiddleTest_01 : Form
    {
        public Chap20_MiddleTest_01()
        {
            InitializeComponent();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            int[] iValues = { 1, 4, 6, 9, 10, 12, 16 };

            StringBuilder sText = new StringBuilder();

            /*
              3-1 String 클래스를 사용하는 경우 

               -문자열을 수정하는 수가 적을 경우(stringbuilder는 string에 비해서 무시해도 좋을 수준의 성능향상을 제공하거나 전혀 제공하지 않을 수 있음)

               -부분적인 문자열 글자로 고정된 수의 문자열 연결 작업을 할때(컴파일러가 연결 작업을 단일 작업으로 결합할 수 있음)

               -문자열을 작성하는 동안 광법위한 검색 작업을 수행할 때(StringBuilder 클래스는 IndexOf 또는 StartsWith같은 함수가 없다)

             3-2 StringBuiler 클래스를 사용 하는 경우

               -응용 프로그램이 설계시에는 알 수 없는 횟수의 문자열을 변경해야 할 때 ( 사용자의 입력등으로 조합할때 )

               -문자열에서 많은 횟수의 변경이 예상될때
             */

            // 알고리즘을 이용해서 풀이하는 방법
            //foreach (int iValue1 in iValues)
            //{
            //    foreach (int iValue2 in iValues)
            //    {
            //        if (iValue1 + iValue2 == 16)
            //        {
            //            sText.Append($"{{{iValue1}, {iValue2}}}\r\n");
            //        }
            //    }
            //}

            for (int i = 0; i < iValues.Length; i++)
            {
                int iResult = -1;

                int iFindValue = 16 - iValues[i];

                // 대상 찾기 메서드
                // Array.IndexOf(배열명, 값) : 배열에 값이 있는지 확인하고,
                //                             값이 있는 경우 해당 값의 인덱스를 반환
                //                             값이 없는 경우 -1을 반환

                iResult = Array.IndexOf(iValues, iFindValue);

                if (iResult == -1) continue;

                sText.Append($"{{{iValues[i]}, {iValues[iResult]}}}\r\n");
            }
            MessageBox.Show(sText.ToString() );
        }
    }
}
