using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Monopoly
{

    //Класс для создания, перемещения фишек и обработки координат
    class dibs
    {
        public Random rnd = new Random();
        public int step = 0; //пременная для выполнения только одного if
        public int turn = 0;

        public int x; //позиция фишки по Х
        public int y; //позиция фишки по Y

        public int round; //колличество пройденых кругов

        public int money; //денег на счете





        public ConsoleColor color; //цвет фишки

        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = color;
            Console.Write(" ");

        }//отрисовка позиции фишки

        public void dvizh()
        {
            //Console.SetCursorPosition(60, 20);
            //Console.Write(turn);


            while (turn > 0 && turn < 7)
            {

                step++;

                if (x <= 21 && y == 1 && step == 1)
                {
                    Thread.Sleep(5);

                    clear();

                    x++;

                    draw();

                    step--;
                    turn--;
                }

                if (x == 22 && y <= 21 && step == 1)
                {
                    Thread.Sleep(5);

                    clear();

                    y++;

                    draw();

                    step--;
                    turn--;
                }

                if (x >= 2 && y == 22 && step == 1)
                {
                    Thread.Sleep(5);

                    clear();

                    x--;

                    draw();

                    step--;
                    turn--;
                }

                if (x == 1 && y <= 22 && step == 1)
                {
                    Thread.Sleep(5);

                    clear();

                    y--;

                    draw();

                    step--;
                    turn--;
                }

            }
        }//пердвижение фишки

        public void clear()
        {
            Console.SetCursorPosition(x, y);
            Console.ResetColor();
            Console.Write(" ");
        }//очистка старой позиции фишки

        public void take()
        {
            if (x == 15 && y == 1)
            {
                money = money + 1;
            }

            if (x == 10 && y == 22)
            {
                money = money + 1;
            }

            if (x == 1 && y == 9)
            {
                money = money + 1;
            }

            if (x == 22 && y == 15)
            {
                money = money + 1;
            }



            if (x == 22 && y == 18)
            {
                money = money - 2;
            }

            if (x == 1 && y == 13)
            {
                money = money - 2;
            }

            if (x == 19 && y == 1)
            {
                money = money - 2;
            }

            if (x == 11 && y == 22)
            {
                money = money - 2;
            }

        }//действие на координату



        public void cube()
        {
            turn = rnd.Next(1, 7);
        }
    }






}










