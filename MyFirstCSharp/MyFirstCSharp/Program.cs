using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstCSharp
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Main함수 내의 클래스명이 실행화면으로 표현된다.(Chap03_DataTypeConversion)
            Application.Run(new Chap34_Struct_Exam_Login());
        }
    }
}
