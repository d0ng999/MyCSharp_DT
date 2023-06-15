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
    public partial class Chap31_ClassTest_Stop : Form
    {

        private Form _TempForm;

        //public Chap31_ClassTest_Stop()
        //{
        //    InitializeComponent();
        //}

        public Chap31_ClassTest_Stop(Form TempForm) // Form : 부모클래스로서 Main, Run, Stop 클래스에 상속을 시켜줬기에 사용 가능하다.
        {
            InitializeComponent();
            this._TempForm = TempForm;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //Chap31_ClassTest_Main.sRunStop = "비가동";
            _TempForm.Tag = "비가동";

            MessageBox.Show("비가동 상태를 등록하였습니다.");
            this.Close(); // 현재 클래스를 종료(현재 클래스를 메모리에서 삭제)
        }
    }
}
