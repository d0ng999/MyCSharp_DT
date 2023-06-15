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
    public partial class Chap20_MiddleTest_04 : Form
    {
        public Chap20_MiddleTest_04()
        {
            InitializeComponent();
        }

        private void btnFindResult_Click(object sender, EventArgs e)
        {
            lblTitle.Text = lblTitle.Text.Replace('{', ' ');
            lblTitle.Text = lblTitle.Text.Replace('}', ' ');
            string[] sText = lblTitle.Text.Split(',');
            int[] iValues = new int[sText.Length];
            int iCount = 0;

            foreach (string iValue in sText)
            {
                iValues[iCount] = Convert.ToInt32(iValue);
                iCount++;
            }

            int[] iArray = new int[iValues.Length];
            int iCnt = 0;

            for (int i = 0; i < iValues.Length; i++)
            {
                for (int j = i+1; j < iValues.Length; j++)
                {

                    if (iValues[i] == iValues[j])
                    {
                        iArray[iCnt] = iValues[i];
                        iCnt++;
                    }
                }
            }
            Array.Sort(iArray);

            int[] iArray2 = new int[iArray.Length];
            int iCnt2 = 0;

            for (int i = 1; i < iArray.Length; i++)
            {

                if (iArray[i] != iArray[i-1])
                {
                    iArray2[iCnt2] = iArray[i];
                    iCnt2++;
                }
            }

            Array.Sort(iArray2);
            int iIndex = 0;
            foreach (int iValue in iArray2)
            {
                if(iValue != 0)
                {
                    iIndex = Array.IndexOf(iArray2, iValue);
                    break;
                }
            }
            MessageBox.Show($"{iArray2[iIndex]} / {iArray2[iIndex+2]}");
        }
    }
}
