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
    public partial class test1 : Form
    {
        public test1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] iValues = new int[5] { 11, 12, 33, 42, 87 };

            string[] sValues = { "안녕하세요", "반갑습니다.", "스마트팩토리반", "파이팅" };
            string[] sValues2 = "ABC/DEF".Split('/');
            int[] iValues5 = new int[sValues.Length];
        }
    }
}
