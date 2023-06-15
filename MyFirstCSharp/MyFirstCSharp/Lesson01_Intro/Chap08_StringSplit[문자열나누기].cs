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
    public partial class Chap08_StringSplit : Form
    {
        public Chap08_StringSplit()
        {
            InitializeComponent();
        }

        private void btnInterpolation_Click(object sender, EventArgs e)
        {
            // 문자열 보간
            // 보간 : 비거나 누락된 부분을 채우는 기능
            // 문자열의 " " 사이에 { }를 사용해서 표현하고자 하는 변수를 표기하는 방법
            // { }안에 들어가는 데이터 타입 (변수, 상수) 문자열로 형변환(암시적으로 변환됨)

            string sValue; // 보간을 통해 표현될 문자열이 담기는 변수

            // 문자형 데이터의 보간
            sValue = $"라벨의 타이틀 문구는 {lblKorea.Text} 입니다.";
            MessageBox.Show(sValue);

            // 정수형 데이터의 보간
            int iValue = 1;
            sValue = $"iValue의 값은 {iValue} 입니다.";
            MessageBox.Show(sValue);

            // "" 문자열의 시작과 종료를 나타내는 기능
            // "강사님이 "화이팅"이라고 말했다." 의 경우에는 ""앞에 \를 사용해야한다.
            // \의 의미는 기능으로 사용하지 않겠다라고 의미하는 것

            sValue = $"강사가 \"화이팅\" 이라고 말했다.";
            MessageBox.Show(sValue);

            // 보간법에 포함되는 {}를 문자로 표현
            // {{ }} 단지 중괄호를 두 번 더 써주면 된다.
            // "iValue의 값은 {1}입니다"
            sValue = $"iValue의 값은 {{{iValue}}}입니다.";
            MessageBox.Show(sValue);

            // 개행(줄바꿈) \r\n
            MessageBox.Show("안녕하세요\r\n반갑습니다.");
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            // 문자열의 갯수를 구하는 기능 : Length
            // 나열되어 있는 열거형의 자료 개수를 구하는 기능

            // 타이틀 문자열 받아오기
            string sTitle = lblKorea.Text;
            MessageBox.Show($"라벨의 문자열의 문자 개수는 {sTitle.Length}개 입니다.");
            
            // 문자열의 마지막 인덱스 찾기
            MessageBox.Show($"sTitle의 마지막 주소값은 {sTitle.Length - 1}입니다.");

            // 배열의 개수와 index 구하기
            int[] iValues = { 11, 12, 13, 14, 15 };
            int iValuesLength = iValues.Length;

            //string[] sValues = { lblKorea.Text };
            //MessageBox.Show(sValues[sValues.Length - 1]);

            // 마지막 배열의 수를 찾기
            // 인덱스는 배열에서 사용가능한다!!
            int iLastArrayValue = iValues[iValuesLength - 1];
            MessageBox.Show($"iValues의 개수는 {iValuesLength}개, 마지막 배열의 수는 {iLastArrayValue}이다.");
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            // Split : 지정한 문자를 기준으로 문자열(열거형 데이터)를 자르고, 
            // 자른 값의 결과를 배열 형태로 반환한다.

            // 1. '/'를 기준으로 나눈 문자열을 Split 배열에 담는다.
            // 배열 : 같은 타입의 변수를 여러개 모아 놓은 데이터 타입
            string[] sValues = lblKorea.Text.Split('/');

            // 배열에 몇 개의 데이터가 나누어져 있는지 확인
            MessageBox.Show($"타이틀의 / 기준 문단 개수는 {sValues.Length}개 입니다.");

            // 배열의 첫 번째 문단
            MessageBox.Show($"타이틀의 1번째 문단은 {sValues[0]}입니다.");

            // 배열의 마지막 문단
            MessageBox.Show($"타이틀의 마지막 문단은 {sValues[sValues.Length - 1]}입니다.");
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            // Substring : 사용자가 지정한 위치 및 개수만큼 문자를 잘라서 표현하는 기능

            // 문자열을 잘라올 원본 문자열
            string sTitle = lblKorea.Text;

            // 문자열을 자를 위치 값을 담을 변수
            int iIndex = 0;
            int.TryParse(txtIndex.Text, out iIndex);

            // 문자열을 잘라올 개수
            int iCount = 0;
            int.TryParse(txtCount.Text, out iCount);

            // 문자열을 잘라와서 담을 변수
            string sValue;
            sValue = sTitle.Substring(iIndex, iCount);

            MessageBox.Show($"타이틀 {sTitle}의 {iIndex}째 주소로부터 {iCount}개의" +
                $" 문자를 자른 결과는 {sValue}입니다.");

            // 위의 로직을 하나의 행으로 표현 = InLineCode
            MessageBox.Show($"타이틀 {lblKorea.Text}의 {txtIndex.Text}째 " +
                $"주소로부터 {txtCount.Text}개의 문자를 자른 결과는" +
                $" {lblKorea.Text.Substring(Convert.ToInt32(txtIndex.Text), Convert.ToInt32(txtCount.Text))}" +
                $"입니다.");
        }
    }
}
