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
    /* 
     * 1. Property
     *    - 클래스 내부 변수(전역변수)의 값을 읽거나 쓸 때 사용하는 문법
     *    - 유효성 검사를 위해 사용된다.
     *      . 데이터의 변질로 인한 오류 사항을 사전에 방지할 수 있는 방법
     *    
     *    - 캡슐화
     *      . 정보은닉, 최소한의 멤버만 공개하는 방식
     */ 
    public partial class Chap32_Property : Form
    {
        // 6. 서점 관리 클래스를 객체화
        private BookStore B_S = new BookStore();


        public Chap32_Property()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // 7. 서점에 만화책의 입고 내역을 생성
            int.TryParse(txtInQty.Text, out int iInQty);

            // 서점 클래스의 재고 수량에 입고 재고 등록
            B_S.BookCount += iInQty; // 재고 수량 누적

            lblStockQty.Text = B_S.BookCount.ToString();
            txtInQty.Text = "";

            MessageBox.Show($"{iInQty}권의 만화책이 입고되었습니다.");
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            #region < 1. BookCount, - 재고 벨리데이션을 개별로 적용할 경우 >
            //// 8. 만화책 판매 로직을 수행 (클릭 시 1권씩 재고 차감)
            //--B_S.BookCount;

            //// 9. 책의 카운트는 음수가 될 수 없으므로 벨리데이션 체크
            //if (B_S.BookCount < 0)
            //{
            //    B_S.BookCount = 0;
            //    MessageBox.Show("책의 수량은 0보다 작을 수 없습니다.");
            //}

            //// 수량 표현
            //lblStockQty.Text = B_S.BookCount.ToString();
            #endregion

            #region < 2. BookCount2, 프로퍼티로 0 재고 벨리데이션을 공통으로 적용하여 사용하는 경우 >
            // 벨리데이션 체크를 통하여 재고를 0이하로 만들지 않는 로직은 구현 완료하였으나
            // 프로젝트를 통하여 여러 사람과 같은 로직을 사용해야하는 경우
            // ex) 내가 만든 프로그램 이외에 다른 사람이 BookStore 클래스의 BookCount의 재고를
            //     관리해야하는 경우가 생겼을 때, 혼란스러울 수 있다.
            // 변수 자체에 조건을 걸어 주어 재고가 0이하로 떨어지는 것을 방지할 수 있다.

            // 11. 새로 만든 Property에 재고 차감.
            // BookCount2 프로퍼티에 재고가 0 이하가 될 수 없는 조건을 설정하였으므로, 
            // BookCount2를 사용하는 모든 로직에서 공통으로 벨리데이션 체크 기능이 적용된다.

            // 이 로직이 실행되자마자 아래의 BookStore 클래스의 BookCount2인 Value가 조건에 만족하는지 확인한다.
            --B_S.BookCount2; 
            // 이는 마치 메서드와 같은 느낌이다. 큰 프로젝트에 여러 사람이 BookCount를 사용한다면,
            // 벨리데이션 체크를 저 변수의 개수마다 해줘야할텐데, 프로퍼티를 사용하면 메서드처럼 한번 쓰는 것으로
            // 모든 BookCount에 대한 변수에 벨리데이션 체크가 가능함

            lblStockQty.Text = B_S.BookCount.ToString();
            #endregion
        }
    }


    // 2. 서점이라는 클래스가 있다고 할 때
    class BookStore
    {
        private int iBookCount; // 3. 서점 클래스에서만 관리할 만화책에 대한 재고 수량

        // 프로퍼티 BookCount 생성
        public int BookCount // 4. 외부에서 BookCount로 접근하여 내부의 iBookCount를 관리
        {
            get // 특정한 데이터를 확인할 때 쓰임, private 전역변수 iBookCount의 데이터를 반환
            {
                return iBookCount;
            }
            set // 데이터를 할당할 때 쓰임
            {
                // 외부에서 접근가능한 BookCount 변수에 데이터를 할당할 때
                // 클래스 전역 변수 iBookCount에 데이터 할당을 해준다.
                iBookCount = value; // value라는 키워드 사용
            }
        }

        // 5. 정보 은닉을 위해 실제 데이터를 관리하는 변수 iBookCount는 Private로 선언을 했지만,
        //    public BookCount를 통하여 Get와 Set으로 접근가능하게 하니까
        //    iBookCount를 public으로 하지 왜?? -- 특정 조건을 입힐 수 있다는 장점이 있어요


        // 10. 데이터의 변질을 막기 위한 공용 변수 BookCount2
        public int BookCount2
        {
            get
            {
                return iBookCount;
            }
            set
            {
                // 데이터 변질을 막기 위한 로직을 구현
                if (value < 0)
                {
                    // 차감한 수량이 음수인 경우
                    MessageBox.Show("만화책 재고 수량은 0 이하일 수 없습니다.");
                }
                else
                {
                    iBookCount = value;
                }
            }
        }

        // 12. 일반적인 Get / Set 방법 외에도 프로퍼티를 생성할 수 있는 방법이 있다.
        public int BookCount3 { get; set; } // 이는 아래와 같은 의미를 가지고 있다.

        //private int BookCount3;
        //public int BookCount3
        //{
        //    get
        //    {
        //        return BookCount3;
        //    }
        //    set
        //    {
        //        BookCount3 = value;
        //    }
        //}

        // 13. 읽기 전용 Property
        public int BookCount4 { get; } // ReadOnly

        // 14. 쓰기 전용 Property
        public int BookCount5
        { 
            set
            {
                iBookCount = value;
            }
        }
            
    }
}
