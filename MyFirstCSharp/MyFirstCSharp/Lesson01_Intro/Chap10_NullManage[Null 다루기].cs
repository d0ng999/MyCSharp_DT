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
    public partial class Chap10_NullManage : Form
    {
        public Chap10_NullManage()
        {
            InitializeComponent();
        }

        private void btnHasValue_Click(object sender, EventArgs e)
        {
            // 데이터의 값이 Null인지 판단하는 기능!
            int? iValue = null; // 정수형 데이터타입에 null처리가 된다(?를 붙힘으로써)

            // 값이 있을 경우 true / 없는 경우 false
            bool bFlag = iValue.HasValue; 
            MessageBox.Show(Convert.ToString(bFlag));

            //string sValue = null;
            // bFlag = sValue. // 스트링 타입은 HasValue가 없다.
            // 문자 열의 경우, null상태를 허용하는 데이터 타입이므로 굳이 null 상태를 
            // 체크할 필요없다.

        }

        private void btnNullable_Click(object sender, EventArgs e)
        {
            // Null 병합 연산자 -> ?? 사용
            // 데이터 타입의 유형이 null이 처리된 상태인지 판단하는 키워드

            // A ?? B : 만약에 A가 null 상태이면, B를 표현하고
            // Null 상태가 아니면, A를 그대로 표현

            int? iValue = null;

        // iValue ?? -1 : 만약 iValue가 Null 상태라면 -1을 반환, Null이 아니라면 iValue값을 반환
            int iResult = iValue ?? -1;

            MessageBox.Show(iResult.ToString());

            // String 타입의 null 여부판단.!
            string sValue = null;
            MessageBox.Show(sValue ?? "변수가 nul상태입니다");

            sValue = "안녕하세요";
            MessageBox.Show(sValue ?? "변수가 nul상태입니다");

        }



    }
}
