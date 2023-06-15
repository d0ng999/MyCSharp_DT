using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    public partial class Chap20_MiddleTest_02 : Form
    {
        Stopwatch stopWatch = new Stopwatch();
            
        public Chap20_MiddleTest_02()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int[,] iValues = { { 1, 4, 6, 9, 10, 12, 16 },
                               { 2, 7, 11, 13, 14, 15, 18 } };

            string sText = string.Empty;
            stopWatch.Start();
            foreach (int iValue1 in iValues)
            {
                if (!(iValue1 > 10))
                    foreach (int iValue2 in iValues)
                    {
                        if ((iValue1 + iValue2 == 20) && (iValue1 != iValue2))
                        sText += $"{{{iValue1}, {iValue2}}}\r\n";
                    }
            }
            stopWatch.Stop();
            MessageBox.Show(sText.ToString());
            MessageBox.Show(stopWatch.ElapsedMilliseconds.ToString());

        }
    }
}