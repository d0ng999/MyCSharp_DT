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
    public partial class Chap11_BranchingStatement : Form
    {
        // 분기문
        // 프로그램 흐름의 조건에 따라 여러 갈래로 나누는 흐름제어 구문
        // 비교연산자로 ==, !=, <=, >= , &&, ||을 사용한다.
        public Chap11_BranchingStatement()
        {
            InitializeComponent();
        }

        private void btnIF_Click(object sender, EventArgs e)
        {
            // 텍스트 박스에 입력한 값이 없을 경우, "아무값도 없습니다."라는 메시지 표현
            // 있을 경우, 해당 텍스트 값을 메시지로 표현

            // 텍스트 박스에 입력한 값을 변수에 담기
            string sValue = txtBS.Text;
            if (sValue == "")
            {
                // true
                MessageBox.Show("아무값도 없습니다.");
            }
            else
            {
                MessageBox.Show(sValue);
            }
        }

        private void btnInIf_Click(object sender, EventArgs e)
        {
            /*
            만약에 텍스트 박스에 입력한 값이 
            1일 때는 "분기문 1 실행" 메세지
            2일 때는 "분기문 2 실행" 메세지
            3일 때는 "분기문 3 실행" 메세지

            아무 값도 입력하지 않은 경우 "값을 입력하세요" 메세지

            그리고 값은 있는데 1, 2, 3이 아닐 경우 "적절한 분기문이 없습니다." 메세지
            */

            // 텍스트 박스에 입력한 값 받아오기!
            string sTextValue = txtBS.Text;

            // 먼저 입력한 값이 없을 경우를 걸러내는 분기문을 바깥쪽에 작성

            if (sTextValue == "")
            {
                MessageBox.Show("값을 입력하세요.");
            }
            else
            {
                if (sTextValue == "1")
                {
                    MessageBox.Show("분기문 1 실행");
                }
                else if (sTextValue == "2")
                {
                    MessageBox.Show("분기문 2 실행");
                }
                else if (sTextValue == "3")
                {
                    MessageBox.Show("분기문 3 실행");
                }
                else
                {
                    MessageBox.Show("적절한 분기문이 없습니다.");
                }    
            } 

            // 마지막의 else는 3번 분기문을 만족시키지 못할 경우인 예외인 경우 결과 로직이다.
            // 1, 2를 입력하였을 경우
            // "1번, 2번 분기문 실행"이라는 메세지를 표현하고,
            // 3이 아니기 때문에 적절한 분기문이 없습니다. 표현!
            // 예상한 시나리오대로 동작하지 않는 로직

            // 1,2,3,else?
        }

        private void btnElseIF_Click(object sender, EventArgs e)
        {
            // else if
            // if문과 다음 if 문을 하나의 흐름으로 만들어 준다.
            // if, else if를 만족시키는 조건을 하나라도 수행하면 흐름을 종료
            // 모두 거짓인 상태일 경우에만 else 로직을 수행

            // 위의 시나리오 그대로 사용함

            string sValue = txtBS.Text;

            // 값을 입력하지 않은 경우
            if (sValue == "")
            {
                MessageBox.Show("값을 입력하세요.");
            }
            else if (sValue == "1")
            {
                MessageBox.Show("분기문 1 실행");
            }
            else if (sValue == "2")
            {
                MessageBox.Show("분기문 2 실행");
            }
            else if (sValue == "3")
            {
                MessageBox.Show("분기문 3 실행");
            }
            else
            {
                MessageBox.Show("해당 분기문이 없습니다.");
            }
        }

        private void btnAndIf_Click(object sender, EventArgs e)
        {
            // && : 모든 조건을 만족시킬 경우에만 참

            string sValue = txtBS.Text;

            if (sValue == "1" && sValue == "2" && sValue == "3")
            {
                MessageBox.Show($"{sValue}번 분기문 실행");
            }
            else if (sValue == "")
            {
                MessageBox.Show("값을 입력하세요.");
            }
            else
            {
                MessageBox.Show("적절한 분기문이 없습니당");
            }
        }

        private void btnOrIf_Click(object sender, EventArgs e)
        {
            // || : 여러 조건 중 하나라도 참일 경우 -> true

            string sValue = txtBS.Text;

            if (sValue == "1" || sValue == "2" || sValue == "3")
            {
                MessageBox.Show($"{sValue}번 분기문 실행");
            }
            else if (sValue == "")
            {
                MessageBox.Show("값을 입력하세요.");
            }
            else
            {
                MessageBox.Show("적절한 분기문이 없습니당");
            }
        }

        private void btnBoolIf_Click(object sender, EventArgs e)
        {
            // 분기문의 외부 변수를 이용하여 분기 흐름 제어하기
            // bool 데이터 변수에 데이터가 담긴 결과로 흐름을 판단하는 로직

            // 1. 입력한 값 받아오기
            string sValue = txtBS.Text;

            // 2. 분기 흐름 제어를 위한 외부 bool 변수 생성
            bool bFlag = false; // 기본값은 False

            // 3. 첫 번째 분기 흐름 생성
            if (sValue == "1" || sValue == "2" || sValue == "3")
            {
                bFlag = true;
                // 리턴을 안 받고 아래의 if문으로 내려감
            }
            else if (sValue == "")
            {
                MessageBox.Show("값을 입력하세요");
                //bFlag = true; 라고 해주면 아래의 if문을 타지 않을 것이다. 하지만 이는 한계가 있다.
                return; // 메서드 종료를 의미
            }

            // 4. 두 번째 분기 흐름 생성하기
            // bFlag의 참/거짓에 따른 분기 흐름.
            // !bFlag => False

            // 아래의 두 분기문은 같은 분기문이다.
            if (!bFlag) // 실무에서 자주 쓰이는 구문
            {
                // 1, 2, 3을 입력하지 않은 경우
                MessageBox.Show("적절한 분기문이 없습니다.");
            }
            else // 1,2,3 값을 입력한 경우
            {
                MessageBox.Show($"{sValue}번 분기문 실행");
            }
            //if (bFlag == false)
            //{

            //}

            if (bFlag) // 실무에서 자주 쓰이는 구문
            {

            }
            //if (bFlag == true)
            //{

            //}
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            // 입력한 값이 음수인지 양수인지 판단

            string sValue = txtBS.Text;

            // 정수 데이터 변수 생성
            int iResult = 0;

            // 입력받은 값을 숫자로 변환할 수 있는지 확인하는 bool 변수
            bool bFlag = false;

            // 입력문자를 숫자로 변환 후, iResult에 담고 성공여부를 bFlag에 담기
            bFlag = int.TryParse(sValue, out iResult);

            // 벨리데이션 체크
            // 개발자가 프로그램 개발 시 오류 사항이 발생할 수 있는 로직을 예상하고,
            // 오류 상황이 발생할 수 있는 로직을 처리하기 전에 에러 메세지를
            // 사용자에게 전달해줌으로써 시스템 오류를 발생시키지 않으면서
            // 프로그램에 대한 신뢰도를 높이는 개발 방법.
            // 사용자에게 정확한 사용 방법을 알리면서 올바르게 프로그램을 사용할 수 있도록 유도!

            if (!bFlag)
            {
                MessageBox.Show("음수 양수 판단을 할 수 없습니다.");
                return;
            }

            // 음수 / 양수를 판단하는 로직
            if (iResult > 0)
            {
                MessageBox.Show("양수입니당");
            }
            else if(iResult < 0)
            {
                MessageBox.Show("음수입니다");
            }
            else
            {
                MessageBox.Show("0입니다.");
            }
        }

        private void btnOddEven_Click(object sender, EventArgs e)
        {
            string sValue = txtBS.Text;

            int iResult = 0;
            bool bFlag = false;
            bFlag = int.TryParse(sValue, out iResult);

            if (! bFlag)
            {
                MessageBox.Show("숫자를 입력해주세요");
                return;
            }

            if (iResult == 0)
            {
                MessageBox.Show("0입니다.");
            }
            else if (iResult % 2 == 0)
            {
                MessageBox.Show("짝수입니다.");
            }
            else
            {
                MessageBox.Show("홀수입니다.");
            }
        }

        private void btnTernaryOperator_Click(object sender, EventArgs e)
        {
            // 삼항 연산자
            // 피연산자의 개수가 3개인 조건부 연산자
            // if - else 구문을 한 줄로 간단하게 표현할 수 있기 때문에 IN-LINE If문이라고도 한다.

            // 홀수/짝수 코드를 삼항 연산자로 만들어보기
            string sValue = txtBS.Text;

            int iResult = 0;
            bool bFlag = false;
            bFlag = int.TryParse(sValue, out iResult);

            if (!bFlag)
            {
                MessageBox.Show("숫자를 입력해주세요");
                return;
            }

            // 결과를 받을 string 변수
            string sResult = string.Empty; // Empty = "" 와 같다.

            sResult = (iResult % 2 == 0) ? ((iResult == 0) ? "0입니다.": "짝수입니다.") : "홀수입니다.";
            //         iResult가 짝수이면        true      ?    true   :     false      :    false
            MessageBox.Show(sResult);

            MessageBox.Show((iResult % 2 == 0) ? "짝수입니다" : "홀수입니다");

            int iValue = 10;
            string sValue1 = string.Empty;
            sValue1 = (iValue % 2 == 0) ? (sValue1 = "짝수입니다.") : (sValue1 = "홀수 입니다.");
            MessageBox.Show(sValue1);
        }
    }
}
