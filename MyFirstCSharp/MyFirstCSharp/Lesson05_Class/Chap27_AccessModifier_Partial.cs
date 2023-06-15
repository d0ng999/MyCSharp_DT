using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSharp
{
    // Partial Class (분할 클래스, 파생 클래스)
    // . 클래스는 동일한 Namespace에서 같은 이름으로 작성될 수 없다.
    //   같은 클래스를 동시에 개발하거나,
    //   단위 모듈별로 코딩을 나누어 개발해야 하는 경우
    //   같은 클래스임을 표현하는 키워드
    partial class Chap27_AccessModifier_Partial
    {
        public string sPublic     = "Public String";
        private string sPrivate   = "Private String";
        protected string sPartial = "Partial String";
    }

    partial class Chap27_AccessModifier_Partial
    {
        // 같은 이름의 클래스는 두 개 이상 만들수 없습니다.

        // partial class를 선언하면
        // 같은 이름으로 두 개의 클래스를 생성할 수 있다.
        // 이 때, * 클래스가 두 개가 생성된 것이 아니라
        // 하나의 클래스임을 선언하는 키워드가 Partial -- 하나의 클래스를 여러 개로 분리한다는 개념

        void CheckValue()
        {
            sPublic = sPrivate = sPartial; // partial class내에서는 모든 멤버들이 공유가능하다. 같은 클래스에 있어서
        }
    }

    class newClass2
    {
        void FindValue()
        {
            // 클래스 인스턴스화, 객체화
            Chap27_AccessModifier_Partial CHAP27_P = new Chap27_AccessModifier_Partial();

            CHAP27_P.sPublic = "접근이 가능하네요";
            // CHAP27_P.sPrivate : 접근 불가능
            // CHAP27_P.sPartial : 접근 불가능
            // 다른 클래스에 있어서!!
        }
    }

    
}
