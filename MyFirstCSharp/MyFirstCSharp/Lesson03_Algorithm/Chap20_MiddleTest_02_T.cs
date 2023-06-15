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
    public partial class Chap20_MiddleTest_02_T : Form
    {
        public Chap20_MiddleTest_02_T()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 2차원 배열 만들기
            int[,] iValues = { { 1, 4, 6, 9, 10, 12, 16 },
                               { 2, 7, 11, 13, 14, 15, 18 } };

            // 찾은 쌍을 등록해서 누적시킬 문자열 변수
            string sValues = string.Empty;

            // 배열의 행의 수 구하기
            int iRowCnt = iValues.GetLength(0);

            // 배열의 열의 수
            int iColCnt = iValues.GetLength(1);

            // 찾을 수(20 - 기준값)
            int iFindValue = 0;

            // 찾을 값을 누적시킬 배열(배열에서 값을 찾았을 경우)
            int[] iResults = new int[iRowCnt*iColCnt];
            int iResultIndex = 0; // 찾은 값이 등록될 주소;

            // 기준값을 찾기 위한 foreach Count
            // 반복의 횟수를 찾기
            int iMainForeachCnt = 0;
            int iSubForeachCnt = 0;

            bool bBreakFlag = false;
            // 2차원 배열에서 기준 값을 뽑아올 foreach
            foreach (int iValue in iValues)
            {
                ++iMainForeachCnt;
                bBreakFlag = false;
                // 메모화 기능을 이용한 벨리데이션
                // 찾은 값이 등록되어 있는 배열에서 기준값이 등록되어 있는지 확인
                for (int i = 0; i<iResults.Length; i++)
                {
                    if (iValue == iResults[i])
                    {
                        // 기존에 찾은 쌍의 값을 기준값으로 하여 찾으려 할 경우
                        // 중복 쌍을 찾는 경우이므로 등록 로직을 수행할 필요가 없다.
                        bBreakFlag = true;
                        break;
                    }
                }
                if (bBreakFlag) continue;

                // 기준 값과 합이 20이 되는 쌍의 수 구하기
                iFindValue = 20 - iValue;

                // iR_Value = 기준값에서 20을 만들 수 있는 대상 정수값
                foreach( int iR_Value in iValues)
                {
                    ++iSubForeachCnt;
                    if (iMainForeachCnt == iSubForeachCnt)
                    {
                        break;
                    }
                    // 찾아야 되는 수 == 배열에서 하나씩 추출한 수
                    if (iFindValue == iR_Value)
                    {
                        // 기준값과 합이 20이되는 수가 배열에 존재한다.
                        iResults[iResultIndex] = iR_Value; // 찾은 값을 메모화 배열에 등록한다.
                        ++iResultIndex;
                        // 찾은 값의 쌍을 보여주기 위해 문자열에 등록
                        sValues += $"{iValue}, {iR_Value}\r\n";
                        
                    }
                }
                // 찾을 값을 찾는 반복횟수 0으로 초기화
                iSubForeachCnt = 0;

            }
            MessageBox.Show(sValues);

        }
    }
}
