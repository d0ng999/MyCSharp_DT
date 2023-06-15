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
    public partial class Chap04_DataType_ConvTest : Form
    {
        public Chap04_DataType_ConvTest()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            // 텍스트 박스 두 수의 합을 구해서 메세지로 표현하기!

            // 1. 텍스트 박스에 입력된 값을 가져오기
            // txtFirstValue 값을 변수에 담기
            string sFirstValue;
            sFirstValue = txtFirstValue.Text;

            // txtSecValue 값을 변수에 담기
            string sSecValue;
            sSecValue = txtSecValue.Text;

            // 2. 입력받은 값을 정수로 변환

            // 왼쪽 텍스트 박스의 값을 정수로 담을 int 변수 만들기
            int iFirstValue = 0;
            int.TryParse(sFirstValue, out iFirstValue);

            // 오른쪽 텍스트 박스의 값을 정수로 담을 int 변수 만들기
            int iSecValue = 0;
            int.TryParse(sSecValue, out iSecValue);

            // 3. 두 수 합치기
            int iResult = 0; // 결과 int 변수
            iResult = iFirstValue + iSecValue;

            // 4. 합친 결과 표현하기
            string sResult; // 합친 결과를 문자로 담을 변수
            sResult = Convert.ToString(iResult);
            MessageBox.Show(sResult);

            // 4의 내용을 아래의 한 줄로 표현 가능
            // MessageBox.Show(Convert.ToString(iResult));
        }
    }
}
