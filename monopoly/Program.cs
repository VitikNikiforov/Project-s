using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            int polex = 23;
            int poley = 23;

            int insidex = 21;
            int insidey = 21;

            Console.SetWindowSize(100, 24);//Размер окна

            Console.CursorVisible = false;

            string up1 = null; //здания сверху
            string up2 = null;
            string up3 = null;
            string up4 = null;

            string right1 = null; //здания справа
            string right2 = null;
            string right3 = null;
            string right4 = null;

            string down1 = null; //здания снизу
            string down2 = null;
            string down3 = null;
            string down4 = null;

            string left1 = null; //здания слева
            string left2 = null;
            string left3 = null;
            string left4 = null;

            dibs red = new dibs();
            red.x = 1;
            red.y = 1;
            red.round = 1;
            red.money = 1000;
            red.color = ConsoleColor.Red;


            dibs blue = new dibs();
            blue.x = 1;
            blue.y = 1;
            blue.round = 1;
            blue.money = 0;
            blue.color = ConsoleColor.Blue;

            dibs yellow = new dibs();
            yellow.x = 5;
            yellow.y = 1;
            yellow.round = 1;
            yellow.money = 0;
            yellow.color = ConsoleColor.Yellow;



            draw();



            void draw()
            {
                for (int i = 0; i <= polex; i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.BackgroundColor = ConsoleColor.DarkGray;//Левый
                    Console.Write(" ");

                    Console.SetCursorPosition(polex, i);
                    Console.BackgroundColor = ConsoleColor.DarkGray;//Правый
                    Console.Write(" ");

                    Console.SetCursorPosition(i, 0);
                    Console.BackgroundColor = ConsoleColor.DarkGray;//Верхний
                    Console.Write(" ");

                    Console.SetCursorPosition(i, poley);
                    Console.BackgroundColor = ConsoleColor.DarkGray;//Нижний
                    Console.Write(" ");
                }

                for (int i = 2; i <= insidex; i++)
                {
                    Console.SetCursorPosition(2, i);
                    Console.BackgroundColor = ConsoleColor.Gray;//Левый
                    Console.Write(" ");

                    Console.SetCursorPosition(insidex, i);
                    Console.BackgroundColor = ConsoleColor.Gray;//Правый
                    Console.Write(" ");

                    Console.SetCursorPosition(i, 2);
                    Console.BackgroundColor = ConsoleColor.Gray;//Верхний
                    Console.Write(" ");

                    Console.SetCursorPosition(i, insidey);
                    Console.BackgroundColor = ConsoleColor.Gray;//Нижний
                    Console.Write(" ");
                }


                // стрелка вверх
                Console.SetCursorPosition(25, 18);
                Console.ResetColor();
                Console.Write("↑-" + "действие");
                //стрелка вправо
                Console.SetCursorPosition(25, 20);
                Console.ResetColor();
                Console.Write("→-" + "бросить кубик");
                //стрелка вниз
                Console.SetCursorPosition(25, 22);
                Console.ResetColor();
                Console.Write("↓-" + "покупка");

                //поле подскзаок

                Console.SetCursorPosition(45, 18);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("O:" + "субсидии");

                Console.SetCursorPosition(45, 20);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("*:" + "налог");

                //поле объектов "субсидии"

                Console.SetCursorPosition(15, 2);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("O");

                Console.SetCursorPosition(10, 21);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("O");

                Console.SetCursorPosition(2, 9);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("O");

                Console.SetCursorPosition(21, 15);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("O");

                //Поле объектов "Налоговая"

                Console.SetCursorPosition(21, 18);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("*");

                Console.SetCursorPosition(2, 13);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("*");

                Console.SetCursorPosition(19, 2);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("*");

                Console.SetCursorPosition(11, 21);
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("*");

                //Поле недвижимости

                Console.SetCursorPosition(11, 0);
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Write(" ");

                Console.SetCursorPosition(15, 0);
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Write(" ");
            }//поле рисовалка

            void list()
            {
                Console.SetCursorPosition(25, 1);
                Console.BackgroundColor = red.color;
                Console.Write(" ");

                Console.SetCursorPosition(25, 3);
                Console.ResetColor();
                Console.Write("Счет: " + red.money);

                Console.SetCursorPosition(25, 5);
                Console.ResetColor();
                Console.Write("Круг: " + red.round);

                ///////////////////////////////////////////////

                Console.SetCursorPosition(41, 1);
                Console.BackgroundColor = blue.color;
                Console.Write(" ");

                Console.SetCursorPosition(41, 3);
                Console.ResetColor();
                Console.Write("Счет: " + blue.money);

                Console.SetCursorPosition(41, 5);
                Console.ResetColor();
                Console.Write("Круг: " + blue.round);

                ///////////////////////////////////////////////

                Console.SetCursorPosition(57, 1);
                Console.BackgroundColor = yellow.color;
                Console.Write(" ");

                Console.SetCursorPosition(57, 3);
                Console.ResetColor();
                Console.Write("Счет: " + yellow.money);

                Console.SetCursorPosition(57, 5);
                Console.ResetColor();
                Console.Write("Круг: " + yellow.round);

                ///////////////////////////////////////////////
                ///поле недвижимости
                



            }//пользовательский интерфейс

            void redkey()
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key != ConsoleKey.RightArrow && key.Key != ConsoleKey.DownArrow)
                {
                    redkey();
                }

                if (key.Key == ConsoleKey.RightArrow)
                {
                    red.cube();
                    red.draw();     
                    red.dvizh();
                    red.take();
                    blue.draw();

                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    redbuy();
                    red.draw();
                    red.take();
                    blue.draw();

                }
            }

            void bluekey()
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key != ConsoleKey.RightArrow)
                {
                    redkey();
                }

                if (key.Key == ConsoleKey.RightArrow)
                {
                    blue.cube();//здесь происходит паранормальщина, НЕ ТРОГАТЬ!!!
                    blue.cube();//и тут тоже
                    blue.draw();   
                    blue.dvizh();
                    blue.take();
                    red.draw();

                }


            }



            void redbuy()
            {
                if (red.x == 11 && red.y == 1 && up1 == null)
                {
                    Console.SetCursorPosition(11, 0);
                    Console.BackgroundColor = red.color;
                    Console.Write("R");

                    up1 = "R";

                    red.money = red.money - 800;
                }

                if (red.x == 15 && red.y == 1 && up1 == null)
                {
                    Console.SetCursorPosition(15, 0);
                    Console.BackgroundColor = red.color;
                    Console.Write("R");

                    up1 = "R";

                    red.money = red.money - 800;
                }
            }//покупка недвижимости



            while (true)
            {
                list();

                redkey();



                list();

                bluekey();

                //yellowkey();

                list();
            }



            Console.ReadKey();
        }
    }
}
