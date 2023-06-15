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
    public partial class Chap34_Struct_Exam_Login : Form
    {
        Chap34_Struct_Apply_UserReg CHAP34 = new Chap34_Struct_Apply_UserReg();

        public static List<UserInfo> _userInfos = new List<UserInfo>();

        public Chap34_Struct_Exam_Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CHAP34.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (UserInfo info in _userInfos)
            {
                if (!info.UserID.Contains(txtUserId.Text))
                {
                    MessageBox.Show("등록해야합니다.");
                    return;
                }
                else if ((info.UserID == txtUserId.Text) && (info.PassWord != txtUserPW.Text))
                {
                    MessageBox.Show("비밀번호 틀림");
                    return;
                }
                else if ((info.UserID == txtUserId.Text) && (info.PassWord == txtUserPW.Text))
                {
                    MessageBox.Show($"{info.UserName} 님 환영합니다.");
                    return;
                }
            }
        }
    }
}
