using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap19_Foreach_Test : Form
    {
        public Chap19_Foreach_Test()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int[,] iValues = new int[3, 4];
            int iCount = 0;

            for (int i = 0; i  < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    iCount++;
                    iValues[i, j] = iCount;
                }
            }

            int iCount2 = 0;
            foreach (int i in iValues)
            {
                iCount2++;

                txtMatrix.Text += i.ToString();

                if (iCount2 % iValues.GetLength(1) == 0)
                {
                    txtMatrix.Text += "\r\n";
                }
            }
        }
    }
}
