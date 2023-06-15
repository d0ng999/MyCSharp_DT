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
    public partial class Chap16_Loop_For : Form
    {
        // 반복문
        // 특정한 조건을 만족할 때까지 반복하여 동일한 로직을 실행하는 문법
        public Chap16_Loop_For()
        {
            InitializeComponent();
        }

        private void btnForSum_Click(object sender, EventArgs e)
        {
            // 1부터 100까지 합하는 로직

            // 1. 누적 값이 저장되는 변수
            int iSumValue = 0;

            // 1부터 100까지 반복
            // i : 반복하면서 조건을 만족시킬 변수
            //     반복문을 종료할 수 있는 변수.
            // int i = 0; : int형 변수 i가 0이라는 값을 가지고 시작한다.
            // i <= 100   : 참인 조건인지 판단하는 구문(해당 조건에 만족하면 true)
            // i++        : 후위 증가 연산자
            //              다음 조건을 비교하기 위하여 증가하는 구문
            for (int i = 0; i <= 100; i++)
            {
                iSumValue += i;
            }
            MessageBox.Show(iSumValue.ToString());
        }

        private void btnArraySum_Click(object sender, EventArgs e)
        {
            // 배열의 데이터 수 만큼 for 문으로 반복 후 배열의 값 더하기

            // 1. 임의의 배열의 값 등록(배열에 포함된 데이터의 갯수 및 값을 모른다고 가정)
            int[] iValues = { 10, 20, 30, 40, 50, 60, 70 };

            // 2. for문을 통하여 iValues 배열에 있는 모든 값을 더하기
            int iSumValue = 0;

            // int i: 배열의 인덱스 값으로 사용될 값
            for (int i = 0; i < iValues.Length; i++)
            {
                if (iValues[i] >= 40)
                {
                    if (iValues[i] == 50)
                    {
                        break;
                    }
                    continue;
                }
                
                iSumValue += iValues[i];
            }
             MessageBox.Show(iSumValue.ToString());
        }

        private void btnGuGu_Click(object sender, EventArgs e)
        {
            int[] iGuGu = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 1; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    txtGuGu.Text += $"{iGuGu[i]} * {iGuGu[j]} = {iGuGu[i] * iGuGu[j]}\t";
                }
                txtGuGu.Text += "\r\n" + "\r\n";
            }
        }

        private void btnImmutable_Click(object sender, EventArgs e)
        {
            // 값 형식의 타입
            // Immutable 타입(string)과 Mutable 타입(int)이 있다.
            // Immutable 타입은 저장되는 주소값만 늘어나서 데이터가 증가하는 방식
            // 누적되기 전의 데이터가 사라지지 않는 방식
            //2 * 1 = 2   //2 * 1 = 2  //2 * 1 = 2
            //1번      //2 * 2 = 4  //2 * 2 = 4
            // 2번     //2 * 3 = 6 
            // 3번
            // 데이터가 누적될 때, 불필요한 메모리 공간이 많이 소비되므로
            // 비효율적인 코딩이 될 수 있다.
            // StringBuilder를 사용하는 것이 좋다(강추)

            StringBuilder sBuilder = new StringBuilder(); // 객체 생성(생성자)
            // 1부터 100까지 이러 붙히는 로직
            // string으로만 데이터를 누적시키면 반복문 횟수만큼의
            // 메모리(아래의 경우 : 총 100개의 메모리)를 잡아먹는다
            for (int i = 1; i <= 101; i++)
            {
                sBuilder.Append(i.ToString() + "\r\n");
            }

            MessageBox.Show(sBuilder.ToString());

            sBuilder.Clear(); // 내용삭제
        }
    }
}
