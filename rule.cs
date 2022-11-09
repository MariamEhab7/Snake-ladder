using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ladderSnakeGame
{
    internal class rule
    {
        public static int rollDice(PictureBox dices)
        {
            int dice = 0;
            Random r = new Random();
            dice = r.Next(1, 7);
            dices.Image = Image.FromFile(@"C:\Users\Acer-\source\repos\ladderSnakeGame\Resources\" + dice + ".png");
            dices.SizeMode = PictureBoxSizeMode.StretchImage;

            return dice;

        }

        public static int move(ref int x, ref int y, int dice, int p, PictureBox pic, Label l)
        {
            if(dice+p > 100)
            {
                l.Text = "Cannot Move !";
                l.ForeColor = System.Drawing.Color.Red;

                //return;
            }
            else {
                
                for (int i = 0; i < dice; i++)
                {Application.DoEvents();
                    Thread.Sleep(300);

                if(p < 10)
                {
                    x += 55;
                    p++;
                }
                else if(p == 10)
                {
                    x = 452;
                    y = 372;
                    p++;
                }
                else if(p > 10 && p < 20)
                {
                    x -= 55;
                    p++;
                }
                else if (p == 20)
                {
                    x = 11;
                    y = 328;
                    p++;
                }
                else if (p > 20 && p < 30)
                {
                    x += 55;
                    p++;
                }
                else if (p == 30)
                {
                    x = 504;
                    y = 280;
                    p++;
                }
                else if (p > 30 && p < 40)
                {
                    x -= 55;
                    p++;
                }
                else if (p == 40)
                {
                    x = 11;
                    y = 232;
                    p++;
                }
                else if (p > 40 && p < 50)
                {
                    x += 55;
                    p++; 
                }
                else if (p == 50)
                {
                    x = 504;
                    y = 195;
                    p++;
                }
                    else if (p > 50 && p < 60)
                {
                    x -= 55;
                    p++;
                }
                else if (p == 60)
                {
                    x = 11;
                    y = 150;
                    p++;
                }
                else if (p > 60 && p < 70)
                {
                    x += 55;
                    p++;
                }
                else if (p == 70)
                {
                    x = 504;
                    y = 103;
                    p++;
                }
                else if (p > 70 && p < 80)
                {
                    x -= 55;
                    p++;
                }
                else if (p == 80)
                {
                    x = 11;
                    y = 55;
                    p++;
                }
                else if (p > 80 && p < 90)
                {
                    x += 55;
                    p++;
                }
                else if (p == 90)
                {
                    x = 504;
                    y = 13;
                    p++;
                }
                else if (p > 90 && p < 100)
                {
                    x -= 55;
                    p++;
                }

                l.Text = p.ToString();
                pic.Location = new Point(x, y);
                //p++;
            }
            }
            return p;
        }

        public static int snake(ref int x, ref int y, int p, PictureBox pic)
        {
            if (p == 40){
                x = 121; 
                y = 418;
                p = 3;
            } else if (p == 43){
                x = 121;
                y = 373;
                p = 18;
            } else if (p == 27){
                x = 131;
                y = 418;
                p = 5;
            } else if (p == 54){
                x = 504;
                y = 281;
                p = 31;
            } else if (p == 89){
                x = 395;
                y = 185;
                p = 53;
            } else if (p == 66){
                x = 231;
                y = 240;
                p = 45;
            } else if (p == 76){
                x = 121;
                y = 195;
                p = 58;
            } else if (p == 99){
                x = 11;
                y = 134;
                p = 41;
            }

            pic.Location = new Point(x, y);
            return p;
        }

        public static int ladder(ref int x, ref int y, int p, PictureBox pic)
        {
            if (p == 4)
            {
                x = 232;
                y = 327;
                p = 25;
            }
            else if (p == 13)
            {
                x = 285;
                y = 232;
                p = 46;
            }
            else if (p == 33)
            {
                x = 451;
                y = 232;
                p = 49;
            }
            else if (p == 50)
            {
                x = 451;
                y = 150;
                p = 69;
            }
            else if (p == 74)
            {
                x = 451;
                y = 13;
                p = 92;
            }
            else if (p == 42)
            {
                x = 120;
                y = 150;
                p = 63;
            }
            else if (p == 62)
            {
                x = 11;
                y = 52;
                p = 81;
            }

            pic.Location = new Point(x, y);
            return p;
        }


    }
}


//else if (p == 30)
//{
//    x = 11;
//    y = 283;
//}
//else if (p == 40)
//{
//    x = 11;
//    y = 237;
//}
//else if (p == 50)
//{
//    x = 11;
//    y = 191;
//}
//else if (p == 60)
//{
//    x = 11;
//    y = 145;
//}
//else if (p == 70)
//{
//    x = 11;
//    y = 99;
//}
//else if (p == 80)
//{
//    x = 11;
//    y = 53;
//}
//else if (p == 90)
//{
//    x = 11;
//    y = 7;
//}
//else if (p == 100)
//{
//    x = 11;
//    y = -39;
//}
//else
//{
//    x -= 55;
//}
