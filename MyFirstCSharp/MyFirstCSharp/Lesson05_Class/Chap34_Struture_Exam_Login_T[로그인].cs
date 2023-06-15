using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp.Lesson05_Class
{
    public partial class Chap34_Struture_Exam_Login_T : Form
    {
        // 사용자 등록 화면에서 사용자의 리스트를 받아올 리스트
        private List<UserInfo_T> userinfos = new List<UserInfo_T>();

        public Chap34_Struture_Exam_Login_T()
        {
            InitializeComponent();
        }

        private void btnUserReg_Click(object sender, EventArgs e)
        {
            // 사용자 등록 버튼을 클릭 시, 
            // 사용자에 대한 정보를 담을 수 있는 리스트를 전달(참조 - 주소를 전달)!
            // 사용자 등록 클래스에 전달

            Chap34_Struture_Apply_UserReg_T CHAP34 = new Chap34_Struture_Apply_UserReg_T(userinfos);
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 로그인 가능 여부를 판단
            if (userinfos.Count == 0)
            {
                MessageBox.Show("등록된 사용자가 없습니다.");
                return;
            }

            // 입력한 ID, PW
            string sUserID = txtUserId.Text;
            string sUserPW = txtPassWord.Text;

            // 리스트에 등록되어 있는 사용자 정보와 입력한 사용자의 정보가 같은지 확인
            foreach (UserInfo_T userinfo in userinfos)
            {
                // 등록한 아이디와 같다는 것!
                if (userinfo.UserId == sUserID)
                {
                    // 사용자 아이디가 같다면 비밀번호도 쳌!
                    if (userinfo.Password == sUserPW)
                    {
                        MessageBox.Show($"{userinfo.UserName}님 반갑습니다.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 일치하지 않습니다.");
                    }
                    return;
                }
            }
            MessageBox.Show("등록된 아이디가 없습니다. 등록해주세요!!");
        }
    }
}
