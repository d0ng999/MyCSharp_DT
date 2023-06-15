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
    public partial class Chap21_Collection_Test_T : Form
    {
        public Chap21_Collection_Test_T()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 중복되지 않는 문자 찾기 (For in For)

            // 타이틀 담기
            string sTitle = lblTitle.Text;

            // 1. 기준 문자를 담을 변수
            // 캐릭터변수의 기본값 설정 -> \0 : Null의 코드값
            char cStandardWord = default(char); 

            // 중복문자가 아닌 첫 문자를 찾았을 경우를 알리는 bool값
            bool bFindFlag = false;
            for (int i = 0; i < sTitle.Length; i++)
                // 문자열(타이틀)에서 기준이 되는 문자를 가리키는 index
            {
                for (int j = 0; j < sTitle.Length; j++)
                    // j : i문자가 있는지 없는지 찾을 문자열의 index
                {
                    if (i ==  j)
                    {
                        continue;
                    }
                    // 기준 문자 i가 자기 자신을 비교할 경우, continue
                    if (sTitle[i] == sTitle[j])
                    {
                        // 중복 단어를 찾은 경우
                        bFindFlag = true;
                        break;
                    }
                }
                if (!bFindFlag)
                {
                    cStandardWord = sTitle[i];
                    break;
                }
                else
                {
                    bFindFlag = false;
                    continue;
                }
            }
            MessageBox.Show($"중복되지 않은 첫 문자는 {cStandardWord} 입니다.");

        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            // LastIndexOf 방식
            
            string sTitle = lblTitle.Text;

            // 기준 문자를 담을 변수
            char cStandardWord = default(char);

            bool bFindFlag = false; // 중복되지 않은 문자를 찾은 경우 true

            // 반복문 시작
            // i : 기준 문자가 위치하는 index 정보
            for (int i = 0;i < sTitle.Length;i++)
            {
                // 현재 기준 문자가 있는 i의 위치와
                // 기준 문자를 마지막부터 찾은 LastIndexOf의 주소 값이 같을 경우
                // 자기 자신을 의미한다 - 중복되지 않은 문자를 찾았다.
                if (i == sTitle.LastIndexOf(sTitle[i]))
                {
                    // 중복되지 않은 문자를 찾았을 경우
                    cStandardWord= sTitle[i];
                    break;
                }
            }
            if (cStandardWord != default(char))
            MessageBox.Show($"중복되지 않은 첫 문자는 {cStandardWord} 입니다.");
            else MessageBox.Show($"중복되지 않은 문자를 찾지 못했습니다.");
        }

        private void btnDicForeach_Click(object sender, EventArgs e)
        {
            // 중복되지 않은 문자열 찾기 Dictionary와 Foreach 사용
            string sTitle = lblTitle.Text;

            // 문자열에서 한 글자씩 Key값에 생성
            // Key - char형식
            Dictionary<char, int> dic = new Dictionary<char, int>();

            // 타이틀에서 한 글자씩 추출하고 dic에 키의 값으로 등록하는데
            // key의 값으로 이미 등록되어 있으면 해당 키의 value값 +=1
            // key의 값으로 등록되지 않은 상태라면 그냥 1

            foreach(char cWord in sTitle)
            {
                if (dic.ContainsKey(cWord))
                {
                    // Dictionary에 추출한 글자로 된 key가 있을 경우
                    dic[cWord]++;
                }
                else
                {
                    dic.Add(cWord, 1);
                    // dic[cWord] = 1;
                }
            }

            foreach (char cWord in dic.Keys) 
            {
                if (dic[cWord] == 1)
                {
                    MessageBox.Show("중복되지 않은 첫 글자 : " +  cWord);
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sTitle = lblTitle.Text;

            bool bFindFlag = false;

            char cWord = '\0';

            for (int i = 0; i < sTitle.Length; i++)
            {
                if (i == sTitle.LastIndexOf(sTitle[i]))
                {
                    bFindFlag = true;
                    cWord = sTitle[i];
                    break;
                }
            }

            if (bFindFlag)
            {
                MessageBox.Show(cWord.ToString());
            }
            else
            {
                MessageBox.Show("거짓");
            }


        }
    }
}
