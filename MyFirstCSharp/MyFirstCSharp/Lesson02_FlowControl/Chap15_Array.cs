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
    public partial class Chap15_Array : Form
    {
        // Array(배열 : 참조형식, 배열의 이름은 Stack에 값은 Heap에 저장된다)
        // -- 같은 데이터 타입의 여러 데이터가 하나의 배열 변수 이름으로 나열된 데이터 형식

        // 파이썬과는 다름
        // C#에서 배열은 반드시 방의 개수를 지정하여 생성하거나, ex) new int[5]
        // 배열의 나열될 값들의 개수가 명시되어야 한다. ex) Split('/')
        public Chap15_Array()
        {
            InitializeComponent();
        }

        private void btnArrayF_Click(object sender, EventArgs e)
        {
            // 1. 여러가지 배열의 초기화 방법

            // 1-1. 배열의 방의 개수
            int[] iValues = new int[6];

            // 1-2. 배열의 방의 개수와 값을 바로 등록
            int[] iValues2 = new int[3] { 0, 1, 2 };

            // 배열의 개수 지정없이 값을 바로 등록
            int[] iValues3 = new int[] { 10, 20, 30 };

            // new int[] 키워드 없이 값을 바로 등록 가능
            int[] iValues4 = { 2, 3, 4 };

            // 반환 형태가 배열인 기능(메서드)를 이용하여 배열을 등록
            string[] sValues = "ABCDE-FGHIJK-LMNOPQRSTU".Split('-');

            // 기존에 생성되어 있는 배열의 방 갯수만큼 빈 배열만들기
            int[] iValues5 = new int[sValues.Length];



            // 2. C#에서 배열을 관리할 때 사용되는 주요 기능.

            int[] iExamArray = {10, 30, 60, 50, 20};
            
            // 배열의 정렬(오름차순)
            Array.Sort(iExamArray); // 오름차순으로 정렬이 된다.
            Console.WriteLine(iExamArray);

            // 배열의 정렬(내림차순)
            Array.Reverse(iValues); // 내림차순으로 정렬이 된다.

            // 배열의 값을 하나의 문자열로 표현
            string sExamValue = string.Empty; // 배열의 값을 하나로 담을 변수

            // string.Join(A, B) : 배열을 조합하는데 A에는 어떻게 구분을 시켜서 조인을 해줄껀지
            // B는 어떤 배열인지
            sExamValue = string.Join(" / ", iExamArray);
            MessageBox.Show(sExamValue);

            // 배열의 데이터를 모두 삭제할 때(단, 방은 그대로 두고 데이터만 삭제)
            // Array.Clear(iExamArray, 0, iExamArray.Length); // 배열의 모든 데이터를 삭제하기 위한 길이값 
            // Array.Clear(A, B, C) : A에는 배열, B에는 시작 인덱스 숫자, C에는 시작부터의 길이값

            // 배열의 복사
            // () : 캐스팅 - 강제로 형변환을 하는 기능
            //               변환되어야 하는 대상이 명확할 경우에만 사용
            // .Clone()은 데이터 타입이 object라서 모든 타입을 다 담을 수 있지만, 형식을 바꿔주기
            // 위해서는 (데이터 타입[])을 복사해줄 배열 앞에 적어주어야한다.

            // 깊은 복사 방법
            // 참조
            object oValues = iExamArray.Clone();
            int[] iBackUps = (int[]) oValues;
            // int[] iBackUps = (int[])iExamArray.Clone(); // 위와 같음


        }

        private void btnArrayCopy_Click(object sender, EventArgs e)
        {
            // 값 형식과 참조 형식의 복사

            #region < 값 형식의 복사 방법 >
            int iValue = 10;
            int iValue2 = iValue;

            MessageBox.Show(iValue.ToString());
            iValue2 = 20;
            MessageBox.Show(iValue.ToString());

            // int 데이터타입은 값 형식으로 복사를 할 경우, 해당 값을 직접 전달하여 복사된다.
            #endregion

            #region < 참조 형식의 복사 - 배열편 >
            // 배열을 복사 - 참조형 복사여서 데이터가 가지고 있는 주소값만 전달해준다.
            // 배열은 참조형식이라서 배열이라는 공간은 스택에 보관되지만, 배열의 데이터 값은 힙에 저장된다.
            // 참조형식이라는 것은 배열이 힙에 저장된 데이터의 주솟값을 참조하는 것을 말하고,
            // 배열을 다른 배열에 복사를 해도 데이터의 주소값을 복사해가는 개념이라서
            // 복사한 배열의 데이터 값을 변경하면, 기존 배열의 데이터 값도 변경이 된다.
            int[] iValues1 = { 10, 20, 30, 40, 50 };
            int[] iValues2 = iValues1;

            MessageBox.Show(iValues1[0].ToString()); // 10
            iValues2[0] = 333;

            MessageBox.Show(iValues1[0].ToString());

            // 얕은 복사
            // 참조 형식의 데이터를 복사할 때, 값이 저장된 위치 정보만 전달해주는 복사 방법
            #endregion
        }
    }
}
