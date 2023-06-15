using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCSharp
{
    internal class Chap02_DataType
    {
        // 변수 : 값을 담아주는 그릇의 개념
        // 하나의 데이터 값을 가질 수 있으며, 한 번 정해진 값이 고정되는게 아니라,
        // 특정한 상황에 따라 계속해서 변하는 데이터 타입

        // 1. 정수형 데이터 타입과 변수
        //  - 정수형 데이터를 정수형 변수에 담는다.
        // int : integer(정수형 데이터 타입)

        // 1-1. 정수형 데이터 타입을 담을 그릇을 만들기
        //      그릇의 이름을 iValue로 설정
        //      10이라는 정수를 iValue라는 그릇에 담기!
        int iValue = 10;

        // 정수형 그릇 iValue2를 만들기.
        int iValue2;
        int iValue3;

        public Chap02_DataType()
        {
            // iValue2에 특정 정수 데이터 담기
            iValue2 = 10;
            
            iValue3 = 100;
            int iValue4 = 100;

            // 2. 실수형 데이터 타입과 변수
            // double 형태의 데이터를 담는 그릇(자료형 구조)은 integer형태의 그릇의 크기보다 큰 형태이므로
            // 정수형 데이터와 실수형 데이터 모두 double형태의 그릇에 담길 수 있다.
            double dValue = 10;
            dValue = 115.5;

            // 데이터의 크기가 큰 내역은 작은 데이터 타입의 그릇에 담을 수 없다.
            // double > int 데이터 타입의 크기차이
            // iValue4 = 10.2;

            // 3. 문자형 데이터 타입과 변수
            string sValue; // 문자를 담을 수 있는 그릇을 sValue라는 이름으로 생성
            sValue = "안녕하세요!"; // ""없이는 문자를 대입할 수 없다.

            sValue = "100"; // 숫자를 문자형태로 넣기 위해선 ""내에 숫자를 입력해주자

            // 4. 논리형 데이터 타입과 변수
            // 논리: 참과 거짓을 구분짓는 데이터 타입!
            // ! : 참과 거짓을 판단하는 데이터 형을 스위칭하여 적용하는 키워드
            bool bValue; // bValue라는 변수를 Bool 데이터 타입으로 생성.
            bValue = true; // bValue에 참 true인 상태를 등록
            bValue = !true; // true를 스위칭(-> false)해서 bValue에 대입
            bValue = false; // bValue에 false인 상태를 등록
            bValue = !false; // false를 스위칭(-> true)인 상태를 bValue에 대입
            //bValue = 1; 데이터 타입과 맞지 않는 데이터를 대입하면 오류가 발생

            // 빌드(Ctrl + B, 프로젝트 - 빌드 & 솔루션 빌드 - Shift + Ctrl + B)
            // : 개발자가 코딩한 프로그램 내용을 컴퓨터가 알아들을 수 있도록 포장(MSIL, CIL) -> 컴파일
            // 중간 단계의 언어

            // 프로그램 오류 검출의 종류
            // 1. 컴파일할 때(빌드, 중간언어로 포장할 때) 개발자에게 오류 내역을 즉각 알려주는 에러 타입
            //  - 컴파일 타입의 에러 검출 유형
            // 2. 프로그램을 실행 시켜야만 오류 내역을 확인할 수 있는 방식
            //  - 런타임 에러 검출 유형

            // 주석 : 개발자가 프로그래밍 작성 시, 로직에 대한 코멘트(생각 또는 설명)을 첨가하여 작성하는 방법
            // 프로그램 실행에는 영향을 미치지 않는다.
            // 선택 영역 주석 Ctr + K, C

            // 5. 그 외의 데이터 타입
            // 5-1 character 형식 - ''(딱 한글자일 때만)로 문자 1자리를 담는다.
            char cValue = 'A'; // char: 문자(1개)
            string sValue3 = "ABCDE"; // string: 문자열

            uint uiValue = 1; // uint : 양의 정수만 다루는 데이터 형식

            // var형식
            // 특정 데이터를 담을 형식을 미리 정해두지 않고 가변적으로 데이터를 관리할 경우
            var vValue1 = 10; // 정수 & 실수 형 데이터 등록 가능
            var vValue2 = "안녕하세요"; // 문자열 데이터 등록 가능
            var vValue3 = 'A'; // 문자 데이터 등록 가능
            var vValue4 = true; // 논리 데이터 등록 가능

            // vValue1 = "AS"; 
            // 이미 vValue1은 정수형 int타입으로 초기화했기 때문에 다른 데이터 타입의 형태는 대입할 수 없다

            // 어떠한 그릇에 데이터를 최초 대입하다: 데이터 초기화!

            // 블록 단위안에서 선언된 로직들 중 같은 이름의 변수를 계속해서 써주게되면 로직에 오류가 발생한다.
            // 블록 단위안의 지역변수중에서 절대 같은 이름의 변수명을 사용할 수 없다.(지역변수만 불가능)


            // 5-2 object 형식
            // 모든 데이터 타입의 시초
            // 초기화가 된 후에도 같은 변수명에 다른 값을 넣기 가능(관대함)
            object oValue1 = 10;
            oValue1 = "10";
            oValue1 = true;

            // var, object : 가변적으로 데이터를 관리할 수 있는 유용한 자료형 구조이지만,
            // 대규모 프로젝트에서 타 개발자가 만든 특정 로직으로 인한 
            // 데이터 타입이 일치하지 않는 오류가 발생할 수 있어서 사용을 추천하지는 않는다.
        }

    }
}
