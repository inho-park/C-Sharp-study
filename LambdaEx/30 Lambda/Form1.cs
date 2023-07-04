using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_Lambda
{
    enum enumLambdaCase
    {
        식형식_람다식 = 0,
        문형식_람다식,
        제네릭_Func,
        제네릭_Action,
        제네릭_인자반환
    }

    public partial class Form1 : Form
    {
        /// <summary>
        /// 프로그램 진입점
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonColorChange();
        }

        private void ButtonColorChange()
        {
            // Event 함수로 색상 변경
            btnColorChange_1.Click += btnColorChange_1_Click;

            // 무명 메서드
            btnColorChange_2.Click += delegate (object sender, EventArgs e)
            {
                btnColorChange_2.BackColor = Color.Green;
            };

            // 람다식
            btnColorChange_3.Click += (sender, e) => btnColorChange_3.BackColor = Color.Crimson;
        }

        private void btnColorChange_1_Click(object sender, EventArgs e)
        {
            btnColorChange_1.BackColor = Color.Purple;
        }



        int iNowStep = 0;
        delegate int delIntFunc(int a, int b);
        delegate string delStringFunc();
        private void btnNext_Click(object sender, EventArgs e)
        {
            Lambda(iNowStep);
            iNowStep++;
        }

        private void Lambda(int iCase)
        {
            switch(iCase)
            {
                case (int)enumLambdaCase.식형식_람다식:
                    // 식형식 람다식
                    delIntFunc dInt = (a, b) => a + b;
                    int iRet = dInt(4, 5);
                    lboxResult.Items.Add(iRet.ToString());
                    delStringFunc dString = () => "Lambda Sample 식형식";
                    lboxResult.Items.Add(dString());

                    break;
                case (int)enumLambdaCase.문형식_람다식:
                    delStringFunc dstrSeqment = () =>
                    {
                        return "Lambda Sample 문형식";
                    };
                    lboxResult.Items.Add(dstrSeqment());
                    break;
                case (int)enumLambdaCase.제네릭_Func:
                    // Func<> 는 최대 16개의 arg 넣을 수 있는데 마지막에는 항상 반환값을 지정해준다
                    Func<int, int, int> fInt = (a, b) => a * b; // int, int, int = a, b, a+b
                    lboxResult.Items.Add(fInt(3, 5));
                    break;
                case (int)enumLambdaCase.제네릭_Action:
                    // 반환할 결과 값이 없음
                    Action<string, string> fString = (a, b) =>
                    {
                        string strText = String.Format("인자 값  a = {0}, b = {1}", a, b);
                        lboxResult.Items.Add(strText);
                    };
                    fString("인자 1", "인자 2");
                    break;
                case (int)enumLambdaCase.제네릭_인자반환:
                    int[] iGroup = { 1, 3, 5, 7, 9 };
                    int iSum = iGroup.Sum(x => x);
                    lboxResult.Items.Add(iSum);
                    string[] strGroup = { "XXX", "TTTTTTT", "YYYYY" };
                    int ilengthSum = strGroup.Sum(x => x.Length);
                    lboxResult.Items.Add(ilengthSum);
                    break;
                default:
                    iNowStep = 0;
                    break;
            }
        }
    }
}
