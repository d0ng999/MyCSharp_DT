using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSharp
{
    // 사용자 정보 관리를 위한 
    public struct UserInfo
    {
        // 사용자 ID
        public string UserID {  get; set; }

        // 사용자 PW
        public string PassWord { get; set; }

        // 사용자명
        public string UserName { get; set; }

        // 메일 주소
        public string Email { get; set; }

        // 사용여부
        public bool UseFlag { get; set; }

        // 등록일시
        public DateTime MakeTime { get; set; }
    }
}
