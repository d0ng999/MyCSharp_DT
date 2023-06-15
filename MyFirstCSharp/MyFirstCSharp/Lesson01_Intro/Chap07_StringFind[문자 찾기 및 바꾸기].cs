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
    public partial class Chap07_StringFind : Form
    {
        public Chap07_StringFind()
        {
            InitializeComponent();
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            // Index Of : 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치 정보 찾기

            // 타이틀 변수에 담기
            string sTitle = lblKorea.Text;

            // 사용자가 입력한 문자열을 변수에 담기
            string sValue = txtIndexOf.Text;

            // 사용자가 지정한 문자열의 위치를 찾아 담을 변수
            int iIndex = 0;
            iIndex = sTitle.IndexOf(sValue);

            // 암시적 형변환(iIndex는 int형식이지만, MessageBox.Show()인 문자열만 적을 수 있는 곳에
            // 다른 문자열 값과 함께 사용하면 int형식이 자연스래 형 변환된다.
            MessageBox.Show(sValue + "가(이) 있는 위치는 " + iIndex + "입니다.");

            // 암시적 형변환
            // 데이터 타입을 명시하지 않아도 데이터 타입이 큰 유형으로 자동 변환한다.
            // 컴파일러가 컴파일 시 자동으로 변환해주는 타입
        }

        private void btnLastIndex_Click(object sender, EventArgs e)
        {
            // Last Index Of : 문자열의 뒤에서 찾아 몇 번째 인덱스에 있는지를 리턴
            // 뒤에서부터 쭉 문자를 찾다가 발견하면 그 인덱스 값을 반환

            string sTitle = lblKorea.Text;

            // 사용자가 지정한 문자
            string sValue = txtLastIndex.Text;

            // 인덱스 위치 정보가 담길 변수 지정
            int iLastIndex = 0;

            // 문자열 뒤에서 몇 번째 index에 있는지를 확인하는 함수
            iLastIndex = sTitle.LastIndexOf(sValue);

            MessageBox.Show(sValue + "의 뒤쪽에서 위치는 " + iLastIndex + "입니다");

            // LastIndexOf는 뒤쪽에서 가장 처음 찾은 문자의 위치 정보를 반환.
        }

        private void btnStartWith_Click(object sender, EventArgs e)
        {
            // StartWith : 해당 문자열로 시작하는지 판단.
            // 타이틀 담기
            string sTitle = lblKorea.Text;

            // 사용자가 입력한 문자열을 변수에 담기
            string sValue = txtStartWith.Text;

            // 판단 결과 반환하기
            bool bFlag = sTitle.StartsWith(sValue);

            // MessageBox.Show는 문자열 값만 들어가야하는데 bool값만 들어가면 오류발생
            // 대신 bool값과 함께 문자열을 합쳐주면 bool형식을 문자열 형식으로 바꿔준다.
            MessageBox.Show("판단 결과 : " + bFlag);
        }

        private void btnEndWith_Click(object sender, EventArgs e)
        {
            // EndWith : 문자열이 지정한 문자로 끝나는지 판단한다.
            // 타이틀 문자열 받아오기
            //string sTitle = lblKorea.Text;

            //// 지정한 문자열 받아오기
            //string sValue = txtEndWith.Text;

            //// 판단 결과 반환하기
            //bool bFlag = lblKorea.Text.EndsWith(txtEndWith.Text);
            //MessageBox.Show("판단 결과는 " + bFlag + "입니다");


            // 위 로직은 아래와 같이 줄일 수 있다.
            MessageBox.Show("판단 결과는 " + lblKorea.Text.EndsWith(txtEndWith.Text) + "입니다");
        }

        private void btnContain_Click(object sender, EventArgs e)
        {
            // Contains() : 지정한 문자열을 포함하고 있는지 결과를 반환

            string sTitle = lblKorea.Text;
            string sValue = txtContain.Text;

            // 문자열을 포함하고 있는지 판단
            bool bFlag = sTitle.Contains(sValue);

            MessageBox.Show("판단 결과 : " + bFlag + "입니다");
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            // 특정 문자열을 원하는 문자열로 치환

            string sTitle = lblKorea.Text;

            // 변경 전 사용자가 입력한 문자열을 받아오기
            string sBeforeWord = txtBeforeWord.Text;

            // 변경 후 문자열 받아오기
            string sAfterWord = txtAfterWord.Text;

            // 변경을 완료 후 문자열이 담길 변수 지정
            string sResult = sTitle.Replace(sBeforeWord, sAfterWord);

            MessageBox.Show(sResult);
        }
    }
}
