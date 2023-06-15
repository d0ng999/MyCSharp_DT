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
    public partial class Chap17_MatrixText : Form
    {
        public Chap17_MatrixText()
        {
            InitializeComponent();
        }

        private void btnMatrix_Click(object sender, EventArgs e)
        {
            int[,] iMatrix = new int[2, 4] { {1, 2, 3, 4 },
                                             {5, 6, 7, 8 } };

            int[,] iMatrixResult = new int[2, 4];

            int iMatrixRowCount = iMatrix.GetLength(0);
            int iMatrixColumnCount = iMatrix.GetLength(1);
            int iCount = 0;
            for (int i = iMatrixRowCount-1; i >=0 ; i--)
            {
                for (int j = 0; j < iMatrixColumnCount; j++)
                {
                    iMatrixResult[iCount, j] = iMatrix[i, j];
                    txtMatrix.Text += iMatrixResult[iCount, j].ToString() + " ";
                }
                txtMatrix.Text += "\r\n";
                iCount++;
            }
        }
    }
}
