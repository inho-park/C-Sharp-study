using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string num = "";
        bool isA = true;
        string op = "";
        double numA = 0, numB = 0;

        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 문자열이 비어있을 시 return
        /// 파라미터 문자열을 num 문자열에 추가
        /// Result 값에 num 문자열 표시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            string FTag = (sender as Button).Tag.ToString();

            num += FTag;
            if (num.Equals("")) lblResult.Text = "0";
            else
            {
                lblResult.Text = num;
            }
        }


        /// <summary>
        /// num 문자열의 크기가 0이 될 떄까지 마지막 인덱스를 제거
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (num.Equals("")) lblResult.Text = "0";
            else
            {
                num = num.Substring(0, num.Length - 1);
                lblResult.Text = num;
            }
        }


        /// <summary>
        /// 연산자를 문자열로 받아 계산기의 lblOp 로 출력
        /// isA 는 연산자를 기준으로 전후위 값을 정하는 기준이 되는 bool
        /// num 의 크기에 따라 연산자 전위값의 입력 여부 알 수 있음
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOp_click(object sender, EventArgs e)
        {
            string OTag = (sender as Button).Tag.ToString();

            if (isA && num.Equals(""))
            {
                lblA.Text = numA.ToString();
            }
            else if (isA && !num.Equals(""))
            {
                numA = double.Parse(num);
                num = "";
                lblA.Text = numA.ToString();
            }
            else
            {
                throw new Exception("나도 생각못한 에러");
            }
            op = OTag;
            lblOp.Text = op;
            isA = !isA;
            lblB.Text = "";

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (num.Equals(""))
            {
                string temp = numA.ToString();
                if (temp.Contains("-"))
                {
                    temp = temp.Substring(1, temp.Length - 1);
                } else
                {
                    temp = "-" + temp;
                }
                num = temp;
            }
            else if (num.Contains("-")) num = num.Substring(1, num.Length - 1);
            else num = "-" + num;
            lblResult.Text = num;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            num = "";
            lblResult.Text = "0";
        }


        /// <summary>
        /// isA 로 한번 연산을 실행한 후 바로 해당 버튼을 또 누를 시를 대비
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if(!isA)
            {
                numB = double.Parse(num);
                lblB.Text = numB.ToString();
            } else
            {
                lblA.Text = numA.ToString();
            }
            
            switch(op)
            {
                case "+":
                    numA += numB;
                    break;
                case "-":
                    numA -= numB;
                    break;
                case "x":
                    numA *= numB;
                    break;
                case "/":
                    if (numB == 0)
                    {
                        lblResult.Text = "정의되지 않은 숫자입니다";
                        isA = !isA;
                        num = "";
                        return;
                    }
                    numA /= numB;
                    break;
                default:
                    break;

            }
            lblResult.Text = numA.ToString();

            // 연산 실행 후 바로 해당 버튼을 또 누를 시 초기화 방지
            if(!isA) isA = !isA;

            num = "";
        }
    }
}
