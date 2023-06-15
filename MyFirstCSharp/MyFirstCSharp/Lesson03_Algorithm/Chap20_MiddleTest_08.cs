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
    public partial class Chap20_MiddleTest_08 : Form
    {
        public Chap20_MiddleTest_08()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int[] iValues = { 1, 11, 6, 20, 11, 8, 12, 6, 16, 13, 22 };

            int iValue = 0;

            for (int i = 0; i < iValues.Length; i++)
            {
                for (int j = 0; j < iValues.Length; j++)
                {
                    if (iValues[i] > iValues[j])
                    {
                        iValue = iValues[i];
                        iValues[i] = iValues[j];
                        iValues[j] = iValue;
                    }
                }
            }
                        
            foreach (int i in iValues)
            {
                txtResult.Text += i.ToString() + " ";
            }
        }
    }
}
