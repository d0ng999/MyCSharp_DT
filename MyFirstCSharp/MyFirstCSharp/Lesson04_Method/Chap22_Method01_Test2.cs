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

    public partial class Chap22_Method01_Test2 : Form
    {
        // 총 구매 금액 관리 변수
        int iTotalPrice = 0;

        public Chap22_Method01_Test2()
        {
            InitializeComponent();
        }

        void SwitchUsingMethod(string sName)
        {
            switch(sName)
            {
                case "사과":
                    int iAppleCnt = Convert.ToInt32(lblAppleCnt.Text);
                    if (iAppleCnt == 0)
                    {
                        MessageBox.Show("사과의 재고 수량이 0개 입니다. 주문 불가");
                        return; // 현재 사과 주문 버튼의 로직을 종료
                    }

                    // 재고 수량 차감
                    //iAppleCnt -= 1;
                    lblAppleCnt.Text = (--iAppleCnt).ToString();

                    // 총 구매금액에 사과금액을 누적!
                    iTotalPrice += 2000;
                break;

                case "참외":
                    // 참외의 현재 재고 수량
                    int iMelonCnt = Convert.ToInt32(lblMelonCnt.Text);

                    if (iMelonCnt == 0)
                    {
                        MessageBox.Show("참외의 재고 수량이 0개 입니다. 주문 불가");
                        return; // 현재 참외 주문 버튼의 로직을 종료
                    }

                    // 참외 재고 차감
                    lblMelonCnt.Text = (--iMelonCnt).ToString();

                    // 참외 주문 금액 누적
                    iTotalPrice += 2500;
                break;

                case "수박":
                    // 수박 주문 클릭 로직
                    int iWMelonCnt = Convert.ToInt32(lblWMCnt.Text);

                    if (iWMelonCnt == 0)
                    {
                        MessageBox.Show("수박의 재고가 없습니다. 주문 불가!");
                        return;
                    }

                    // 수박 재고 차감
                    lblWMCnt.Text = (--iWMelonCnt).ToString();

                    iTotalPrice += 18000;
                break;
            }
        }

        private void btnAppleOrder_Click(object sender, EventArgs e)
        {
            SwitchUsingMethod("사과");
        }

        private void btnMelonOrder_Click(object sender, EventArgs e)
        {
            SwitchUsingMethod("참외");
        }

        private void btnWMOrder_Click(object sender, EventArgs e)
        {
            SwitchUsingMethod("수박");
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 결제금액 : {iTotalPrice}원");
        }
    }
}
