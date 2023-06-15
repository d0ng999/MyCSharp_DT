using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSharp
{
    // 접근 제한자
    // 프로그램 내에서 특정한 코드, 변수, 필드, 메서드 등에 접근하려고(호출) 할 때,
    // 권한에 따라 호출 여부를 결정지을 수 있는 제한자.

    // 접근제한자를 사용하는 이유
    //  - 캡슐화(객체지향 언어에서 지켜야하는 규칙, 개념)
    //  . 모든 기능과 변수를 외부에서 접근가능한 코딩으로 구현할 경우,
    //    개발을 한 당사자 외에 여러 사용자에 따라
    //   1. 데이터의 변형을 일으키거나, 정상적인 동작을 저해할 우려가 있다.
    //   2. 불필요하게 너무 많은 기능을 외부에서 호출가능하도록 하면
    //      개발자 입장에서는 어떤 기능을 정확히 사용해야 하는지 혼란이 올 수 있다.
    //   따라서 코드 내부에서 처리되는 내용은 외부에서 접근하지 못하도록 막고,
    //   외부에서 호출하여 사용해야되는 핵심 기능만 접근 가능하도록 하여
    //   효율적이고 안정성있는 프로그램을 구현하도록 하기 위하여 사용된다.

    // ex) 1 -> 2 -> 3 -> 4 -> 5의 순서로 구현되어야하는 메서드가 있다고 가정을 할 때,
    //     5의 결과를 얻기 위해서는 반드시 1부터 시작해야 하는데 
    //     1 외에 2, 3, 4, 5 메서드를 호출가능한 상태로 만들어버리면
    //  1. 1 부터 시작해야하는 정상 로직이 안전하게 구현되지 못하는 오류가 발생할 수 있다.
    //  2. 개발자는 시작점이 어디인지 판단하기 힘들다.

    internal class Chap27_AccessModifier
    {
        // 접근제한자 종류
        // Public    : 모든 클래스에서 접근할 수 있음
        // Private   : 해당 클래스 내에서만 접근할 수 있음
        //           . C# 의 경우, 접근제한자를 명시하는 부분에 접근제한자를 표시하지 않을때,
        //             기본으로 Private이 적용
        // internal  : 동일한 Namespace에서 접근할 수 있다.
        // protected : 파생 클래스에서 접근이 가능하다. 

        // 클래스의 인스턴스 변수 ( 클래스의 필드 멤버 - 전역변수 )
        public string sPublic = "안녕하세요";               // 모든 곳에서 접근이 가능한 인스턴스 변수
        private string sPrivate = "Private String";         // 해당 클래스에서만 호출이 가능하다.
        protected string sPartial = "Partial Class String"; // 분할 클래스에서만 접근이 가능한 변수

        private int iLoopCount = 0; // private이 기본적으로 있는 형태이다.

        public void FindValue()
        {
            // 다른 클래스에서 호출이 가능한 Public 형태의 메서드
            sPrivate = "클래스내에서 접근이 가능함";

            FindValue2(); // 해당 클래스 내에서 호출 가능한 private Method
        }

        private void FindValue2()
        {
            // 다른 클래스에서는 호출할 수 없는 Private 메서드
            sPrivate = "동일 클래스의 다른 메서드에서도 접근이 가능함";
            sPublic = "동일";
            sPartial = "접근 가능";
        }
    }

    // 클래스 코드 작성 위치
    //  . 클래스를 생성할 경우, 프로젝트에 .cs 파일로 추가하는 방법이 있고,
    //    소스 내에서 클래스를 수동으로 생성하는 방법이 있다.
    //    여러 개발자가 개발을 할 경우 공통으로 사용하는 클래스인 경우
    //    솔루션 탐색기에서 확일할 수 있도록 파일 형태의 클래스를 생성하는 것이
    //    개발자가 단독으로 사용할 클래스인 경우 소스내에서 생성하여 사용할 수 있다.
    class NewClass
    {
        // 새로운 클래스의 생성

        void NewMethod()
        {
            // 로직이 실행되는 메서드
            Random random = new Random(); // MicroSoft에서 만들어서 제공하는 클래스

            // 이건 내가 만들어서 사용할 클래스
            Chap27_AccessModifier CHAP27 = new Chap27_AccessModifier(); // 생성자 - 객체화

            CHAP27.sPublic = "반갑습니다";
            // CHAP27.sPrivate, CHAP27.sPartial 은 접근할 수 없는 접근제한자를 사용중이다.

            CHAP27.FindValue(); // 다른 클래스에서 접근이 가능한 메서드 public Method
            // CHAP27.FindValue2(); 이건 접근이 불가능한 메서드 Private Method

            // FindValue() 를 실행하고 FindValue2()를 순차적으로 실행해야하는 경우
            // FindValue2()를 외부에서 접근하지 못하도록 Private으로 접근 제한을 두고,
            // FindValue() 는 외부에서 접근이 가능하도록 Public으로 접근 제한을 두면서 
            // FindValue2()를 호출함으로써 순차적인 로직을 실행할 수 있다.

            // --- 캡슐화 ---
            // 최소한의 소스, 코딩만 외부에 공개함으로써 프로그램의 무결성과 안정성을 유지하도록 하는 방식
        }
    }

    partial class Chap27_AccessModifier_Partial
    {
        // 동일한 네임스페이스에서는 Partial 클래스를 언제 어디서든지 생성하여 하나로 만들어 줄 수 있다.

        // 혼자 개발하는 것이 아니기때문에 여러 개발자가 모여서 하나의 클래스에 합쳐야하는 경우에
        // 주로 사용하는 것 같다.
    }
}
