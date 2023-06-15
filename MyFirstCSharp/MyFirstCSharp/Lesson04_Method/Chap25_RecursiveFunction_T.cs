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
    public partial class Chap25_RecursiveFunction_T : Form
    {
        public Chap25_RecursiveFunction_T()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 리스트를 통한 피보나치 수열의 값 구하기
            int iLoopCount = 0;

            // 리스트의 초기 값 0과 1 등록(피보나치 수열에서 전전 값과, 전 값이 등록되어 보관될 용도)
            List<int> iValues = new List<int>() { 0, 1 };

            // out int iResult 를 생성하면서 out 값까지 받아버리기
            bool bCheck = int.TryParse(txtResult.Text, out int iTurn);

            if (!bCheck)
            {
                return;
            }

            // 입력한 숫자 : iTurn
            if (iTurn > 2) // 입력한 차수가 3이상일 때
            {
                // i : iValues에 등록될 index
                for (int i = 2; i < iTurn; i++)
                {
                    iValues.Add(iValues[i-2] + iValues[i-1]);
                    ++iLoopCount;
                }
                ++iLoopCount;
                MessageBox.Show($"피보나치 수열 {iTurn}번째의 값은 {iValues[iValues.Count - 1]}입니다." +
                    $"총 반복횟수 : {iLoopCount}");
            }
            else
            MessageBox.Show($"피보나치 수열 {iTurn}번째의 값은 {iValues[iTurn-1]}입니다." +
                $"총 반복횟수 : {iLoopCount}");

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 외부 변수를 사용하여 피보나치 수열의 값 구하기
            bool bFlag = false;
            int iValue = 0;
            bFlag = int.TryParse(txtResult.Text, out iValue);

            if (!bFlag)
            {
                MessageBox.Show("숫자를 입력해주세요");
                return;
            }

            int iStart = 0;
            int iEnd = 1;
            int iResult = 0;

            if (iValue > 2)
            {
                for (int i = 1; i < iValue; i++)
                {
                    iStart = iEnd;
                    iEnd = iResult;
                    iResult = iStart + iEnd;
                }
                MessageBox.Show($"{iValue}번째 피보나치 값은 {iResult}");
            }
            else
            {
                MessageBox.Show($"{iValue}번째 피보나치 값은 {iValue - 1}");
            }

        }
        int iLoopCount = 0; // 반복 횟수
        private void btnRecursive_Click(object sender, EventArgs e)
        {
            /* 재귀함수 (Recursive Function)
               메서드 내부에서 자기 자신을 반복적으로 호출하는 것을 말한다.
               * 자신을 호출하는 부분(메서드를 호출하는 로직)을 만나지 않을때까지 반복한다.
               
               - 장점
                . 직관적인 코드를 구현할 수 있으며 복잡한 문제를 쉽게 표현할 수 있다.

               - 단점
                . 호출이 완료되기 전까지 Stack 메모리에 절차 과정이 누적되므로
                  StackOverFlow 오류가 발생할 수 있다.
                . 종료 시점을 명확히 하지 않으면, 무한 루프에 빠질 수 있다.
                . 반복할 노드(횟수)가 많아질수록 효율성이 떨어진다.
                    - 메모이제이션 기법으로 보완이 가능(메모화)
             */

            

            bool bCheck = int.TryParse(txtResult.Text, out int iTurn);

            if (!bCheck)
            {
                return;
            }

            // 반복 수행할 메서드 재귀 메서드를 호출
            int iResult = GetFibonacciNum(iTurn); // 피보나치 순번의 값을 확인하기 위한 재귀 메서드 호출
            MessageBox.Show(iResult.ToString());
        }

        // 재귀 메서드
        int GetFibonacciNum(int _iTurn)
        {
            int iResult = 0; // 최 하단의 값을 찾았을 때, 누적되는 값

            if (_iTurn >= 1 && _iTurn <= 2) // 첫 번째 순번
            {
                // 재귀함수에서는 이 블록 구문이 핵심적인 부분이 된다.
                // 0, 1 값을 찾아내기 위해 이 블록 코드로 진입할 때까지 재귀 함수가 구동
                // 이곳이 호출되는 횟수가 재귀 함수의 총 반복 횟수가 된다.
                iResult = _iTurn - 1;

                ++iLoopCount;
            }
            else if(_iTurn > 2)
            {
                // 결과가 누적될 int 값
                // GetFibonacciNum(_iTurn - 2) + GetFibonacciNum(_iTurn - 1)
                // 왼쪽 함수부터 실행!
                iResult = GetFibonacciNum(_iTurn - 2) + GetFibonacciNum(_iTurn - 1);
            }

            return iResult;
        }

        private void btnMemoization_Click(object sender, EventArgs e)
        {
            // 메모이 제이션
            // 컴퓨터 프로그램이 동일한 연산을 반복해야 할 때
            // 이전에 계산했던 결과를 메모리에 등록해두고, 동일한 계산을 위해 수행해야 하는
            // 반복 횟수를 제거하여 프로그램의 실행 속도를 향상시키는 방법
            // 재귀 함수를 호출하는 횟수를 줄일 수 있도록 등록되어 있는 값을 추가하여
            // 재귀함수 호출 수를 줄이는 방법

            int iLoopCount = 0;

            bool bCheck = int.TryParse(txtResult.Text, out int iTurn);

            if (!bCheck)
            {
                return;
            }

            // 이전 연산의 결과를 등록할 (메모화 할) Dictionary 생성
            Dictionary<int, int> dic = new Dictionary<int, int>()
            {
                // key의 내용 : 회차, 순번
                // value의 내용 : 수열의 결과 값
                [1] = 0,
                [2] = 1
            };

            int iResult = GetFibonacciNum(iTurn, dic); // 재귀함수의 결과 값을 담을 변수
            MessageBox.Show($"피보나치 수열 {iTurn}번째의 값은 {iResult}입니다. 총 반복 횟수 : {iLoopCount}");

        }

        int GetFibonacciNum(int _iTurn, Dictionary<int, int> _Dic)
        {
            if (_Dic.ContainsKey(_iTurn))
            {
                ++iLoopCount;
                return _Dic[_iTurn];
            }
            
            // dic에 해당 순번의 Key가 없을 경우 (기존에 해당 순번에 대해서 찾은 값이 없을 경우)
            // 재귀 함수를 통하여 값이 도출될 때까지 loop반복
            if (_iTurn > 2)
            {
                _Dic[_iTurn] = GetFibonacciNum(_iTurn - 2, _Dic) + GetFibonacciNum(_iTurn - 1, _Dic);
            }
            return _Dic[_iTurn];            
        }
    }
}
