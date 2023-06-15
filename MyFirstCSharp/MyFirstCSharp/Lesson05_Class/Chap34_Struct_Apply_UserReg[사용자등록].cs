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
    public partial class Chap34_Struct_Apply_UserReg : Form
    {
        // 클래스의 전역 변수로 사용자 정보 데이터 유형을 나열할 수 있는 리스트 생성
        private List<UserInfo> userInfos = new List<UserInfo>();

        public Chap34_Struct_Apply_UserReg()
        {
            InitializeComponent();
        }

        private void btnUserReg_Click(object sender, EventArgs e)
        {
            // 사용자 등록을 하기 전 벨리데이션 체크
            string sUserID    = txtUserID.Text;
            string sUserPW    = txtUserPW.Text;
            string sUserName  = txtUserName.Text;
            string sUserEmail = txtUserMail.Text;

            if (sUserID == "" || sUserPW == "" || sUserName == "" || sUserEmail == "")
            {
                MessageBox.Show("필수 입력 항목입니다. 항목에 맞게 적어주세요");
                return;
            }

            // 사용자 정보를 담을 수 있는 데이터 자료형에 등록하는 사용자에 대한 데이터를 할당

            //UserInfo userinfo = new UserInfo();
            //userinfo.UserID   = sUserID;      // 사용자 ID
            //userinfo.UserName = sUserName;    // 사용자명
            //userinfo.Email    = sUserEmail;   // 사용자 이메일 주소
            //userinfo.PassWord = sUserPW;      // 메일주소
            //userinfo.UseFlag  = true;         // 사용여부
            //userinfo.MakeTime = DateTime.Now; // 현재 일 시

            //// 전역 변수 리스트에 사용자 정보를 ADD
            //userInfos.Add(userinfo);

            // 위 로직은 아래와 같이 표현할 수 있다.
            userInfos.Add(new UserInfo 
            {
                UserID   = sUserID,      // 사용자 ID
                UserName = sUserName,    // 사용자명
                Email    = sUserEmail,   // 사용자 이메일 주소
                PassWord = sUserPW,      // 메일주소
                UseFlag  = true,         // 사용여부
                MakeTime = DateTime.Now  // 현재 일 시
            });

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Chap34_Struct_Exam_Login._userInfos = userInfos;
            this.Close();
        }
    }
}
