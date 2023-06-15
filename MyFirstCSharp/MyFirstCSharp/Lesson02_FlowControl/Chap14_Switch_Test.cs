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
    public partial class Chap14_Switch_Test : Form
    {
        int iTotalPrice = 0;
        int iAppleCnt = 10;
        int iMelonCnt = 10;
        int iWMelonCnt = 10;

        public Chap14_Switch_Test()
        {
            InitializeComponent();
        }

        private void btnAppleOrder_Click(object sender, EventArgs e)
        {
            if (iAppleCnt == 0)
            {
                MessageBox.Show("재고가 없어서 주문할 수 없습니다.");
                iAppleCnt = 0;
            }
            else
            {
                iTotalPrice += 2000;
                --iAppleCnt;
            }
            lblAppleCnt.Text = Convert.ToString(iAppleCnt);
        }

        private void btnMelonOrder_Click(object sender, EventArgs e)
        {
            if (iMelonCnt == 0)
            {
                MessageBox.Show("재고가 없어서 주문할 수 없습니다.");
                iMelonCnt = 0;
            }
            else
            {
                iTotalPrice += 2500;
                --iMelonCnt;
            }
            lblMelonCnt.Text = Convert.ToString(iMelonCnt);
        }

        private void btnWMelonOrder_Click(object sender, EventArgs e)
        {
            if (iWMelonCnt == 0)
            {
                MessageBox.Show("재고가 없어서 주문할 수 없습니다.");
                iWMelonCnt = 0;
            }
            else
            {
                iTotalPrice += 18000;
                --iWMelonCnt;
            }
            lblWMelonCnt.Text = Convert.ToString(iWMelonCnt);
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{iTotalPrice}원");
        }
    }
}
