using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap31_ClassTest_Main : Form
    {
        public static string sRunStop = "대기중";

        // 1. 일반 인스턴스 변수
        // 가동/비가동 클래스에서 전역변수로 전달 시 값 형으로 변형(x)
        private string sNowState = "대기중";

        // 2. 클래스(참조)를 전달
        // int[], 자기자신

        public Chap31_ClassTest_Main()
        {
            InitializeComponent();
        }

        private void btnMonitering_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"현재 설비의 상태는 {this.Tag} 입니다.");
        }

        private void btnRunCall_Click(object sender, EventArgs e)
        {
            // 가동 등록 화면을 호출.
            //Chap31_ClassTest_Run ClassRun = new Chap31_ClassTest_Run(ref sNowState);

            // 참조 전달 형식으로 자기 자신의 클래스를 전달
            Chap31_ClassTest_Run ClassRun = new Chap31_ClassTest_Run(this); 

            this.Visible = false;
            // Show : 비동기
            // ShowDialog : 동기
            ClassRun.ShowDialog();
            this.Visible = true; // 현재 화면을 보이지 않게 한다.(숨김 처리)
        }

        private void btnStopCall_Click(object sender, EventArgs e)
        {
            Chap31_ClassTest_Stop ClassStop = new Chap31_ClassTest_Stop(this);
            this.Visible = false; // 화면 숨김
            ClassStop.ShowDialog(); // 모달창(동기식으로 호출)
            this.Visible = true;
        }
    }
}
