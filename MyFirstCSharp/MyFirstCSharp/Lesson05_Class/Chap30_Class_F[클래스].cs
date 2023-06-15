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
    public partial class Chap30_Class_F : Form
    {
        // Chap29_Class 클래스를 Chap30_Class_F 의 필드멤버로 등록
        private Chap29_Class _CHAP29 = new Chap29_Class();
        public Chap30_Class_F()
        {
            InitializeComponent();
            MessageBox.Show(_CHAP29.sValue);
        }

        private void btnClassCall_Click(object sender, EventArgs e)
        {
            // 클래스의 객체화(인스턴스화)
            // 클래스 -> 객체로 변환하는 과정
            Chap29_Class CHAP29 = new Chap29_Class();
            CHAP29.sValue = "클래스의 전역변수";

            // CHAP29 객체의 sValue가 변경되더라도 
            // CHAP29_T와는 별개의 클래스 객체이므로
            // CHAP29_T.sValue의 값은 영향을 받지 않는다.
            Chap29_Class CHAP29_T = new Chap29_Class();
            MessageBox.Show(CHAP29_T.sValue);
        }

        private void btnClass2_Click(object sender, EventArgs e)
        {
            // OverLoading 된 생성자를 호출하여 클래스 멤버 초기화
            string sValue = "던져주는 값으로 초기화한다.";

            Chap29_Class CHAP29 = new Chap29_Class(sValue);
            MessageBox.Show(CHAP29.sValue);
        }

        private void btnFieldCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_CHAP29.sValue); // "안녕하세요 필드 멤버 인스턴스 문자열 변수입니다."
            _CHAP29.sValue = "바꿔버렸어요";

            MessageBox.Show(_CHAP29.sValue); // 바꿔버렸어요
        }

        private void btnFieldsCall2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_CHAP29.sValue); // 바꿔버렸어요
            _CHAP29.sValue = "언제바꼈나용";

            MessageBox.Show(_CHAP29.sValue); // 언제바꼈나용
        }

        private void btnClassMethodCall_Click(object sender, EventArgs e)
        {
            // 전역변수 클래스 객체에 등록되어 있는 
            _CHAP29.MethodMember();
        }
    }
}
