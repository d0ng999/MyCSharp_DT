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
    public partial class Chap03_DataTypeConversion : Form
    {
        // 데이터 타입의 형 변환 (숫자 -> 문자)
        // 문자열로 데이터 타입을 변경 : .ToString(), Convert.ToString()

        // 데이터 타입의 형 변환 (문자 -> 숫자)
        // 숫자를 문자열 타입으로 변경 : .Parse(), Convert.ToInt32()

        // 명시적 형변환
        // 변경할 데이터 타입을 지정 후 변환
        // .ToString(), Convert.ToString()(채택)
        // .Parse(), Convert.ToInt32()

        public Chap03_DataTypeConversion()
        {
            InitializeComponent();
        }

        private void btnItoS_Click(object sender, EventArgs e)
        {
            // 디버깅
            // 프로그램 개발 시, 오류 내역을 검출하거나, 프로그램의 로직이 실행되는 각 단위별로
            // 결과를 확인할 수 있도록 하는 프로그램밍 방법 중 하나!
            // F5 : 다음 브레이크 포인트가 걸릴 때까지 실행
            // F9 : 브레이크 포인트 생성(커서가 있는 줄에)
            // F10 : 한 단계씩 실행

            // Break Point = 빨간점 : 로직이 실행될 때, 이 점에서 멈춰서 디버깅이 시작되는 시점
            // 왼쪽 음영색 라인 클릭, F9

            // 숫자를 문자로 변환하는 기능알아보기!

            // 1. 변환될 대상 숫자를 담을 변수 생성 및 초기화
            // 초기화할 때 또는 대입할 때 대입되는 대상(리터럴)
            int iValue  = 10;
            int iValue2 = 20;

            double dValue = 10.1;
            double dValue2 = 20.5;

            // 2. 변형된 데이터 타입이 담길 문자변수 생성
            string sValue1;
            string sValue2;

            // iValue의 데이터 타입 int의 기능 중
            // .ToString() 이라는 기능을 사용하여 숫자를 문자로 변형하여 대입한다.
            // .ToString() : 숫자인 int, double등의 데이터 타입형태를 string형태로 바꾸어주는 기능
            sValue1 = iValue.ToString();

            // 4. 메세지 박스로 변형된 문자형 숫자를 표현
            // MessageBox -> 클래스, Show -> 클래스에 속한 메서드
            MessageBox.Show(sValue1);

            // sValue2에 dValue2을 대입(sValue2를 문자열로 초기화)
            // .ToString은 실무에서는 왠만해서는 잘 안쓴다.
            sValue2 = dValue2.ToString();

            // 문자열로 변환하는 기능 2번째
            // Convert라는 클래스에 있는 메서드인 .ToString(object 타입)을 사용한다.
            // Convert.ToString()의 기능은 결과적으로는 .ToString()과 같은 결과를 생성하지만, 
        // null 처리의 오류 반환때문에, .ToString() 보다는 Convert.ToString() 형식을 사용하는 것을 추천(강추)
            sValue2 = Convert.ToString(dValue2);
            // Convert.ToString()을 사용하는 이유는 null값 때문이다.
            // .ToString()의 경우, null 값을 반환못하지만, Convert는 가능함


            // 문자열의 합(연관되는 문자열을 이어서 표현)
            // sValue1 : "10", sValue2 : "20.5"
            string sValue3 = sValue1 + sValue2;
            MessageBox.Show(sValue3); // 1020.5가 나온당
        }

        private void btnStoI_Click(object sender, EventArgs e)
        {
            // 문자를 숫자로 변경하는 로직
            // 1. 숫자로 바꿀 문자열 변수 생성

            string sValue1 = "안녕하세요";
            string sValue2 = "10";
            string sValue3 = "10.1";

            // 2. .Parse()기능을 통한 변환 : 문자를 숫자로 변환해준다.
            int iResult = 0; // 변환 결과를 담을 int 변수
            

            // 런타임 오류가 발생, sValue1가 문자열이지만, int로는 바꿀 수 없는 문자열("안녕하세요").
            // iResult = int.Parse(sValue1); 

            // 숫자로 변환할 수 있는 문자일 경우, 오류없이 변환이 완료
            iResult = int.Parse(sValue2);

            // 3. Convert.ToInt32()
            // 문자 -> 숫자, 숫자로 바꿀 수 없는 문자일 경우 시스템 오류가 발생
            // iResult = Convert.ToInt32(sValue1); // "안녕하세요"가 숫자로 바뀔 수 없으므로 오류를 반환한다.

            // 4. 숫자로 변환할 수 있는 문자인지 검증하는 메서드 - true || false를 반환(bool형 타입)
            // 반환되는 bool형이 false라면, 반환되는 결과값이 0으로 반환된다.
            // int.TryParse(문자열, 반환되는 int형 결과값)
            // : 이 메서드를 쓰면, 런타임 오류를 발생시키지 않고 안정적으로 결과값을 반환할 수 있다.

            // bResult = false -> iResult = 0 | 실패한 경우 : sValue1이 "안녕하세요"라는 문자열로 int로 변환x
            bool bResult = int.TryParse(sValue1, out iResult);

            // bResult = false -> iResult = 0 | 실패한 경우 : sValue3은 "10.1"로 실수값이므로 int로 변환x
            bResult = int.TryParse(sValue3, out iResult);

            // 소수형 실수 문자열을 실수 데이터 타입으로 형변환 및 결과 검출
            double dResult = 0; // 소수 형변환 결과를 받을 변수
            // bResult = true -> iResult = 10.1 | 성공한 경우
            bResult = double.TryParse(sValue3, out dResult);


            // 정수형 문자를 실수 데이터 타입으로 형변환하는 경우
            // 정수는 실수에 포함되어 있어서 가능(반대는 불가능)
            // bResult = true -> iResult = 10 | 성공한 경우
            bResult = double.TryParse(sValue2, out dResult);
            MessageBox.Show(Convert.ToString(dResult));
            

            /* 문자를 숫자로 형변환할 경우 : .Parse()와 Convert.ToInt32()로 사용할 수 있지만
            변환할 수 없는 유령의 문자인 경우 런타임 오류가 발생한다.
            그래서 .TryParse() 기능을 사용하여 형변환하는 것을 추천!
            이걸 사용하면 오류발생이 안되고, 불형으로 true | false로 이루어지고, 반환이 되지 않는 경우
            false를 반환하면서 실패한 것을 나타내고, 반환값으로는 0을
            반환이 되면, true를 반환하면서 성공을 의미하고, 반환값을 숫자형으로 반환된다. */
        }

        private void btnNull_Click(object sender, EventArgs e)
        {
            /* 
            Null 상태의 변환 처리
            - Convert.ToString() 구문을 사용 시, Null 처리된 값이 있을 경우 빈 값을 반환
            
            - Null
            -> 데이터의 용량(메모리)가 할당되지 않은 상태
            -> "" : 아무런 값이 없는 값이 할당된 상태

            : 숫자형 데이터 타입은 ? 키워드를 추가하여 null 상태로 만들 수 있다.


            */

            string sValue = null;
            // MessageBox.Show(sValue.ToString()); // sValue가 null 처리 되었으므로 오류가 발생(런타임 오류)

            string sValue2 = "";
            // sValue2는 아무런 값이 없는 메모리가 있는 값!!
            MessageBox.Show(Convert.ToString(sValue2));

            // 숫자 데이터를 null처리 하는 방법
            // 데이터 타입 바로 뒤에 ?를 붙혀준다. -> null을 받을 수 있는 자료구조가 됨!
            // Convert.ToString() 과 .ToString() 형식으로 null을 반환할 수 있다.(결과는 ""와 같음)
            int? iValue = null;
            MessageBox.Show(iValue.ToString()); // ""와 같은 결과값이 나온다.
            MessageBox.Show(Convert.ToString(iValue)); // ""와 같은 결과값이 나온다.

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            // 문자열의 합과 숫자의 합
            string sValue1 = "ABC";
            string sValue2 = "DEF";

            string sValue3 = sValue1 + sValue2;

            MessageBox.Show(sValue3); // ABCDEF

            int iValue1 = 50;
            int iValue2 = 30;

            int iValue3 = iValue1 + iValue2;

            MessageBox.Show(Convert.ToString(iValue3)); // 80
        }
    }
}
