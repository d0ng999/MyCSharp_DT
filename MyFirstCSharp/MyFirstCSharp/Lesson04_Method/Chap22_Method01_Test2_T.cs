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
    public partial class Chap22_Method01_Test2_T : Form
    {
        // 총 구매 금액 관리 변수
        int iTotalPrice = 0;

        public Chap22_Method01_Test2_T()
        {
            InitializeComponent();
        }

        void SetFruitSaleCount(Label lbltemp, string sFruitName, int iFruitPrice)
        {
            // 과일별 주문 클릭 메서드(과일 갯수, 과일 이름, 과일 가격)
            int iFruitCount = Convert.ToInt32(lbltemp.Text);

            if (iFruitCount == 0)
            {
                MessageBox.Show($"{sFruitName}의 재고가 0입니다. 주문할 수 없습니다.");
                return;
            }

            lbltemp.Text = (--iFruitCount).ToString();

            iTotalPrice += iFruitPrice;
        }

        private void btnAppleOrder_Click(object sender, EventArgs e)
        {
            // object sender 인자
            // 해당 메서드를 호출하는 컨트롤의 정보를 담고 있다.
            // 이벤트 메서드가 호출될 경우, 사용자가 이벤트를 발생시킨 컨트롤의 정보를
            // 인수로 전달하여 호출된 메서드에서 인자로 컨트롤을 Object 형태로 전달받아 로직을 처리.

            // Tag
            // WinForm의 Control(도구)에 존재하는 Object 형식의 인스턴스 변수.
            // 사용자가 해당 컨트롤에 추가적으로 어떠한 값을 등록하거나 코멘트 또는 데이터를
            // 주고 받을때, 편의성을 제공하도록 일종의 옷 주머니같은 역할을 하는 컨트롤 변수.


            //SetFruitSaleCount(lblAppleCnt, "사과", 2000);

            Button btnTemp = (Button)sender;

            // 클릭한 버튼의 Tag 속성에 있는 과일 이름으로 분기
            SetSwitchFruitSale(btnTemp.Tag.ToString()); 
        }

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"총 결제금액 : {iTotalPrice}원");
        }

        void SetSwitchFruitSale(string sFruitName)
        {
            switch(sFruitName)
            {
                case "사과":
                    SetFruitSaleCount(lblAppleCnt, sFruitName, 2000);
                    break;

                case "참외":
                    SetFruitSaleCount(lblMelonCnt, sFruitName, 2500);
                    break;

                case "수박":
                    SetFruitSaleCount(lblWMCnt, sFruitName, 18000);
                    break;
            }
        }

    }
}
