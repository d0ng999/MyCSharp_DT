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
    public partial class Chap13_Switch : Form
    {
        // Switch, case, break, default (switch의 포멧)
        // If 문과 함께 자주 사용되는 분기문
        // 많은 분기를 제어할 경우, if문 보다 깔끔하게 로직을 표현할 수 있다.

        public Chap13_Switch()
        {
            InitializeComponent();
        }

        private void btnIf_Click(object sender, EventArgs e)
        {
            // if문으로 과일 이름과 가격 나타내기

            // 1. 변수 설정
            string sFruitName = txtFruit.Text; // 과일 이름
            int iFruitPrice = 0;               // 과일 가격

            if (sFruitName == "사과")
            {
                iFruitPrice = 2000;
            }
            else if (sFruitName == "복숭아")
            {
                iFruitPrice = 2000;
            }
            else if (sFruitName == "참외")
            {
                iFruitPrice = 2500;
            }
            else if (sFruitName == "딸기")
            {
                iFruitPrice = 18000;
            }
            else if (sFruitName == "수박")
            {
                iFruitPrice = 18000;
            }
            //else // iFruitPrice가 이미 0으로 초기화되어 있어서 없어도 되는 구문이다.
            //{
            //    // 취급하는 과일을 입력하지 않은 경우
            //    iFruitPrice = 0;
            //}

            if (iFruitPrice == 0)
            {
                MessageBox.Show("취급하지 않는 과일입니다.");
            }
            else
            {
                MessageBox.Show($"{sFruitName}의 가격은 {iFruitPrice}원 입니다.");
            }
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            // switch를 통한 과일 이름과 가격 찾기.

            // 입력한 과일 이름 변수 등록
            string sFruitName = txtFruit.Text;
            int iFruitPrice = 0;
            
            switch(sFruitName) // switch() 소가로 안에는 비교가 될 대상이 들어와야 한다.
            {
                case "복숭아":
                case "사과":
                    iFruitPrice = 2000;
                break;

                case "참외":
                    iFruitPrice = 2500;
                break;

                case "딸기":
                case "수박":
                    iFruitPrice = 18000;
                break;
            }

            if (iFruitPrice == 0)
            {
                MessageBox.Show("취급하지 않는 과일입니다.");
            }
            else
            {
                MessageBox.Show($"{sFruitName}의 가격은 {iFruitPrice}원 입니다.");
            }
        }
    }
}
