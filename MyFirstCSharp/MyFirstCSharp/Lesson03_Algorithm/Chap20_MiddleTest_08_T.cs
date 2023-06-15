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
    public partial class Chap20_MiddleTest_08_T : Form
    {
        public Chap20_MiddleTest_08_T()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 버블 정렬 내림차순
            int[] iValues = { 1, 11, 6, 20, 11, 8, 12, 6, 16, 13, 22 };

            // 바뀔 값이 임시로 저장될 변수
            int iChangeValue = 0;

            // i : 배열에서 기준 값을 설정할 Index
            for (int i = 0; i < iValues.Length; i++)
            {
                // k : 현재 기준값 이후에 배열되어있는 데이터의 Index
                for (int k = i+1; k < iValues.Length; k++)
                {
                    if (iValues[i] < iValues[k])
                    {
                        // 기준값보다 큰 수를 찾았을 때
                        // 1. 임시 변수에 바뀔 데이터 등록
                        iChangeValue = iValues[i];

                        // 2. 현재 기준 index에 큰 값 index(k)의 데이터 등록
                        iValues[i] = iValues[k];

                        // 3. 현재 기준값 i의 데이터를 큰 값 k의 위치에 등록
                        iValues[k] = iChangeValue;
                    }
                }
            }
            // 내림차순 결과를 textbox에 표현
            foreach (int iValue in iValues)
            {
                txtResult.Text += iValue + " ";
            }
        }
    }
}
