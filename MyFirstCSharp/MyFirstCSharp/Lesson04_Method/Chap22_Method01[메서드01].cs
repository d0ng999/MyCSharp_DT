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
    public partial class Chap22_Method : Form
    {
        // 메서드

        // 1. 클래스의 주요 멤버, 클래스의 멤버 - 메서드 멤버

        // 2. 프로그램 로직이 실제로 작동을 하는 코드 블럭
        //    - 단, 다른 곳에서 해당 메서드를 호출하기 전까지는 아무런 의미가 없다.
        //    * 객체 지향의 코딩은 언젠가는 호출을 하여 동작을 하게될 기능들을 나열해 두고,
        //      그 기능들을 조합해서 프로그래밍
        //      (컴퓨터가 알아듣게 명령해서 수행할 수 있도록) 하는 것!!!

        // 3. 반복되는 코드를 메서드화하여 특정 위치에 등록해주고, 
        //    필요에 의해 호출하는 방식으로 재사용성을 높일 수 있다.
        //    (여러 포인트에서 같은 로직을 실행하게 할 수 있다는 것) - 재사용성

        // 4. 메서드 내부의 로직 수정 시, 일괄적으로 적용된 모든 코딩에서 변경 내용으로 
        //    구동되게 수정할 수 있다.(유지보수성)

        // 5. 코딩이 간결해지므로 가독성을 높일 수 있다. - 가독성

        public Chap22_Method()
        {
            InitializeComponent();
        }

        #region < Method의 호출 >
        private void btnMethodCall_Click(object sender, EventArgs e)
        {
            // 메서드를 실행, 메서드를 호출한다.
            // 동작을 시킬 메서드를 호출함으로써 메서드 내부의 로직을 수행
            ShowMessage();
        }

        void ShowMessage()
        {
            // 메서드의 기본 유형
            // [반환할 타입] [메서드 명](값을 전달받을 내용)
            // void          ShowMessage(***)

            MessageBox.Show("메서드를 호출하였습니다.");
        }
        #endregion

        #region < 인수 인자 >
        private void btnPaAr_Click(object sender, EventArgs e)
        {
            // 인수와 인자
            // 인자 : 메서드가 호출될 때, 꼭 받아야만 하는 데이터
            // 인수 : 메서드를 호출할 때, 던져주어야만 하는 데이터
            // 인수와 인자가 일치하여야만 메서드 기능을 동작시킬 수 있다.

            // 메서드에 데이터를 전달하는 자료 : 인수, Argument
            // 데이터를 받는 곳, 자료 : 인자, 매개변수, Parameter
            // 아! 수주 받자매 파.
            // 아!규먼트와 인수 // 인자!와 매개변수, 파라미터
            ShowMessage2("짜잔");
        }

        void ShowMessage2(string message)
        {
            // ShowMessage2를 호출하기 위해서는 문자열(message)과 같이 호출해야 한다.
            // 호출된 ShowMessage2 메서드는 전달받은 문자열을 메세지박스로 표현한다.
            MessageBox.Show(message);
        }
        #endregion

        #region < 아무 값을 반환하지 않는 메서드 리턴 Void >
        private void btnVoidReturn_Click(object sender, EventArgs e)
        {
            VoidReturnMethod("안녕하세요"); // 메서드를 호출하는 것
        }

        void VoidReturnMethod(string smessage)
        {
            // void [메서드 이름]
            // void : 아무런 값을 반환하지 않는 값
            //      : 아무런 값을 반환하지 않아도 된다는 약속을 한 메서드이므로,
            //      : 메서드 내에 return; 구문이 없어도 사용가능하다.

            MessageBox.Show(smessage);
            txtTitle.Text = smessage;

            //return; // 리턴은 메서드를 호출한 곳으로 로직을 반환
                    // 메서드를 종료하라는 의미보다는 호출한 곳으로 돌아가라는 의미가 더 맞는 표현

            // 바로 직전 로직에서 return; 이 있으므로 실행되지 않는 구문
            lblTitle.Text = smessage;
        }
        #endregion

        #region < string 값을 반환하는 return >
        private void btnStringReturn_Click(object sender, EventArgs e)
        {
            // 반환 데이터 형식이 지정된 메서드
            //      1. 메서드를 호출한 곳에서 반환값을 전달받아 후속 로직을 구현할 수 있도록 해준다.
            string sResult = StringReturnMethod("문자열을 전달합니다.");
            MessageBox.Show(sResult); // 문자열을 반한합니다.
            //      2. 반환 데이터가 있는 메서드를 호출할 때, 값을 전달받지 않아도 무관하다.

            StringReturnMethod("반환값을 받지 않는 메서드 호출");
        }

        string StringReturnMethod(string sMessage)
        {
            // string 형식의 데이터를 호출한 곳을 반환하기로 약속한 메서드
            // 3. return 구문으로 string을 반환해 주기 않으면 오류가 발생(컴파일)

            MessageBox.Show(sMessage); // 문자열을 전달합니다.
            sMessage = "문자열을 반환합니다"; // 문자열 할당

            return sMessage;
        }
        #endregion


        #region < int 값을 반환하는 리턴 메서드 >
        private void btnIntReturn_Click(object sender, EventArgs e)
        {
            int iValue1 = 10;
            int iValue2 = 20;

            MessageBox.Show(intSumReturnMethod(iValue1, iValue2).ToString());
            // 위 로직은 아래와 같이 표현할 수 있다.

            //int iResult = 0;
            //iResult = intSumReturnMethod(iValue1, iValue2); // iValue1 과 iValue2의 합을 할당
            //MessageBox.Show(iResult.ToString());
        }

        int intSumReturnMethod(int iV1, int iV2)
        {
            // 정수 2개를 인자로 받아 합한 결과를 리턴하는 메서드
            int iSum = iV1 + iV2; // iV1과 iV2 인자에 어떠한 정수값이 오더라도
                                  // 합한 결과를 반환하는 공통 메서드
            // int형을 반환하기로 약속한 메서드
            return iSum;
        }
        #endregion

        #region < 인자가 기본 값을 가지는 메서드(선택적 인수) >
        private void btnDefaultPaRa_Click(object sender, EventArgs e)
        {
            // 메서드에서 전달받을 인자의 유형에 상관없이 메서드를 호출하고 싶을 때

            // 예를 들어 생성되어 있는 메서드를 호출한 로직이 여러 번 구현되어 있을 때..

            // 1번 사용
            DefaultParameter(10, 20);

            // 다른 로직에서 등록한 메서드 사용
            DefaultParameter(40, 30);

            // 다른 로직에서 등록한 메서드를 사용
            DefaultParameter(50, 60);

            // 어떤 이유로 인하여 값을 3개를 합해야하는 상황이 발생

            // 기존의 메서드 호출하는 구현부에서 오류가 발생한다.
            // 그래서 나온 것이 선택적 인수라는 개념을 적용할 수 있다.

            // 새로운 로직을 적용하여 기존의 메서드를 재사용할 수 있다.
            DefaultParameter(10, 20, 30); 
            // 3번째 인수로 30을 전달할 경우, 10 + 20 + 30의 결과를 확인할 수 있다.
        }

        // 선택적 인수를 호출할 수 있는 메서드를 생성
        //void DefaultParameter(int iValue, int iValue2, int iValue3) // 필요에 의해 인자를 1개 더 추가
        void DefaultParameter(int iValue, int iValue2, int iValue3 = 50)// 전달받은 인자를 합하여 표현
                                                                       // 인자에 기본값을 설정(선택적 인수를 적용)
        {
            // 인자 값에 기본값을 설정할 경우
            // 중간에 있는 인자에만 기본값 설정 인자로 만들수 없다.
            // 마지막 인자들에만 선택적 인수를 적용할 수 있다.
            MessageBox.Show((iValue + iValue2).ToString()); 
        }
        #endregion

        #region < 클래스를 인수로 전달하는 메서드 >
        private void btnCatch1_Click(object sender, EventArgs e)
        {
            // 두 개의 버튼 클래스의 text 속성을 변경하는 로직이 반복적으로 나타날 경우
            // 버튼 클래스를 인자로 받는 메서드를 생성 후, 
            // 인수를 던져주는 버튼 클래스 별로 가변적으로 처리될 수 있도록 구현할 수 있다.
            btnCatch(btnCatch1, btnCatch2);
        }
        private void btnCatch2_Click(object sender, EventArgs e)
        {
            btnCatch(btnCatch2, btnCatch1);
        }

        // 버튼을 클릭하였을 경우, text를 옮겨다니는 기능을 할 메서드
        void btnCatch(Button btn_Hide, Button btn_Show)
        {
            btn_Hide.Text = "";
            btn_Show.Text = "나 잡아봐라";
        }
        #endregion

        #region < 인수를 배열로 전달하는 경우 (참조 주소값을 전달) >
        private void btnArrayArg_Click(object sender, EventArgs e)
        {
            // 배열을 인수로 전달하는, 배열을 인자로 받는 메서드

            string[] sValues = { "안녕하세요", "반갑습니다", "C#프로그래밍"};

            // 배열을 전달 후, 배열의 결과 확인
            ArrayArgMethod(sValues);
            MessageBox.Show(sValues[0]);

            // 배열을 전달 후, 메서드 내에서 수정이 이루어졌을 경우
            // 호출한 곳에 있는 전달한 배열의 결과를 확인
            ArrayChangeMethod(sValues);
            string[] _Svalues = sValues;
            MessageBox.Show(sValues[0]);

            // 값 형식의 데이터를 전달하는 경우
            // Stack에 있는 값 자체를 복사하므로
            // 메서드 내에 값이 변경되더라도 인수의 값은 변형되지 않는다.
            string sMessage = "안녕하세요";
            Setstring(sMessage); // Setstring 메서드 내에서 문자열을 변환하는 로직.
            MessageBox.Show(sMessage); // 안녕하세요
        }

        void ArrayArgMethod(string[] _sValues)
        {
            // 배열을 인자로 받은 반환형이 없는 메서드

            MessageBox.Show(_sValues[0]);
            txtTitle.Text = _sValues[1];
            lblTitle.Text = _sValues[2];
        }

        void ArrayChangeMethod(string[] _Svalues)
        {
            // 배열을 인자로 받고, 배열을 갱신한 뒤 반환형은 없는 메서드
            MessageBox.Show(_Svalues[0]); // 안녕하세요
            _Svalues[0] = _Svalues[2];
            MessageBox.Show(_Svalues[0]); // C# 프로그래밍
        }

        void Setstring(string sMessage)
        {
            MessageBox.Show(sMessage);
            sMessage = "값을 지웠습니다.";

        }

        #endregion

        #region < 배열을 리턴하는 메서드 > 
        private void btnAryReturn_Click(object sender, EventArgs e)
        {
            // 배열을 반환하는 메서드
            // 1. 배열 인자 생성
            int[] iValues = { 10, 20 };

            // 2. 메서드 호출
            iValues = ArrayReturnMethod(iValues);
            MessageBox.Show($"[0] : {iValues[0]}, [1] : {iValues[1]}");
        }

        int[] ArrayReturnMethod(int[] _iValues)
        {
            // 배열 인수를 일정한 값과 합하는 메서드
            int[] iSumints = { 5, 10 };
            iSumints[0] = iSumints[0] + _iValues[0];
            iSumints[1] += _iValues[1];
            return iSumints;
        }
        #endregion
    }
}
