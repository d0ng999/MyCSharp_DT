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
    public partial class Chap20_MiddleTest_07 : Form
    {
        public Chap20_MiddleTest_07()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Random rNumber = new Random();
            int[] iValues = new int[20];

            for (int i = 0; i < iValues.Length; i++)
            {
                iValues[i] = rNumber.Next(0, 20);
            }

            Array.Sort(iValues);

            StringBuilder sText = new StringBuilder();
            foreach (int i in iValues)
            {
                sText.Append(i.ToString() + " ");
            }

            txtResult.Text = sText.ToString();

            int iSum = 0;

            for (int i = 1; i <= 20; i++)
            { 
                iSum += i;
            }

            if (iValues[0] != iValues[1])
                iSum -= iValues[0];
            for (int i = 1; i < 20; i++) 
            {
                if (iValues[i] != iValues[i-1])
                    iSum -= iValues[i];
            }

            MessageBox.Show($"결과 값은 {iSum}");
        }
    }
}
