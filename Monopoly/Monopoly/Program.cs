using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            Console.SetWindowSize(100, 43);//Размер окна

            Console.CursorVisible = false;

            string up1 = null; //здания сверху
            string up2 = null;
            string up3 = null;

            string right1 = null; //здания справа
            string right2 = null;
            string right3 = null;

            string down1 = null; //здания снизу
            string down2 = null;
            string down3 = null;

            string left1 = null; //здания слева
            string left2 = null;
            string left3 = null;

            dibs red = new dibs();
            red.x = 1;
            red.y = 1;
            red.round = 1;
            red.money = 3000;
            red.color = ConsoleColor.Red;

            dibs blue = new dibs();
            blue.x = 1;
            blue.y = 1;
            blue.round = 1;
            blue.money = 3000;
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
                }//внешнее поле

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
                }//внутренее поле

                for (int i = 0; i <= polex; i++)
                {
                    

                    if (i < 15)
                    {

                        Console.SetCursorPosition(polex, i + 27);
                        Console.BackgroundColor = ConsoleColor.DarkGray;//Правый
                        Console.Write(" ");

                        Console.SetCursorPosition(0, i + 27);
                        Console.BackgroundColor = ConsoleColor.DarkGray;//Левый
                        Console.Write(" ");

                    }

                    Console.SetCursorPosition(i, 27);
                    Console.BackgroundColor = ConsoleColor.DarkGray;//Верхний
                    Console.Write(" ");

                    Console.SetCursorPosition(i, 42);
                    Console.BackgroundColor = ConsoleColor.DarkGray;//Нижний
                    Console.Write(" ");
                }//поле карточек


                // стрелка вверх
                Console.SetCursorPosition(25, 37);
                Console.ResetColor();
                Console.Write("↑:" + "действие");
                //стрелка вправо
                Console.SetCursorPosition(25, 39);
                Console.ResetColor();
                Console.Write("→:" + "бросить кубик");
                //стрелка вниз
                Console.SetCursorPosition(25, 41);
                Console.ResetColor();
                Console.Write("↓:" + "покупка");

                //поле подскзаок

                Console.SetCursorPosition(45, 37);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("O:" + "субсидии");

                Console.SetCursorPosition(45, 39);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("*:" + "налоговая");

                Console.SetCursorPosition(45, 41);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("?:" + "карточка");

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
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Write(" ");

                Console.SetCursorPosition(5, 0);
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Write(" ");

                Console.SetCursorPosition(17, 0);
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Write(" ");



                Console.SetCursorPosition(23, 5);
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" ");

                Console.SetCursorPosition(23, 10);
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" ");

                Console.SetCursorPosition(23, 17);
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Write(" ");



                Console.SetCursorPosition(4, 23);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(" ");

                Console.SetCursorPosition(14, 23);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(" ");

                Console.SetCursorPosition(19, 23);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(" ");



                Console.SetCursorPosition(0, 3);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");

                Console.SetCursorPosition(0, 12);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");

                Console.SetCursorPosition(0, 18);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");

                //Поле карточек

                Console.SetCursorPosition(0, 20);
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("?");

                Console.SetCursorPosition(8, 0);
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("?");

                Console.SetCursorPosition(18, 23);
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("?");

                Console.SetCursorPosition(23, 12);
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("?");

            }//поле рисовалка

            void list()
            {
                clearlist();

                Console.SetCursorPosition(25, 1);
                Console.BackgroundColor = red.color;
                Console.Write(" ");

                Console.SetCursorPosition(25, 3);
                Console.ResetColor();
                Console.Write("Счет: " + red.money);

                ///////////////////////////////////////////////

                Console.SetCursorPosition(41, 1);
                Console.BackgroundColor = blue.color;
                Console.Write(" ");

                Console.SetCursorPosition(41, 3);
                Console.ResetColor();
                Console.Write("Счет: " + blue.money);

                ///////////////////////////////////////////////

                Console.SetCursorPosition(57, 1);
                Console.BackgroundColor = yellow.color;
                Console.Write(" ");

                Console.SetCursorPosition(57, 3);
                Console.ResetColor();
                Console.Write("Счет: " + yellow.money);
                              
            }//пользовательский интерфейс

            void clearlist()
            {
                for (int i = 0; i < 9; i++)
                {
                    Console.SetCursorPosition(30+i, 3);
                    Console.ResetColor();
                    Console.Write(' ');

                    ///////////////////////////////////////////////

                    Console.SetCursorPosition(46, 3);
                    Console.ResetColor();
                    Console.Write(' ');

                    ///////////////////////////////////////////////

                    Console.SetCursorPosition(62, 3);
                    Console.ResetColor();
                    Console.Write(' ');
                }

                
            }//очистка счета игроков

            void clearcarts()
            {
                for (int i = 28; i < 42; i++)
                {
                    for (int j = 1; j < 23; j++)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.ResetColor();
                        Console.Write(' ');
                    }
                }

                for (int i = 0; i < 25; i++)
                {
                    Console.SetCursorPosition(i, 25);
                    Console.ResetColor();
                    Console.Write(' ');
                }
            }//очистка поле карточек



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
                    clearcarts();
                    red.take();
                    blue.draw();
                    redtax();                  
                }


                if (key.Key == ConsoleKey.DownArrow)
                {
                    redbuy();
                    red.draw();
                    clearcarts();
                    red.take();
                    blue.draw();
                }


            }//кнопыч для красного

            void bluekey()
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key != ConsoleKey.RightArrow && key.Key != ConsoleKey.DownArrow)
                {
                    bluekey();
                }

                if (key.Key == ConsoleKey.RightArrow)
                {
                    blue.cube();//здесь происходит паранормальщина, НЕ ТРОГАТЬ!!!
                    blue.cube();//и тут тоже
                    blue.draw();
                    blue.dvizh();
                    clearcarts();
                    blue.take();
                    red.draw();
                    bluetax();
                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    bluebuy();
                    blue.draw();
                    clearcarts();
                    blue.take();
                    red.draw();
                }


            }//кнопыч для синего



            void redbuy()
            {
                if (red.x == 5 && red.y == 1 && up1 == null)
                {
                    Console.SetCursorPosition(5, 0);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = red.color;
                    Console.Write("R");

                    up1 = "R";

                    red.money = red.money - 800;
                }

                if (red.x == 11 && red.y == 1 && up2 == null)
                {
                    Console.SetCursorPosition(11, 0);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = red.color;
                    Console.Write("R");

                    up2 = "R";

                    red.money = red.money - 800;
                }

                if (red.x == 17 && red.y == 1 && up3 == null)
                {
                    Console.SetCursorPosition(17, 0);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = red.color;
                    Console.Write("R");

                    up3 = "R";

                    red.money = red.money - 800;
                }

                ///

                if (red.x == 22 && red.y == 5 && right1 == null)
                {
                    Console.SetCursorPosition(23, 5);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = red.color;
                    Console.Write("R");

                    right1 = "R";

                    red.money = red.money - 800;
                }

                if (red.x == 22 && red.y == 10 && right2 == null)
                {
                    Console.SetCursorPosition(23, 10);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = red.color;
                    Console.Write("R");

                    right2 = "R";

                    red.money = red.money - 800;
                }

                if (red.x == 22 && red.y == 17 && right3 == null)
                {
                    Console.SetCursorPosition(23, 17);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = red.color;
                    Console.Write("R");

                    right3 = "R";

                    red.money = red.money - 800;
                }

                ///

                if (red.x == 4 && red.y == 22 && down1 == null)
                {
                    Console.SetCursorPosition(4, 23);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = red.color;
                    Console.Write("R");

                    down1 = "R";

                    red.money = red.money - 800;
                }

                if (red.x == 14 && red.y == 22 && down2 == null)
                {
                    Console.SetCursorPosition(14, 23);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = red.color;
                    Console.Write("R");

                    down2 = "R";

                    red.money = red.money - 800;
                }

                if (red.x == 19 && red.y == 22 && down3 == null)
                {
                    Console.SetCursorPosition(19, 23);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = red.color;
                    Console.Write("R");

                    down3 = "R";

                    red.money = red.money - 800;
                }

                ///

                if (red.x == 1 && red.y == 3 && left1 == null)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = red.color;
                    Console.Write("R");

                    left1 = "R";

                    red.money = red.money - 800;
                }

                if (red.x == 1 && red.y == 12 && left2 == null)
                {
                    Console.SetCursorPosition(0, 12);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = red.color;
                    Console.Write("R");

                    left2 = "R";

                    red.money = red.money - 800;
                }

                if (red.x == 1 && red.y == 18 && left3 == null)
                {
                    Console.SetCursorPosition(0, 18);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = red.color;
                    Console.Write("R");

                    left3 = "R";

                    red.money = red.money - 800;
                }
            }//покупка недвижимости красным//НЕ ТРОГАТЬ ЪЬЬЪЬЬЪЪЬ

            void bluebuy()
            {
                if (blue.x == 5 && blue.y == 1 && up1 == null)
                {
                    Console.SetCursorPosition(5, 0);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = blue.color;
                    Console.Write("B");

                    up1 = "B";

                    blue.money = blue.money - 800;
                }

                if (blue.x == 11 && blue.y == 1 && up2 == null)
                {
                    Console.SetCursorPosition(11, 0);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = blue.color;
                    Console.Write("B");

                    up2 = "B";

                    blue.money = blue.money - 800;
                }

                if (blue.x == 17 && blue.y == 1 && up3 == null)
                {
                    Console.SetCursorPosition(17, 0);
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.ForegroundColor = blue.color;
                    Console.Write("B");

                    up3 = "B";

                    blue.money = blue.money - 800;
                }

                ///

                if (blue.x == 22 && blue.y == 5 && right1 == null)
                {
                    Console.SetCursorPosition(23, 5);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = blue.color;
                    Console.Write("B");

                    right1 = "B";

                    blue.money = blue.money - 800;
                }

                if (blue.x == 22 && blue.y == 10 && right2 == null)
                {
                    Console.SetCursorPosition(23, 10);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = blue.color;
                    Console.Write("B");

                    right2 = "B";

                    blue.money = blue.money - 800;
                }

                if (blue.x == 22 && blue.y == 17 && right3 == null)
                {
                    Console.SetCursorPosition(23, 17);
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = blue.color;
                    Console.Write("B");

                    right3 = "B";

                    blue.money = blue.money - 800;
                }

                ///

                if (blue.x == 4 && blue.y == 22 && down1 == null)
                {
                    Console.SetCursorPosition(4, 23);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = blue.color;
                    Console.Write("B");

                    down1 = "B";

                    blue.money = blue.money - 800;
                }

                if (blue.x == 14 && blue.y == 22 && down2 == null)
                {
                    Console.SetCursorPosition(14, 23);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = blue.color;
                    Console.Write("B");

                    down2 = "B";

                    blue.money = blue.money - 800;
                }

                if (blue.x == 19 && blue.y == 22 && down3 == null)
                {
                    Console.SetCursorPosition(19, 23);
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = blue.color;
                    Console.Write("B");

                    down3 = "B";

                    blue.money = blue.money - 800;
                }

                ///

                if (blue.x == 1 && blue.y == 3 && left1 == null)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = blue.color;
                    Console.Write("B");

                    left1 = "B";

                    blue.money = blue.money - 800;
                }

                if (blue.x == 1 && blue.y == 12 && left2 == null)
                {
                    Console.SetCursorPosition(0, 12);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = blue.color;
                    Console.Write("B");

                    left2 = "B";

                    blue.money = blue.money - 800;
                }

                if (blue.x == 1 && blue.y == 18 && left3 == null)
                {
                    Console.SetCursorPosition(0, 18);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = blue.color;
                    Console.Write("B");

                    left3 = "B";

                    blue.money = blue.money - 800;
                }
            }//покупка недвижимости синим



            void redtax()
            {
                if (red.x == 5 && red.y == 1 && up1 == "B")
                {
                    red.money = red.money - 150;
                    blue.money = blue.money + 150;
                }

                if (red.x == 11 && red.y == 1 && up1 == "B")
                {
                    red.money = red.money - 175;
                    blue.money = blue.money + 175;
                }

                if (red.x == 17 && red.y == 1 && up1 == "B")
                {
                    red.money = red.money - 125;
                    blue.money = blue.money + 125;
                }

                ///

                if (red.x == 22 && red.y == 1 && up1 == "B")
                {
                    red.money = red.money - 150;
                    blue.money = blue.money + 150;
                }

                if (red.x == 22 && red.y == 10 && up1 == "B")
                {
                    red.money = red.money - 120;
                    blue.money = blue.money + 120;
                }

                if (red.x == 22 && red.y == 17 && up1 == "B")
                {
                    red.money = red.money - 150;
                    blue.money = blue.money + 150;
                }

                ///

                if (red.x == 4 && red.y == 22 && up1 == "B")
                {
                    red.money = red.money - 300;
                    blue.money = blue.money + 300;
                }

                if (red.x == 14 && red.y == 22 && up1 == "B")
                {
                    red.money = red.money - 150;
                    blue.money = blue.money + 150;
                }

                if (red.x == 19 && red.y == 22 && up1 == "B")
                {
                    red.money = red.money - 75;
                    blue.money = blue.money + 75;
                }

                ///

                if (red.x == 1 && red.y == 3 && up1 == "B")
                {
                    red.money = red.money - 50;
                    blue.money = blue.money + 50;
                }

                if (red.x == 1 && red.y == 12 && up1 == "B")
                {
                    red.money = red.money - 100;
                    blue.money = blue.money + 100;
                }

                if (red.x == 1 && red.y == 18 && up1 == "B")
                {
                    red.money = red.money - 250;
                    blue.money = blue.money + 250;
                }
            }//налог за посещение

            void bluetax()
            {
                if (blue.x == 5 && blue.y == 1 && up1 == "R")
                {
                    blue.money = blue.money - 150;
                    red.money = red.money + 150;
                }

                if (blue.x == 11 && blue.y == 1 && up1 == "R")
                {
                    blue.money = blue.money - 175;
                    red.money = red.money + 175;
                }

                if (blue.x == 17 && blue.y == 1 && up1 == "R")
                {
                    blue.money = blue.money - 125;
                    red.money = red.money + 125;
                }

                ///

                if (blue.x == 22 && blue.y == 1 && up1 == "R")
                {
                    blue.money = blue.money - 150;
                    red.money = red.money + 150;
                }

                if (blue.x == 22 && blue.y == 10 && up1 == "R")
                {
                    blue.money = blue.money - 120;
                    red.money = red.money + 120;
                }

                if (blue.x == 22 && blue.y == 17 && up1 == "R")
                {
                    blue.money = blue.money - 150;
                    red.money = red.money + 150;
                }

                ///

                if (blue.x == 4 && blue.y == 22 && up1 == "R")
                {
                    blue.money = blue.money - 300;
                    red.money = red.money + 300;
                }

                if (blue.x == 14 && blue.y == 22 && up1 == "R")
                {
                    blue.money = blue.money - 150;
                    red.money = red.money + 150;
                }

                if (blue.x == 19 && blue.y == 22 && up1 == "R")
                {
                    blue.money = blue.money - 75;
                    red.money = red.money + 75;
                }

                ///

                if (blue.x == 1 && blue.y == 3 && up1 == "R")
                {
                    blue.money = blue.money - 50;
                    red.money = red.money + 50;
                }

                if (blue.x == 1 && blue.y == 12 && up1 == "R")
                {
                    blue.money = blue.money - 100;
                    red.money = red.money + 100;
                }

                if (blue.x == 1 && blue.y == 18 && up1 == "R")
                {
                    blue.money = blue.money - 250;
                    red.money = red.money + 250;
                }
            }//налог за посещение 



            while (true)
            {
                list();
                redkey();



                list();
                bluekey();


  
                list();
                //yellowkey();
            }



            Console.ReadKey();
        }
    }
}
