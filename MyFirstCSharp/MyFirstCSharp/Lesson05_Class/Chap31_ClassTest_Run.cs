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
    public partial class Chap31_ClassTest_Run : Form
    {
        private string _sNowState;

        private Chap31_ClassTest_Main _TempClass;

        public Chap31_ClassTest_Run(ref string sNowState)
        {
            InitializeComponent();
            this._sNowState = sNowState;
        }

        // 클래스 생성자 OverLoad
        public Chap31_ClassTest_Run(Chap31_ClassTest_Main TempClass)
        {
            InitializeComponent();
            _TempClass = TempClass;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // 가동 화면 클래스에서 가동버튼을 클릭하였을 경우

            // 1. 벨리데이션을 통해 거를 내역을 먼저 걸러놓고(로직을 수행하면 안되는 경우)
            // 2. 정상 조건일 경우의 로직을 안전하게 구현
            // 3. 데이터베이스의 세션을 종료
            // 4. 메세지를 통해 상태를 보고

            //Chap31_ClassTest_Main.sRunStop = "가동중";

            //_sNowState = "가동중";

            _TempClass.Tag = "가동중";

            MessageBox.Show("가동 상태를 등록하였습니다.");
            this.Close(); // 현재 클래스를 종료(현재 클래스를 메모리에서 삭제)
        }
    }
}
