using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe_form : Form
    {
        Graphics g;
        string[,] BufferGrid = new string[10, 10]; //буферный массив для детекта победы
        int CanvasWidth = 0;
        int CanvasHeight = 0;
        string UserSymbol;
        string EnemySymbol;
        bool GameInProcess = false;
        int DimensionOfGrid = 10;
        NormalizeMethods NM;
        bool UserWantsRevenge = false;
        List<Point> EmptyCoords = new List<Point>();

        public TicTacToe_form()
        {
            InitializeComponent();
        }

        private void TicTacToe_form_Load(object sender, EventArgs e)
        {
            CanvasWidth = Canvas_pbox.Width;
            CanvasHeight = Canvas_pbox.Height;
            g = Canvas_pbox.CreateGraphics();
            NM = new NormalizeMethods(DimensionOfGrid);

        }

        public void RefreshCanvas()
        {
            g.Clear(Color.White);
            DrawGrid();
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    BufferGrid[i, j] = "-";

        }

        public void DrawGrid()
        {
            //Рисуй сетку тут
            int stepW = CanvasWidth / 10;
            int stepH = CanvasHeight / 10;
            int countW = CanvasWidth / stepW;
            int countH = CanvasHeight / stepH;
            int buffposX = 0;
            int buffposY = 0;
            int buffposX1 = 0;
            int buffposY1 = 0;
            int buffposNull = 0;
            g = Canvas_pbox .CreateGraphics();
            Pen p = new Pen(Color.Black,2);
            for (int i = 0; i <= countW; i++) //разлиновка поля
            {
                g.DrawLine(p, buffposX, buffposY, buffposX, CanvasHeight);
                buffposX += stepW;
            }
            for (int i = 0; i <= countH; i++)
            {
                g.DrawLine(p, buffposNull, buffposY1, CanvasWidth, buffposX1);
                buffposY1 += stepH;
                buffposX1 += stepH;
            }
        }

        public void DrawSymbol(string TargetSymbol, Point TargetCoord)
        {
            if (TargetSymbol == "X")
            {
                
                //рисование крестика
            }
            else if (TargetSymbol == "O")
            {
                //рисоваание нолика
            }

            WinDetect(TargetSymbol);
        }

        public bool CoordIsEmpty(Point TargetCoord)
        {
            if (BufferGrid[TargetCoord.X, TargetCoord.Y] == "-")
                return true;
            else return false;
        }

        public void WinDetect(string TargetSymbol)
        {
            bool WinResult = false;

            //метод горизонтальной проверки 

            //метод вертикальной проверки

            //метод проверки по диагонали слева направо

            //метод проверки по диагонали справа налево

            if (WinResult)
            {
                GameInProcess = false;
                string WhoIsWin = "";
                string Caption = "";
                if (TargetSymbol == UserSymbol)
                {
                    Caption = "Победа!";
                    WhoIsWin = "Пользователь";
                }
                else
                {
                    Caption = "Поражение!";
                    WhoIsWin = "Компьютер";
                }


                DialogResult = MessageBox.Show($"{WhoIsWin} победил! Желаете попробовать еще раз?", Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (DialogResult == DialogResult.Yes)
                {
                    UserWantsRevenge = true;
                    RefreshCanvas();
                }

            }
        }

        public void BotStep(string EnemySymbol)
        {
            Point TargetPoint = new Point();
            
            //расчет случайной координаты
            Random rnd = new Random();
            while (TargetPoint.IsEmpty && !CoordIsEmpty(TargetPoint))
            {
                int index = rnd.Next(0, EmptyCoords.Count - 1);
                TargetPoint = EmptyCoords[index];
            }
            

            if (CoordIsEmpty(TargetPoint))
            {
                Point NormalizedTargetCoord = NM.GetNormalizedCoord_BySymbol(TargetPoint, EnemySymbol);
                DrawSymbol(EnemySymbol, NormalizedTargetCoord);
            }
        }

        private void StartGame_bt_Click(object sender, EventArgs e)
        {
            RefreshCanvas();
            if (X_choice_rbt.Checked)
            {
                UserSymbol = "X";
                EnemySymbol = "O";
            }
            else
            {
                UserSymbol = "O";
                EnemySymbol = "X";
            }
                

            if (HumanEnemy_rbt.Checked)
            {
                //логика для игры по сети
            }   
            else
            {
                
                for (int i = 0; i < DimensionOfGrid; i++)
                    for (int j = 0; j < DimensionOfGrid; j++)
                    {
                        EmptyCoords.Add(new Point(i, j));
                    }

                GameInProcess = true;

            }
        }

        private void Close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Canvas_pbox_Click(object sender, MouseEventArgs e)
        {
            if (GameInProcess)
            {
                Point ClickCoord = e.Location; //координата клика по пикчербоксу
                Point BuffArrayCoord = NM.NormalizeCoordinates_ToBufferFormat(ClickCoord); //координата для пикчербокса

                if (CoordIsEmpty(BuffArrayCoord)) //проверяем координату на заполненность
                {
                    //координата свободна, работаем дальше
                    DrawSymbol(UserSymbol, NM.GetNormalizedCoord_BySymbol(ClickCoord, UserSymbol));
                    if (GameInProcess) //проверяем, не завершилась ли игра после детекта хода 
                    {
                        BotStep(EnemySymbol); //игра не завершилась, теперь ходит бот
                    }
                    else if (UserWantsRevenge) //игра завершилась, но пользователь хочет еще
                    {
                        StartGame_bt.PerformClick(); //эмулируем нажатие на кнопку старта игры
                    }
                }

            }
            

        }
    }
}
