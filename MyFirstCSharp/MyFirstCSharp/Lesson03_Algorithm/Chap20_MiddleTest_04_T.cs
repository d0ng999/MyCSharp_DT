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
    public partial class Chap20_MiddleTest_04_T : Form
    {
        public Chap20_MiddleTest_04_T()
        {
            InitializeComponent();
        }

        private void btnFindResult_Click(object sender, EventArgs e)
        {
            // 라벨의 텍스트를 숫자로 받아오기

            // 타이틀의 문자를 숫자로 변환하도록 문자 배열에 담기
            string sTitle = lblTitle.Text.Replace(" ", "")
                                         .Replace("{", "")
                                         .Replace("}", "");
            string[] sTitles = sTitle.Split(',');

            // 대상 문자배열에 있는 값을 숫자 배열로 등록하기.
            int[] iValues = new int[sTitles.Length];
            for (int i = 0; i < sTitles.Length; i++)
            {
                iValues[i] = int.Parse(sTitles[i]);
            }

            // 오름차순 정렬
            Array.Sort(iValues);

            string sResult = string.Empty; // 첫번째와 세번째 중복값을 담을 변수
            int iFindCount = 0;

            int iFindValue = 0; // 이전에 비교한 값을 담을 변수

            // i : 정수 배열의 Index
            for (int i = 0;i < iValues.Length;i++)
            {
                // 중복되는 데이터인지 확인
                if (iValues[i] == iValues[i+1])
                {
                    if (iValues[i] == iFindValue) continue;
                    ++iFindCount; // 중복값을 찾은 경우 1증가
                    // 중복

                    // 두번째 중복은 필요없어서 다음 반복문으로 실행
                    if (iFindCount == 2) continue;

                    // 첫 번째 중복과 세 번째 중복값
                    sResult += iValues[i].ToString() + " ";
                    if (iFindCount == 3) break; // 세번째 중복을 찾았을 경우, 반복문 종료
                }
                // 다음 for문이 시작되기 전에 현재 기준값을 이전 값으로 등록
                // 등록 후 for 문 증가!
                iFindValue = iValues[i];
            }
            MessageBox.Show($"첫번째와 세번째 중복되는 값은 {sResult}입니다.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text.Replace(" ", "")
                                         .Replace("{", "")
                                         .Replace("}", "");
            string[] sTitles = sTitle.Split(',');

            // 대상 문자배열에 있는 값을 숫자 배열로 등록하기.
            int[] iValues = new int[sTitles.Length];
            for (int i = 0; i < sTitles.Length; i++)
            {
                iValues[i] = int.Parse(sTitles[i]);
            }

            // 오름차순 정렬
            Array.Sort(iValues);

            int iCount = 0;

            string sResult = string.Empty;

            for (int i = 0; i <= iValues.Length; i++)
            {
                if (iValues[i] == iValues[i+1])
                {
                    if (iValues[i] == iValues[i-1]) continue;

                    ++iCount;

                    if (iCount == 2) continue;

                    sResult += iValues[i].ToString() + " ";

                    if (iCount == 3) break;
                }
            }
            MessageBox.Show($"첫번째와 세번째 중복되는 값은 {sResult}입니다.");
        }
    }
}