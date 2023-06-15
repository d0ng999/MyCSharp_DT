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
    public partial class Chap17_MatrixTest_T : Form
    {
        public Chap17_MatrixTest_T()
        {
            InitializeComponent();
        }

        private void btnChang_Click(object sender, EventArgs e)
        {
            // 행 역전 배열 생성 및 표현
            int[,] iValues = new int[2, 4] { { 1,2,3,4 },
                                             { 5,6,7,8 } };

            int iRowCount    = iValues.GetLength(0);
            int iColumnCount = iValues.GetLength(1);

            // 역전될 배열이 담길 배열 생성
            int[,] iResults = new int[iRowCount, iColumnCount];

            // 원본 배열의 행을 역으로 거슬러 올라가는 행의 주소 i
            int iResultRowIndex = 0;
            for (int i = iRowCount - 1; i >= 0; i--) 
            {
                for (int j = 0; j < iColumnCount; j++)
                {
                    iResults[iResultRowIndex, j] = iValues[i, j];
                }
                iResultRowIndex++;
            }

        }
    }
}
