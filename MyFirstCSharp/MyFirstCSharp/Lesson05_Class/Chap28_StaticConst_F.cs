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
    public partial class Chap28_StaticConst_F : Form
    {
        public Chap28_StaticConst_F()
        {
            InitializeComponent();
        }

        private void btnStep1_Click(object sender, EventArgs e)
        {
            // 특정한 클래스의 인스턴스 필드, 메서드 (멤버)를 호출하기 위해서는
            // 클래스를 객체화해야한다.(인스턴스화)
            Chap27_AccessModifier CHAP27 = new Chap27_AccessModifier();
            CHAP27.sPublic = "";

            // Static 정적 한정자를 호출
            // 정적 멤버 자체를 Data, Code 영역에 등록하므로, 별도의 클래스를 객체화 할 필요가 없다.
            Static_Class.sValue = "값을 초기화해서 데이터 영역에 등록합니다.";

            Static_Class.sValue = "안녕하세요";

            MessageBox.Show(Static_Class.sValue);

        }

        private void btnStep2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Static_Class.sValue);
            Static_Class.sValue = "반갑습니다";
        }

        private void btnStep3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Static_Class.sValue);
                                   
            Static_Class.sValue = "C#프로그래밍";

            MessageBox.Show(Static_Class.sValue);
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
            // 정적 필드와 인스턴스 필드를 모두 가지고 있는 클래스를 활용

            // 1. Static 형이 아닌 일반 필드(인스턴스 필드)
            //    클래스를 객체화하여 호출한 후, Heap 영역에 할당
            //    로직 종료 시 소멸

            Static_Or_Instance_Class STO = new Static_Or_Instance_Class();
            STO.sInstance = "방갑습니다.";
            // STO.sStaticValue = "호출이 안되네;;;"; -> 정적 필드에는 인스턴스 객체로 접근할 수 없다.

            // DATA 영역에 클래스 필드가 값이 할당되어 (초기화) 등록이 된다.
            Static_Or_Instance_Class.sStaticValue = "인스턴스 필드를 가지고 있는 클래스의 정적 필드를 호출할 수 있다.";
        }

        private void btnStaticCall_Click(object sender, EventArgs e)
        {
            // Static_Or_Instance_Class 에 있는 필드 값을 호출 표현
            Static_Or_Instance_Class SOIC = new Static_Or_Instance_Class();
            MessageBox.Show(SOIC.sInstance);

            // 정적필드의 값 표현
            MessageBox.Show(Static_Or_Instance_Class.sStaticValue);
        }

        private void btnStaticMethod_Click(object sender, EventArgs e)
        {
            // 정적 메서드 호출
            // 메서드가 호출됨과 동시에 Code 영역에 등록
            Static_Or_Instance_Class.StaticMethod();
        }

        private void btnConst_Click(object sender, EventArgs e)
        {
            // 상수 : 바뀌지 않는 값

            // 1. 상수가 있는 클래스 객체를 생성
            Const_Class constclass = new Const_Class(); // 상수 필드가 있는 클래스를 인스턴스화 했다.

            // 2. 상수는 Static 성격을 가지고 있으므로 객체화하여 호출할 수 없다.
            // MessageBox.Show(constclass.sConst()); 

            // 3. 상수에 데이터를 할당하려할 경우 오류 발생
            // Const_Class.sConst = ""; - 당연히 안된다. 상수 - 고정값이라서 되지 않는다.

            // 4. 확인
            MessageBox.Show(Const_Class.sConst);
        }
    }
}
