using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomeWork
{
    class Tasks
    {
        //Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
        public static string Exercise1(float a, float b)
        {
            float rezult = 0;

            string message = "";

            if (a == b)
            {
                rezult = a * b;

                message = $"При A = B , A * B = {rezult}";
            }
            else if (a > b)
            {
                rezult = a + b;

                message = $"При A > B , A + B = {rezult}";
            }
            else
            {
                rezult = a - b;

                message = $"При A < B , A - B = {rezult}";
            }

            return message;
        }

        //Пользователь вводит 2 числа(X и Y). Определить какой четверти принадлежит точка с координатами(X, Y)
        public static string Exercise2(float x, float y)
        {
            
            string message = "";
            
            if (x==0)
            {
                if (y>0)
                {
                    message = $"Точка с координатами ( {x} : {y} ), лежит на верхней части оси Y";
                }
                else if (y==0)
                {
                    message = $"Точка с координатами ( {x} : {y} ), лежит на начальной точке оси координат";
                }
                else
                {
                    message = $"Точка с координатами ( {x} : {y} ), лежит на нижней части оси Y";
                }
            }
            else if (x > 0)
            {
                if (y==0)
                {
                    message = $"Точка с координатами ( {x} : {y} ), лежит на правой части оси X";
                }
                else if (y>0)
                {
                    message = $"Точка с координатами ( {x} : {y} ), лежит на I четверти оси координат";
                }
                else
                {
                    message = $"Точка с координатами ( {x} : {y} ), лежит на IV четверти оси координат";
                }
            }
            else
            {
                if (y == 0)
                {
                    message = $"Точка с координатами ( {x} : {y} ), лежит на леовой части оси X";
                }
                else if (y > 0)
                {
                    message = $"Точка с координатами ( {x} : {y} ), лежит на II четверти оси координат";
                }
                else
                {
                    message = $"Точка с координатами ( {x} : {y} ), лежит на III четверти оси координат";
                }
            }
            return message;
        }

        //Пользователь вводит 3 числа(A, B и С). Выведите их в консоль в порядке возрастания.
        public static string Exercise3 (float a, float b, float c)
        {
            string message = "";

            if ( ( a > b) && ( a > c ) )
            {
                if ( b > c )
                {
                    message = c + " " + b + " " + a;
                }
                else
                {
                    message = b + " " + c + " " + a;
                }
            }
            else
            {
                if ( b > c)
                {
                    if ( c > a )
                    {
                        message = a + " " + c + " " + b;
                    }
                    else
                    {
                        message = c + " " + a + " " + b;
                    }
                }
                else
                {
                    if ( b > a)
                    {
                        message = a + " " + b + " " + c;
                    }
                    else
                    {
                        message = b + " " + a + " " + c;
                    }
                }
            }

            return message;
        }

        //Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AXX+BX+C=0.
        public static string Exercise4(float a, float b, float c)
        {
            string message = "";

            double x, x1, x2, d;

            d = b * b - 4 * a * c;

            if (d < 0)
            {
                message = $" Нет решения для уравнения {a}*X*X + {b}*X + {c} = 0 , т.к. дескриминант = {d} меньше 0 ";
            }
            else if (d == 0)
            {
                x = -b / 2 * a;
                message = $" Для уравнения {a}*X*X + {b}*X + {c} = 0, при дескриминанте равном нулю решением для уравнения будет X={x} ";
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / 2 * a;
                x2 = (-b - Math.Sqrt(d)) / 2 * a;
                message = $" Для уравнения {a}*X*X + {b}*X + {c} = 0,  решением для уравнения будет X1={x1} и X2={x2} ";
            }

            return message;
        }

        //Пользователь вводит двузначное число.Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.
        public static string Exercise5(int a)
        {
            string message = "";

            int des = 0, ed = 0;

            des = a / 10;
            ed = a % 10;

            if (a > 99 || a < 10)
            {
               message = "Необходимо двухзначное число большее 10 и меньшее 99";
            }

            message = a switch
            {
                10 => "Десять",
                11 => "Одинадцать",
                12 => "Двенадцать",
                13 => "Тринадцать",
                14 => "Четырнадцать",
                15 => "Пятнадцать",
                16 => "Шестнадцать",
                17 => "Семнадцать",
                18 => "Восемндацать",
                19 => "Девятнадцать",
            };

            message = des switch
            {
                20 => "Двадцать",
                30 => "Тридцать",
                40 => "Сорок",
                50 => "Пятьдесят",
                60 => "Шестьдесят",
                70 => "Семь",
                80 => "Восемьдесят",
                90 => "Девяносто",
            };

            message += ed switch
            {
                0 => "",
                1 => " Один",
                2 => " Два",
                3 => " Три",
                4 => " Четыре",
                5 => " Пять",
                6 => " Шесть",
                7 => " Семь",
                8 => " Восемь",
                9 => " Девять",
            };

            return message;
        }
    }
}
