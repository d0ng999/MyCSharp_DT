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
    /*
        * 구조체 - Struct
        * 1. 클래스와 유사한 구조를 가지고 있지만, 속성과 구현 방법이 다르다.
        * 
        * 2. 데이터 처리 방식
        *    Struct : Valuetype (값 형식)
        *    Class  : Reference (참조 형식)
        *    
        *  * 구조체의 장점 : 메모리 비용이 클래스보다 상대적으로 작다.
        *   . 참조 형식 : Heap, Stack, 참조 주소 저장, 메모리 비용이 발생
        *   
        * 3. 지역변수 (메서드 내부에서) 선언되어 사용될 경우, 스택 영역에 할당
        *    전역변수(필드 멤버)로서 선언될 경우, 클래스와 함께 Heap 영역에 할당이 된다. 
        * 
        * 4. 사용자 정의 데이터 타입을 만들어 사용할 수 있다.
        * 
        * 5. 상속이 불가능하다.
        * 
        * 6. 단순한 데이터 관리에 용이하다.
    */

    // 구조체 생성
    struct Color
    {
        public string Red { get; set; }
        public string Yellow { get; set; }
        public string Blue { get; set; }

        // 1. 생성자를 만들수 있다.

        // 인자 자 없는 생성자는 생성을 할 수 없다.
        //public Color()
        //{

        //}

        public Color(string red, string yellow, string blue)
        {
            // 생성자를 만들면 반드시 필드 멤버에 있는 요소 를 초기화 해 주어야 한다. 
            Red = red;
            Yellow = yellow;
            Blue = blue;
        }

        // 메서드에 대한 OverLoading 이 가능
        public Color(string red, string yellow)
        {
            Red = red;
            Yellow = yellow;
            Blue = "블루";

            // 인자와는 관계없이 생성자 에서 모든 필드 멤버를 초기화 해야한다.
        }

        void GetValue()
        {
            // 구조체 안의 일반 메서드 작성 가능.
        }
    }

    public partial class Chap33_Struct : Form
    {
        // -- 구조체 선언(클래스와 함께 Heap)

        public Chap33_Struct()
        {
            InitializeComponent();
            // -- 구조체 선언(Stack)
        }

        private void btnStruct_Click(object sender, EventArgs e)
        {
            Color MyColor = new Color("빨강", "노랑", "블루");

            // 원래 클래스의 경우, 얕은 복사 형태(참조)이지만,
            Color MyColor2 = MyColor; // 값이 전달이 된다. -> 깊은 복사
            MyColor2.Red = "RED"; // 복사를 받은 구조체의 red에 데이터 변경

            // 원본 구조체의 Red의 값
            MessageBox.Show(MyColor.Red);

            // 값 형식이므로 데이터를 참조 전달하는 방법?
            SetColor(ref MyColor);
        }

        private void SetColor(ref Color _Color)
        {
            _Color.Red = "RED";
        }
    }
}
