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
    public partial class Chap22_Method01_Test : Form
    {
        public Chap22_Method01_Test()
        {
            InitializeComponent();
        }

        private void btnTM_Click(object sender, EventArgs e)
        {
            forUsingMethod(2);
        }

        private void btnFM_Click(object sender, EventArgs e)
        {
            forUsingMethod(5);
        }

        private void btnTenM_Click(object sender, EventArgs e)
        {
            forUsingMethod(10);
        }

        void forUsingMethod(int iValue)
        {
            bool bFlagStart = false;
            bool bFlagEnd = false;
            int iStart = 0;
            bFlagStart = int.TryParse(txtStart.Text, out iStart);
            int iEnd = 0;
            bFlagEnd = int.TryParse(txtEnd.Text, out iEnd);

            if ((bFlagStart && bFlagEnd) && ((iStart >= 0) && (iEnd > iStart)))
            {
                int iSum = 0;

                for (int i = iStart; i <= iEnd; i++)
                {
                    if (i % iValue == 0)
                        iSum += i;
                }

                MessageBox.Show($"{iValue}의 배수의 합은 {iSum}");
            }
            else
                MessageBox.Show("다시");

            
        }
    }
}
