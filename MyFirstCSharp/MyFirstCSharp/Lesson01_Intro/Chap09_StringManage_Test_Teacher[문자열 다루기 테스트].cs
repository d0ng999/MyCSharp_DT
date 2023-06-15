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
    public partial class Chap09_StringManage_Test_T : Form
    {
        // 클래스의 전역변수(혹은 필드멤버)
        string sTitle;

        // 클래스가 객체화될 때, 실행되는 멤버(생성자 멤버)
        public Chap09_StringManage_Test_T()
            // 클래스가 최초로 한 번 실행이 될 때에 이 생성자 멤버가 호출된다.
        {
            // 클래스가 최초 호출될 때, 디자인을 세팅하는 메서드
            InitializeComponent();
            // 이 메서드를 통해서 지금까지 만들어진 GUI기능들이 다 들어가있다. 
            // 클래스가 실행될 때, 이 메서드를 통해서 GUI를 나타낸다.

            // 원본 문자열을 저장
            // sTitle의 값은 바뀌지않는다.
            sTitle = lblTitle.Text;
        }

        private void btnNameChange_Click(object sender, EventArgs e)
        {
            // OOO를 자기 이름으로 표현
            lblTitle.Text = lblTitle.Text.Replace("OOO", "홍동현");
        }

        private void btnFindSW_Click(object sender, EventArgs e)
        {
            // S/W 인덱스 표시
            MessageBox.Show($"S/W 글귀의 위치는 {lblTitle.Text.IndexOf("S/W")}입니다.");
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            // 타이틀 문자열 변수 담기
            string sTitle = lblTitle.Text;
            MessageBox.Show($"시작 문자 : {sTitle[0]}, 종료문자 : {sTitle[sTitle.Length - 1]}");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {  
            // 앞 뒤에 -DT- 넣기
            lblTitle.Text = $"-DT-{lblTitle.Text}-DT";
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            // 특정 문자 소문자로 변경
            string sValue = "DIGITALTRANING";
            lblTitle.Text = lblTitle.Text.Replace(sValue, sValue.ToLower());
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            // 라벨 타이틀의 모든 공백 없애기
            lblTitle.Text = lblTitle.Text.Replace(" ", "");
        }

        private void btnRollBack_Click(object sender, EventArgs e)
        {
            // 전역변수 sTitle에 있는 원본 문자열을 다시 lblTitle.Text에 대입
            lblTitle.Text = sTitle;
        }
    }
}
