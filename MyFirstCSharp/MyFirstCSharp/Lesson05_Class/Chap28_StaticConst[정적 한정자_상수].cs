using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSharp
{
    /*
        Static 한정자 (정적 한정자) - 데이터라는 메모리 - 특정 공간에 따로 저장된다.
         - 프로그램 전체에서 유기적으로 관리해야하는 값이 발생할 경우
           객체의 생성없이 클래스 내의 필드 값을 직접 호출 및 관리할 수 있도록 하는 한정자이다.
           정적 메서드( 클래스 메서드 ) 라고도 불린다.
         - 최초 초기화(호출되는 시점)가 될 때,
           Data 영역(정적 변수가 저장되는 곳), Code 영역(정적 메서드가 저장되는 곳)의 메모리에 등록되어
           프로그램이 종료될 때까지 소멸되지 않는다.
           불필요하게 사용할 경우, 메모리 효율성을 떨어뜨릴 수 있다.

        Const 상수 - 변하지 않는 값
         - 최초 값 대입 후(초기화 후) 추가로 값을 할당할 수 없다.
           데이터의 변질을 막기 위해 사용.
           시스템의 경우, 특정 하드웨어 또는 인프라 등에 접속하기 위한 경우 - 주소 등이 할당된다.
    */

    internal class Chap28_StaticConst
    {

    }

    class Static_Class
    {
        // 모든 필드가  Static 으로 한정되는 클래스
        public static string sValue = "정적 변수 생성되었습니다.";
    }

    class Static_Or_Instance_Class
    {
        // 정적 필드와 인스턴스 필드가 혼합되어 구현된 클래스
        public string sInstance = "인스턴스 변수입니다.";
        public static string sStaticValue = "정적 변수입니다."; // 데이터 메모리 영역에 저장된다.

        // 클래스 내에 정적 필드와 인스턴스 필드를 동시에 생성할 수 있다.

        public static void StaticMethod()
        {
            // 외부에서 언제든지 접근가능한 정적 메서드( 고정되어 있는 메서드 )
            // 정적 메서드
            // - 메서드의 코드 영역에 저장, 프로그램 종료 시까지 소멸되지 않는다.
            sStaticValue = "정적 변수가 수정되었습니다.";
            int iValue = 0;
        }
    }

    // 클래스 자체를 Static 클래스로 지정한다.
    // 클래스내의 모든 멤버는 Static 형식으로 지정되어야 하고, 
    // 모든 멤버는 Code 영역 및 데이터 영역에 등록이 된다.
    static class StaticClass
    {
        private static string sPrivate;
        public static string sPublic;

        // 정적 한정자, 접근제한자 표현
        static public string sPublic2;

        static void StaticMethod()
        {

        }

        // public string sValue = "Static 이 아니므로 만들수 없다.";
    }

    class Const_Class
    {
        // 상수
        // public const string sConst; - 상수는 반드시 초기화를 통해 선언을 해야한다.
        public const string sConst = "상수 값";
    }
}
