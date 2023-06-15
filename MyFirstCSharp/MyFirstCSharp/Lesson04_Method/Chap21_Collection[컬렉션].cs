using System;
using System.Collections;
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
    // Collection
    // 특정 데이터를 여러개를 담아서 관리할 수 있는 자료형 구조
    // 몽땅 포함하여 Collection이라고 한다.
    // Collection이라고 불리는 자료형 구조들(List, ArrayList, Dic, Stack...)은
    // 모두 Collection을 상속받아 구현된 개체(클래스)들이다.

    public partial class Chap21_Collection : Form
    {
        public Chap21_Collection()
        {
            InitializeComponent();
        }
        #region < List >
        private void btnList_Click(object sender, EventArgs e)
        {
            // List
            // 배열과 유사한 열거형 데이터자료
            // 크기가 가변적인 데이터를 담을 수 있다

            // 요소 : index와 데이터 값을 통틀어 부르는 말

            // 1. 리스트의 생성
            // 정수형 리스트의 생성
            List<int> list_iValues = new List<int>(); // 선언
            // : 객체화(실체화)를 해서 사용할 수 있는 상태
            // List<int> list_iValues; : 있기는 있으나 객체화가 되지 않았다.

            // 정수형 List 클래스를 list_iValues라는 이름으로 new 키워드를 이용하여
            // 객체화(사용가능한 객체)하여 현재 블럭에서 사용하겠다라는 뜻!

            // string[]
            // 문자열 형 List 생성
            List<string> list_sValues = new List<string>();

            // 2. 리스트에 데이터 할당
            // 방의 크기를 설정할 필요없음
            list_iValues.Add(100);
            list_iValues.Add(44);
            list_iValues.Add(1);

            list_sValues.Add("반갑습니다");
            list_sValues.Add("안녕하세요");

            // 3. 리스트 생성과 동시에 값을 할당
            List<int> list_iValues2 = new List<int>() { 1, 3, 5, 7 ,9 };

            // 4. 리스트의 개수 확인
            // 배열의 개수 : Length
            // 리스트의 개수 : Count
            MessageBox.Show($"list_iValues2의 데이터 개수는 {list_iValues2.Count}입니다.");

            // 5. 리스트의 요소의 데이터 확인하기
            StringBuilder sb = new StringBuilder();
            // 5-1 열거형 자료여서 foreach가능
            foreach(int iValue in list_iValues2)
            {
                sb.Append(iValue + "\r\n");
            }
            MessageBox.Show(sb.ToString());

            sb.Clear(); // 스트링 빌더의 값 초기화

            // 5-2 배열과 유사하게 인덱스를 사용하여 데이터값 확인
            // 배열과 마찬가지로 데이터 주소(index)를 이용하여 요소를 관리
            // for문 사용
            for (int i = 0;  i < list_iValues2.Count; i++)
            {
                sb.Append(list_iValues2[i] + "\r\n");
            }
            MessageBox.Show(sb.ToString());

            // List는 클래스, 배열과 마찬가지로 참조된다.
            // 기본적으로 클래스는 참조형. Heap메모리 영역에 등록

            // 6. List의 복사
            // 6-1 참조 전달(얕은 복사 방식)
            // 해당 주소값을 복사한 것으로서 그 주소값에 할당된 데이터값을 변경하면 해당 주소값을
            // 가진 기존의 리스트에도 영향이 간다.
            List<int> list_Copy = list_iValues2;
            list_Copy[0] = 55555;
            MessageBox.Show($"얕은 복사 방식으로 list_Copy[0]에 할당한 55555 가" +
                            $" list_iValues[0] 값({list_iValues2[0]})과 동일합니다.");

            // 6-2 Heap에 할당된 값 자체를 복사(깊은 복사)
            // .ToList() : 리스트를 깊은 복사하는 방법
            List<int> list_Copy2 = list_iValues2.ToList();
            list_Copy2[0] = 123123;
            MessageBox.Show($"깊은 복사 방식으로 list_iValues2의 값을 복사한 list_Copy2 리스트의" +
                            $"0번 주소 값이 11로 바뀌었지만, list_iValues2[0]의 값은 {list_iValues2[0]}" +
                            $"인 것을 확인할 수 있습니다.");
        }

        private void btnListII_Click(object sender, EventArgs e)
        {
            // 리스트 2
            List<int> list_i = new List<int>() { 11, 34, 3, 119, 150, 20, 300 };

            // 7. 리스트의 요소를 추가(index + 데이터) - .Insert(인덱스, 값)
            list_i.Insert(2, 300);

            // 8. 리스트의 특정 요소를 제거
            // .Remove(데이터값)
            // - 데이터가 존재할 경우 데이터의 index를 함께 삭제
            //   데이터가 없을 경우 아무일도 일어나지 않는다.
            // * 해당 index가 삭제되고 난 후 순차적으로 채워넣기식으로 재정렬
            //   가까운 index로부터 하나의 데이터가 삭제
            list_i.Remove(119);

            // .RemoveAt(인덱스주소)
            // - index의 요소를 삭제
            //   해당 인덱스를 삭제 후 index가 순차적으로 채워넣기 식으로 정렬
            list_i.RemoveAt(5);
            //list_i.RemoveAt(100); // 존재하지 않는 인덱스의 경우 오류가 발생한다.

            // 9. 특정 조건을 만족할 경우 List의 요소를 제거
            //foreach(int iValue in list_i)
            //{
            //    if (iValue > 100)
            //    {
            //        list_i.Remove(iValue);
            //    }
            //}

            /*
            Foreach 사용시 열거형 요소는 수정, 추가할 수 없다.
            Foreach는 열거형 데이터를 읽기 전용으로 가져오기때문에
            최소 Foreach문으로 읽어온 list_i가 실행될 당시의 구조와 갱신되었을 경우
            마지막 요소까지 순차적으로 실행할 수 없기때문에 오류가 발생한다.
             */

            // 그러면 ? 특정 조건을 만족시킬때, (ex, iValue > 100) 리스트의 요소를 삭제하는 방법
            
            // i : 리스트의 index를 가리키는 경우
            // .RemoveAt은 요소 하나를 삭제하게 되면 리스트가 재정렬되면서 꼬일 수 있다.

            // 해결 1 : 인덱스의 요소를 삭제 후, 재정렬 후 현재 인덱스를 다시 비교할 수 있도록
            // i값은 1 차감 시켜준다.
            //for (int i = 0; i < list_i.Count; i++)
            //{
            //    if (list_i[i] > 100)
            //    {
            //        list_i.RemoveAt(i);
            //        --i;
            //    }
            //}

            // 해결 2
            // 역 For문을 이용하여 마지막 index로부터 순차적으로 처리하도록 하는 방법
            for (int i =list_i.Count - 1; i >= 0; i--)
            {
                if (list_i[i] >100)
                {
                    list_i.RemoveAt(i);
                }
            }
        }

        #endregion

        // ctrl + M + O 모든 창을 닫아준다.

        #region < ArrayList >
        private void btnArrayList_Click(object sender, EventArgs e)
        {
            // ArrayList
            // - 데이터 형식에 상관없이 다중 데이터를 관리할 수 있는 데이터 타입
            // - 데이터 형식에 구애없이 데이터가 할당되므로 데이터를 확일할 때는
            //   반드시 데이터 형 변환이 이루어져야한다.

            // 1. ArrayList의 생성
            // Using System.Collections; : ArratList 클래스가 있는 DLL 파일(프로젝트, 어셈블리, namespace)
            ArrayList arrayList = new ArrayList();

            // 2. 데이터를 등록하는 방법
            for (int i = 0; i < 11;  i++)
            {
                // arrayList에 정수형 데이터를 0 ~ 10까지 할당
                arrayList.Add(i);
            }

            arrayList.Add("안녕하세요");
            // arrayList에 데이터를 등록할 때, Object형식으로 할당된다. -> Boxing

            // arrayList.Sort();
            // 정수형 데이터와 문자형 데이터가 혼합되어 있어서 오류가 발생한다.

            // 데이터의 삭제 -- 요소 삭제
            arrayList.Remove(3); // 3이라는 데이터 값을 삭제
            arrayList.Remove("안녕하세요");

            arrayList.RemoveAt(3); // 3번째 인덱스 값을 삭제

            // 데이터 추가 -- 요소 등록
            arrayList.Insert(2, 40); // .Insert(인덱스 번호, 데이터 값)

            // ArrayList에 기존 컬렉션의 데이터를 추가하는 방법
            // arrayList < -int[]
            int[] iValues = { 1, 2, 3, 4 };
            // ArrayList라는 클래스를 사용
            // 정수 배열 iValues를 던져줄테니 이 값을 가지고 복사해서 
            // 초기 값을 할당 후(초기화 후) 사용하게 해주세요 라는 뜻
            ArrayList arrayList2 = new ArrayList(iValues);
            MessageBox.Show(arrayList2[0].ToString());
            arrayList2[0] = "안녕하세요";

            ArrayList arrayList3 = new ArrayList(new int[] {1,2,3,4,5});

            // 위 방법은 아래의 내용과 동일한 결과를 나타낸다.
            //int[] iValues2 = new int[] { 1, 2, 3, 4, 5 };
            //ArrayList arrayList3 = new ArrayList(iValues);

        }
        #endregion

        #region < Queue >
        private void btnQueue_Click(object sender, EventArgs e)
        {
            // Queue
            // 선입 - 선출 방식의 자료 구조
            // 데이터나 작업을 차례대로 입력된 순서에 따라 하나씩 처리
            // 웹 등에서 동영상이나 문서 등의 파일을 다운받을때,
            // 순차적으로 처리하기 위해 데이터를 담을 때 주로 사용

            // 1. Queue의 선언
            Queue<int> queue = new Queue<int>();

            // 2. Queue의 데이터 등록
            // 할당하는 방식으로 등록하는 것이 아닌, 데이터 등록 메서드가 별도로 존재
            queue.Enqueue(10); // 선입선출할 수 있는 데이터 정렬을 하는 기능
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            // 3. Queue 데이터를 확인
            // 3-1 어떤 데이터가 있는지 확인
            foreach (int iValue in queue)
            {
                MessageBox.Show("Foreach : " + iValue.ToString());
            }

            // 3-2 for 사용해서 데이터 확인
            // Peek() : 가장 먼저 선출하는 데이터값을 보여준다.
            // 우선순위가 높은(선입데이터)를 표현
            // 현재 추출될 데이터가 무엇인지 확인하고 로직을 처리하는데 사용
            for (int i = 0; i < queue.Count; i++)
            {
                MessageBox.Show("Peek : " + queue.Peek().ToString());
            }

            // Queue의 데이터를 사용하기 위하여 추출하고 요소를 삭제
            while(queue.Count > 0)
            {
                MessageBox.Show(queue.Dequeue().ToString());
            } 

            // 다른 컬렉션의 데이터를 Queue에 담기
            Queue queue2 = new Queue(new int[] { 1,2,3,4,5});

            Queue queue3 = new Queue(new List<int>
            {
                1,
                2,
                3,
                4,
                5
            });
            // 위의 List 대입 문법은 아래와 같이 표현할 수 있다.
            List<int> iValues = new List<int>();
            iValues.Add(1);
            iValues.Add(2);
            iValues.Add(3);
            iValues.Add(4);
            iValues.Add(5);

            // Queue queue3 = new Queue();
            //List<int> iValues2 = new List<int>() {  1,2,3,4,5};

            // Queue
            // 데이터를 순차적으로 담아서 처리 (선입선출)후 메모리에서 데이터를 삭제하므로,
            // 메모리 관리에 용이한 자료형 구조이나
            // 데이터가 휘발성(확인 후 삭제)되므로 필요한 곳에 따라서 잘 사용할 수 있도록 하자



        }
        #endregion

        #region < Stack >
        private void btnStack_Click(object sender, EventArgs e)
        {
            // Stack
            // 선입 후출 방식의 데이터 자료구조
            // 메모리 영역의 Stack과 이름이 같지만 자료형 구조의 Stack인 경우, 
            // Stack 메모리 영역에 데이터가 관리되는 방법을 나타낸다.

            // Stack과 Queue는 
            // 데이터가 등록되고 호출 시 메모리에서 삭제되므로
            // 메모리 관리에 용이하다. (데이터 사용 후 즉각 처리)

            // Stack의 생성
            Stack<int> stack = new Stack<int>();

            // Stack에 데이터 등록
            stack.Push(10); // 후입선출하기 위해 데이터를 재정렬하는 기능
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            // 데이터 확인
            foreach (int iValue in stack)
            {
                MessageBox.Show("Foreach : " + iValue.ToString());
                // 나중에 들어온 데이터를 우선순위로 하여 보여준다.
            }

            // 데이터를 제거하지 않고 표현
            for (int i = 0 ; i < stack.Count; i++)
            {
                MessageBox.Show("Peek : " + stack.Peek().ToString());
            }

            // 데이터를 추출 후 우선순위 재정렬
            // .Pop() : 데이터 추출 및 재정렬하는 기능
            while(stack.Count > 0)
            {
                MessageBox.Show(stack.Pop().ToString());
            }
        }
        #endregion

        #region < Dictionary >
        private void btnDictionary_Click(object sender, EventArgs e)
        {
            // Dictionary
            // 데이터가 담기는 주소를 Key로 설정하여 데이터를 등록하는 자료형 구조
            
            // 1. Dictionary 생성
            Dictionary<string, int> dic = new Dictionary<string, int>();

            // 2. Dictionary에 데이터 등록
            dic.Add("하나", 10); // 키와 값의 데이터 자료형을 잘 확인해서 입력시켜주기
            dic.Add("둘", 20);
            dic.Add("셋", 30);
            dic.Add("넷", 40);

            dic["다섯"] = 50; // 다섯이라는 키를 가진 요소를 새로 생성하면서 50 값을 할당한다.

            // 3. Dic 데이터 확인
            MessageBox.Show(dic["셋"].ToString());

            // 4. Dic 복사
            // 참조 전달 복사(주소 전달) - 얕은 복사 방법
            Dictionary<string, int> Mydic_Copy = dic;
            Mydic_Copy["하나"] = 100;
            MessageBox.Show(dic["하나"].ToString());

            // 값 형태로 복사하는 방법 (깊은 복사 방법)
            // MyDic_Copy2이라는 이름으로 Dictionary 클래스의 기능을 사용할껀데
            // dic에 있는 값으로 새로운 메모리 데이터를 만들어서 할당하여 사용하게 하는 방식
            Dictionary<string, int> MyDic_Copy2 = new Dictionary<string, int>(dic);
            dic["하나"] = 4000;
            MessageBox.Show(MyDic_Copy2["하나"].ToString());

            // 5. Key를 사용하고 있는지 확인하는 기능
            if (dic.ContainsKey("열"))
            {
                MessageBox.Show("열라는 키를 사용하고 있습니다.");
            }
            else
            {
                MessageBox.Show("열 라는 키를 사용하고 있지 않습니다.");
            }

            // 6. Value 의 사용유무 확인
            if (dic.ContainsValue(100))
            {
                MessageBox.Show("100 값이 포함되어 있습니다");
            }
            else
            {
                MessageBox.Show("100 값이 포함되어 있지 않습니다.");
            }

            // 데이터의 삭제
            dic.Remove("둘"); // "둘"이라는 key의 요소를 삭제한다.
            // dic의 Remove 는 해당 Key가 존재하지 않은 경우, 오류가 반환되지 않는다.
        }
        #endregion

        #region < HashTable >
        private void btnHashTable_Click(object sender, EventArgs e)
        {
            // HashTable
            // Dictionary와 유사한 기능을 가졌지만
            // Key와 Value의 데이터 유형을 따로 정해주지 않는다. (object 방식)
            // Value의 내용이 데이터 타입이 지정되지 않았으므로
            // 호출 시에는 반드시 형 변환 과정이 필요하다.

            // 생성 및 데이터 등록
            Hashtable ht = new Hashtable();
            ht.Add("하나", 1);
            ht[10] = "십";
            ht["소수"] = 1.2;
            ht.Add(true, "트루");
            ht.Add("배열", new int[] {1,2,3,4,5});

            // 2. HashTable의 데이터 표현
            // (int) : 명시적 형변환 캐스팅(강제 형변환)
            //         * 반드시 변형되어야하는 데이터 형이 정해져 있어(일치해)야 한다.
            int iValue = (int)ht["하나"]; // unboxing을 통한 데이터 타입 일치

            // 3. HashTable에 데이터 등록방법(초기화)
            // 3-1 Dictionary 초기자로 초기화하는 방식
            Hashtable ht2 = new Hashtable()
            {
                ["하나"] = 10,
                ["둘"]   = 20,
                [2]      = "둘",
                [1.3]    = 1.3
            };
            int[] iValues = new int[] { 1, 2, 3, 4 }; // 위의 방식은 이와 같은 방식이다.

            // 3-2 컬렉션의 초기자로 초기화하는 방식
            Hashtable ht3 = new Hashtable()
            {
                {"하나", 1 },
                {"둘", 2},
                {1.3, 1.2}
            };
            int[,] iValues2 = new int[3, 2] { { 1, 2 }, { 2, 3 }, { 3, 4 } };

            // 4. hashtable의 복사 방법
            // 4-1 얕은 복사
            Hashtable ht4 = ht;

            // 4-2 깊은 복사
            // Heap에 등록된 값을 그대로 복사하여 새로 생성된 주소를
            // 새로운 객체에 전달하는 방식 = 깊은 복사
            Hashtable ht5 = new Hashtable(ht);

            // 5. 키와 값을 추가
            ht.Add("뮥", 10);

            // 6. 키와 값 삭제
            ht.Remove("뮥");

            // 7. 키의 존재 여부 확인
            ht.ContainsKey("육"); // "육"이라는 Key가 존재하는지 확인
            bool bCheck;
            bCheck = ht.ContainsKey("육");

            // 8. 값의 존재 여부 확인
            bCheck = ht.ContainsValue(102);

            // 9. 데이터의 삭제
            ht.Clear(); // 모든 데이터 삭제
        }
        #endregion

        // 자료형 구조. Collection
        // 크게 두 가지 유형으로 나뉜다.
        // 1. 주소값 index 로 데이터를 관리하는 유형 - 조회를 많이 해야할 때
        //    - int[], List, ArrayList
        //    . 수정, 삭제 시 인덱스를 재정렬하고 주소값을 전달해야하는 과정이 발생하여
        //      갱싱 속도가 떨어진다.
        //    . index 주소 값을 곧바로 찾아가므로 조회에 대한 성능은 좋다

        // 2. Key 정보를 바탕으로 주소를 찾아가서 데이터를 관리하는 유형 - 데이터 관리를 많이 할 때
        //    - Dictionary, Hashtable
        //    . 지정한 key를 통해 데이터를 등록, 삭제하므로 Heap의 변경에 관계없이
        //      부하를 낮출 수 있어서 수정, 삭제, 추가의 효율이 높다.
        //    . 조회의 성능은 떨어진다. (Key를 통하여 Heap 메모리 주소를 참조)
    }
}