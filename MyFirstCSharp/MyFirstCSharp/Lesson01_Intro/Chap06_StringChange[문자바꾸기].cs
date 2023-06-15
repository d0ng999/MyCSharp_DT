﻿using System;
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
    public partial class Chap06_StringChange : Form
    {
        public Chap06_StringChange()
        {
            InitializeComponent();
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            // 원본 데이터의 문자를 변수에 담기
            string sTitle = lblTitle.Text;

            // 표현해야하는 도구(텍스트 박스에)에 소문자로 변형 후 표현
            
            // 변수에 담긴 문자를 소문자로 변경
            txtLower.Text = sTitle.ToLower();
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            // 원본 데이터를 대문자로 변경 후 표현하기

            // 1. 원본 데이터 표현하기
            string sValue = lblTitle.Text;

            // 2. 대문자 변경 후 텍스트 박스에 표현
            txtUpper.Text = sValue.ToUpper();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // 특정 문자를 받아서 해당 위치에 삽입하는 로직
            string sValue = lblTitle.Text;

            // 입력할 문자열을 받아오기
            string sInsertValue = txtString.Text;

            // 입력한 위치 정보 정수형으로 변환
            int iIndex = 0;
            int.TryParse(txtIndex.Text, out iIndex);

            // 입력받은 문자열을 삽입 후 텍스트 박스에 표현하기
            // .Insert(삽입될 위치, 삽입할 문자열)
            txtInsert.Text = sValue.Insert(iIndex, sInsertValue);

            // 문자열
            // 문자가 나열되어 있는 형식
            // 각 문자별로 위치 정보가 주어진다.(인덱스 개념 - 시작은 항상 0으로 시작한다.)
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            // 문자열의 앞과 뒤에 존재하는 모든 공백을 삭제(단, 앞과 뒤만 적용)
            string sValue = lblTitle.Text;

            // 앞/뒤 공백 삭제
            txtTrim.Text = sValue.Trim();
        }

        private void btnStartTrim_Click(object sender, EventArgs e)
        {
            // 문자열의 앞에 존재하는 모든 공백을 삭제
            string sValue = lblTitle.Text;

            // 앞 열에 존재하는 모든 공백만을 삭제
            txtStartTrim.Text = sValue.TrimStart();
        }

        private void btnEndTrim_Click(object sender, EventArgs e)
        {
            // 문자열의 뒤에 존재하는 모든 공백을 삭제
            string sValue = lblTitle.Text;

            // 뒷 열에 존재하는 모든 공백만을 삭제
            txtEndTrim.Text = sValue.TrimEnd();
        }
    }
}
