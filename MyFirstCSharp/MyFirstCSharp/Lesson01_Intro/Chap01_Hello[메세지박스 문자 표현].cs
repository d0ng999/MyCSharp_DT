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
    public partial class Chap01_Hello : Form
    {
        public Chap01_Hello()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            // 버튼을 클릭했을때 메세지 창 띄우기!!

            // MessageBox : 메세지를 관리할 수 있는 명령의 집합
            // .Show("~"); : Show 라는 기능을 이용해서 ~를 보여줘라 // 문자열만 가능

            // 메세지 박스에 있는  Show(함수, 메서드)를 이용해서 "Hello World"를 표현할 예정
            MessageBox.Show("Hello World");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 반갑습니다 메세지를 표현
            MessageBox.Show("반갑습니다.!@#$%^^");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요. 저는 누구입니다!");
        }

        private void Chap01_Hello_Load(object sender, EventArgs e)
        {

        }
    }
}
