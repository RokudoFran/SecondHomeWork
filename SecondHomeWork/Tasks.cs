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

        public static string Exercise1(float A, float B)
        {
            float rezult = 0;

            string Message = "";

            if (A == B)
            {
                rezult = A * B;

                Message = $"При A = B , A * B = {rezult}";
            }
            else if (A > B)
            {
                rezult = A + B;

                Message = $"При A > B , A + B = {rezult}";
            }
            else
            {
                rezult = A - B;

                Message = $"При A < B , A - B = {rezult}";
            }

            return Message;
        }

        //Пользователь вводит 2 числа(X и Y). Определить какой четверти принадлежит точка с координатами(X, Y)

        public static string Exercise2(float X, float Y)
        {
            
            string Message = "";
            
            if (X==0)
            {
                if (Y>0)
                {
                    Message = $"Точка с координатами ( {X} : {Y} ), лежит на верхней части оси Y";
                }
                else if (Y==0)
                {
                    Message = $"Точка с координатами ( {X} : {Y} ), лежит на начальной точке оси координат";
                }
                else
                {
                    Message = $"Точка с координатами ( {X} : {Y} ), лежит на нижней части оси Y";
                }
            }
            else if (X > 0)
            {
                if (Y==0)
                {
                    Message = $"Точка с координатами ( {X} : {Y} ), лежит на правой части оси X";
                }
                else if (Y>0)
                {
                    Message = $"Точка с координатами ( {X} : {Y} ), лежит на I четверти оси координат";
                }
                else
                {
                    Message = $"Точка с координатами ( {X} : {Y} ), лежит на IV четверти оси координат";
                }
            }
            else
            {
                if (Y == 0)
                {
                    Message = $"Точка с координатами ( {X} : {Y} ), лежит на леовой части оси X";
                }
                else if (Y > 0)
                {
                    Message = $"Точка с координатами ( {X} : {Y} ), лежит на II четверти оси координат";
                }
                else
                {
                    Message = $"Точка с координатами ( {X} : {Y} ), лежит на III четверти оси координат";
                }
            }
            return Message;
        }

        //Пользователь вводит 3 числа(A, B и С). Выведите их в консоль в порядке возрастания.
        public static string Exercise3 (float A, float B, float C)
        {
            string Message = "";

            if ( ( A > B) && ( A > C ) )
            {
                if ( B > C )
                {
                    Message = C + " " + B + " " + A;
                }
                else
                {
                    Message = B + " " + C + " " + A;
                }
            }
            else
            {
                if ( B > C)
                {
                    if ( C > A )
                    {
                        Message = A + " " + C + " " + B;
                    }
                    else
                    {
                        Message = C + " " + A + " " + B;
                    }
                }
                else
                {
                    if ( B > A)
                    {
                        Message = A + " " + B + " " + C;
                    }
                    else
                    {
                        Message = B + " " + A + " " + C;
                    }
                }
            }

            return Message;
        }

        //Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AXX+BX+C=0.
        public static string Exercise4(float A, float B, float C)
        {
            string Message = "";

            double X, X1, X2, D;

            D = B * B - 4 * A * C;

            if (D < 0)
            {
                Message = $" Нет решения для уравнения {A}*X*X + {B}*X + {C} = 0 , т.к. дескриминант = {D} меньше 0 ";
            }
            else if (D == 0)
            {
                X = -B / 2 * A;
                Message = $" Для уравнения {A}*X*X + {B}*X + {C} = 0, при дескриминанте равном нулю решением для уравнения будет X={X} ";
            }
            else
            {
                X1 = (-B + Math.Sqrt(D)) / 2 * A;
                X2 = (-B - Math.Sqrt(D)) / 2 * A;
                Message = $" Для уравнения {A}*X*X + {B}*X + {C} = 0,  решением для уравнения будет X1={X1} и X2={X2} ";
            }

            return Message;
        }

        //Пользователь вводит двузначное число.Выведите в консоль прописную запись этого числа. Например при вводе “25” в консоль будет выведено “двадцать пять”.
        public static string Exercise5(int A)
        {
            string Message = "";

            int des = 0, ed = 0;

            des = A / 10;
            ed = A % 10;

            if (A > 99 || A < 10)
            {
               Message = "Необходимо двухзначное число большее 10 и меньшее 99";
            }

            Message = A switch
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

            Message = des switch
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

            Message += ed switch
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

            return Message;
        }
    }
}
