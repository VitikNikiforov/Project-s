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
        #region переменные фишек

        public Random rnd = new Random();

        public int step = 0; //пременная для выполнения только одного if
        public int turn = 0;

        public int x; //позиция фишки по Х
        public int y; //позиция фишки по Y

        public int round; //колличество пройденых кругов

        public int money; //денег на счете

        public bool die;
        public bool spravka;

        #endregion

        #region методы фишек

        public ConsoleColor color; //цвет фишки

        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = color;
            Console.Write(" ");

        }//отрисовка позиции фишки

        public void cube()
        {
            turn = rnd.Next(1, 7);
        }//Кубыч

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
            #region проверка субсидий

            if (x == 15 && y == 1)
            {
                money = money + 100;
            }

            if (x == 10 && y == 22)
            {
                money = money + 100;
            }

            if (x == 1 && y == 9)
            {
                money = money + 100;
            }

            if (x == 22 && y == 15)
            {
                money = money + 100;
            }

            #endregion

            #region проверка налоговой

            if (x == 22 && y == 18)
            {
                money = money - 200;
            }

            if (x == 1 && y == 13)
            {
                money = money - 200;
            }

            if (x == 19 && y == 1)
            {
                money = money - 200;
            }

            if (x == 11 && y == 22)
            {
                money = money - 200;
            }

            #endregion

            #region проверка карточек

            if (x == 1 && y == 20)
            {
                carts();
            }

            if (x == 8 && y == 1)
            {
                carts();
            }

            if (x == 18 && y == 22)
            {
                carts();
            }

            if (x == 22 && y == 12)
            {
                carts();
            }

            #endregion

        }//действие на координату

        public void carts()
        {
            Console.SetCursorPosition(5, 25);
            Console.ResetColor();
            Console.Write("Карта игрока:");

            Console.SetCursorPosition(18, 25);
            Console.BackgroundColor = color;
            Console.Write(" ");

            switch (rnd.Next(1, 7))
            {
                case 1:

                    //Console.Write("                   ");

                    Console.SetCursorPosition(2, 29);
                    Console.ResetColor();
                    Console.Write("Ваша жена попросила");

                    Console.SetCursorPosition(2, 31);
                    Console.ResetColor();
                    Console.Write("оплатить ей маникюр");

                    Console.SetCursorPosition(2, 40);
                    Console.ResetColor();
                    Console.Write("-" + "1000 " + "монет");

                    money = money - 1000;

                    break;

                case 2:

                    //Console.Write("                   ");

                    Console.SetCursorPosition(2, 29);
                    Console.ResetColor();
                    Console.Write("У вас сломалась");

                    Console.SetCursorPosition(2, 31);
                    Console.ResetColor();
                    Console.Write("машина, придеться");

                    Console.SetCursorPosition(2, 33);
                    Console.ResetColor();
                    Console.Write("ехать на такси");

                    Console.SetCursorPosition(2, 40);
                    Console.ResetColor();
                    Console.Write("-" + "500 " + "монет");

                    money = money - 500;

                    break;

                case 3:

                    //Console.Write("                   ");

                    Console.SetCursorPosition(2, 29);
                    Console.ResetColor();
                    Console.Write("Вы выиграли патент");

                    Console.SetCursorPosition(2, 31);
                    Console.ResetColor();
                    Console.Write("на постройку кафе.");

                    Console.SetCursorPosition(2, 33);
                    Console.ResetColor();
                    Console.Write("Оформим их  как ЗП");

                    Console.SetCursorPosition(2, 40);
                    Console.ResetColor();
                    Console.Write("+" + "750 " + "монет");

                    money = money + 750;

                    break;

                case 4:

                    //Console.Write("                   ");

                    Console.SetCursorPosition(2, 29);
                    Console.ResetColor();
                    Console.Write("Вам понадобилось");

                    Console.SetCursorPosition(2, 31);
                    Console.ResetColor();
                    Console.Write("купить новенький");

                    Console.SetCursorPosition(2, 33);
                    Console.ResetColor();
                    Console.Write("ипхон для любовницы");

                    Console.SetCursorPosition(2, 40);
                    Console.ResetColor();
                    Console.Write("-" + "1200 " + "монет");

                    money = money - 1199;

                    break;

                case 5:

                    //Console.Write("                   ");

                    Console.SetCursorPosition(2, 29);
                    Console.ResetColor();
                    Console.Write("Вас напрвили");

                    Console.SetCursorPosition(2, 31);
                    Console.ResetColor();
                    Console.Write("получить справку");

                    Console.SetCursorPosition(2, 33);
                    Console.ResetColor();
                    Console.Write("о наличии справки");

                    Console.SetCursorPosition(2, 40);
                    Console.ResetColor();
                    Console.Write("-" + "200 " + "монет");

                    money = money - 200;

                    break;

                case 6:

                    //Console.Write("                   ");

                    Console.SetCursorPosition(2, 29);
                    Console.ResetColor();
                    Console.Write("Вас замучал сушняк,");

                    Console.SetCursorPosition(2, 31);
                    Console.ResetColor();
                    Console.Write("вы купили epta-cola");

                    Console.SetCursorPosition(2, 40);
                    Console.ResetColor();
                    Console.Write("-" + "200 " + "монет");

                    money = money - 79;

                    break;
            }


        }//карточки

        public void rip()
        {
            if(money <= 0)
            {
                die = true;
                spravka = true;
            }
        }

        #endregion







    }
}










