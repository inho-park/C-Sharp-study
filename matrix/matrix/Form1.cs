using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix
{
    public partial class Form1 : Form
    {

        short widthSpace = 1,heightSpace = 1;
        float totalHeight, totalWidth;
        float height, width;
        int cntX = 0, cntY = 0;
        Block[,] blocks;
        PointF beginPoint, endPoint;
        Graphics g;
        Pen width_p, height_p;

        CurrentStatus[] currentStatuses = (CurrentStatus[])Enum.GetValues(typeof(CurrentStatus));
        CurrentSort[] currentSorts = (CurrentSort[])Enum.GetValues(typeof(CurrentSort));

        public Form1()
        {
            InitializeComponent();
            foreach (CurrentSort sort in currentSorts)
            {
                cboxSort.Items.Add(sort.ToString());
            }
            
            width_p = new Pen(Color.Red);
            height_p = new Pen(Color.Blue);
        }


        /// <summary>
        ///  입력시 생성하기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            widthSpace = short.Parse(tboxWidth.Text);
            heightSpace = short.Parse(tboxHeight.Text);
            
            if (widthSpace < 1 || widthSpace > 200) 
                MessageBox.Show("1 ~ 200 사이의 값 입력", "가로 칸 범위 초과");
            if (heightSpace < 1 || heightSpace > 50) 
                MessageBox.Show("1 ~ 50 사이의 값 입력", "세로 칸 범위 초과");
            else
            {
                g.Clear(Color.White);
                blocks = new Block[heightSpace, widthSpace];
                for (int i = 0; i < heightSpace; i++)
                {
                    for (int j = 0; j < widthSpace; j++)
                    {
                        //blocks[i, j] = new Block();
                        blocks[i, j] = new Block();
                    }
                }
                drawingRectangle();
            }
        }

        /// <summary>
        /// 세로 기준에 맞춰 가로 선을 긋는 함수
        /// </summary>
        private void drawingWidthLine()
        {
            height = totalHeight / heightSpace;
            for (float next = 10; next <= totalHeight + 10; next += height)
            {
                beginPoint = new PointF(10, next);
                endPoint = new PointF((float)pBox.Size.Width - 10, next);
                g.DrawLine(width_p, beginPoint, endPoint);
            }
        }
        /// <summary>
        /// 가로 기준에 맞춰 세로 선을 긋는 함수
        /// </summary>
        private void drawingHeightLine()
        {
            width = totalWidth / widthSpace;
            
            for (float next = 10; next <= totalWidth + 10; next += width)
            {
                beginPoint = new PointF(next, 10);
                endPoint = new PointF(next, (float)pBox.Size.Height - 10);
                g.DrawLine(height_p, beginPoint, endPoint);
            }
        }

        private void drawingRectangle()
        {
            height = totalHeight / heightSpace;
            width = totalWidth / widthSpace;

            for (float nextX = 10; nextX < totalWidth + 10; nextX += width)
            {
                for (float nextY = 10; nextY < totalHeight + 10; nextY += height)
                {
                    g.DrawRectangle(new Pen(Color.Black), nextX, nextY, width, height);
                }
            }
        }

        /// <summary>
        /// 1. 클릭한 마우스 위치의 프로퍼티를 통해 마우스 위치 받아오기<br/>
        /// 2. 각 칸의 크기는 입력값에 따라 상대적이므로 마진을 해당 값의 비율로 설정<br/>
        /// 3. 사각형 채우기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBox_MouseClick(object sender, MouseEventArgs e)
        {
            float mouseX = e.X, mouseY = e.Y;

            //  범위 이탈 시 return
            if (mouseX < 10) 
                return;
            else if (mouseX > totalWidth + 10) 
                return;
            else if (mouseY < 10) 
                return;
            else if (mouseY > totalHeight + 10) 
                return;


            // 마진을 10씩 상하좌우로 넣어줬으니 10 으로 초기화 해주기
            float x = 10, y = 10;

            // 채울 화면의 x값 설정
            for (cntX = 0; x + width < mouseX; x += width)
                cntX++;
            x += width / 13;

            // 채울 화면의 y값 설정
            for (cntY = 0; y + height < mouseY; y += height)
                cntY++;

            y += height / 13;

            blocks[cntY, cntX].ClickCount++;
            
            // 클릭 횟수에 따른 해당 블럭의 필드 및 색 변화
            string cnt = lblCount.Text = blocks[cntY, cntX].ClickCount.ToString();
            switch(short.Parse(cnt))
            {
                case 1:
                    blocks[cntY, cntX].Status = currentStatuses[0].ToString();
                    g.FillRectangle(new SolidBrush(Color.LightYellow), x, y, width / 13 * 11, height / 13 * 11);
                    break;
                case 2:
                    blocks[cntY, cntX].Status = currentStatuses[1].ToString();
                    g.FillRectangle(new SolidBrush(Color.Yellow), x, y, width / 13 * 11, height / 13 * 11);
                    break;
                case 3:
                    blocks[cntY, cntX].Status = currentStatuses[2].ToString();
                    g.FillRectangle(new SolidBrush(Color.GreenYellow), x, y, width / 13 * 11, height / 13 * 11);
                    break;
                default:
                    blocks[cntY, cntX].Status = currentStatuses[3].ToString();
                    g.FillRectangle(new SolidBrush(Color.Green), x, y, width / 13 * 11, height / 13 * 11);
                    break;

            }
            lblStatus.Text = blocks[cntY, cntX].Status;

            lblDirection.Text = setSort(cboxSort.SelectedItem.ToString());
        }


        private string setSort(string enumSort)
        {
            string result = "";
            CurrentSort sort = (CurrentSort)Enum.Parse(typeof(CurrentSort), enumSort);
            switch((int)sort)
            {
                case 1:
                    result = ((cntY * widthSpace) + (cntX + 1)).ToString();
                    break;
                case 2:
                    result = ((cntX * heightSpace) + (cntY + 1)).ToString();
                    break;
                case 3:
                    if ((cntY + 1) % 2 == 1) 
                        result = ((cntY * widthSpace) + (cntX + 1)).ToString();
                    else 
                        result = ((cntY * widthSpace) + (widthSpace - cntX)).ToString();
                    break;
                case 4:
                    if ((cntX + 1) % 2 == 1)
                        result = ((cntX * heightSpace) + (cntY + 1)).ToString();
                    else 
                        result = ((cntX * heightSpace) + (heightSpace - cntY)).ToString();
                    break;
                case 5:
                    result = String.Format("X : {0}번째, Y : {1}번째 ", cntX + 1, cntY + 1);
                    break;
                default:
                    break;
            }

            return result;
        }


        /// <summary>
        /// Form 이 shown 되는 상태에서 사용 <br/>
        /// 마진을 항상 상하좌우로 10씩 주기 위해 total 값을 -20 씩 계산하여 초기화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            g = pBox.CreateGraphics();
            g.Clear(Color.White);
            totalHeight = (float)pBox.Size.Height - 20;
            totalWidth = (float)pBox.Size.Width - 20;
            drawingWidthLine();
            drawingHeightLine();
            cboxSort.SelectedIndex = 0;
        }



    }
}
